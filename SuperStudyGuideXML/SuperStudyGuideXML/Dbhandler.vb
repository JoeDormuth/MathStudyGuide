Imports System.Data
Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Public Class Dbhandler
    Private myConnection As OleDbConnection
    Private dsQuestion As DataSet
    Private dtQuestion As DataTable
    Private row As Integer

    Public Sub connect()
        Dim path As String = "..\..\SuperExtremeStudyGuide.mdb"
        Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path
        Try
            myConnection = New OleDbConnection(connString)
            myConnection.Open()
        Catch ex As Exception
            MessageBox.Show("Problem connecting to database", "error", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If (myConnection.State = ConnectionState.Open) Then
                myConnection.Close()
            End If
        End Try
    End Sub

    Public Sub loadQ()
        Dim daQuestion As OleDbDataAdapter
        dsQuestion = New DataSet()
        'dsQuestion.ReadXmlSchema("..\..\Questions.xsd")
        'dsQuestion.ReadXml("..\..\Questions.xml")
        Dim sqlString As String
        sqlString = "Select * from Question where numU = @numU ORDER BY numQ"
        Dim selectCommand As OleDbCommand
        selectCommand = New OleDbCommand(sqlString, myConnection)
        selectCommand.Parameters.AddWithValue("@numU", numU)
        Try
            daQuestion = New OleDbDataAdapter(selectCommand)
            daQuestion.Fill(dsQuestion, "Question")
            dtQuestion = dsQuestion.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Problem loading questions", "error", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function NextQ() As Question
        Dim thisRow As DataRow
        thisRow = dtQuestion.Rows(row)
        Dim imageFile As String = thisRow("Question")
        Dim imagePath As String = "..\..\Questions\"
        Dim thisImage As Image = Image.FromFile(imagePath + imageFile)
        Dim ansA, ansB, ansC, ansD As Boolean
        Dim Qtype As Boolean = thisRow("Qtype")
        ansA = thisRow("A")
        ansB = thisRow("B")
        ansC = thisRow("C")
        ansD = thisRow("D")
        row += 1

        If row >= dtQuestion.Rows.Count Then
            row = 0
        End If
        Dim thisQuestion As New Question(thisImage, ansA, ansB, ansC, ansD, Qtype)
        Return thisQuestion

    End Function

    Public Sub insertUser(ByVal userName As String, ByVal Password As String, ByVal credential As Boolean)
        Dim myHasher As New SHA1CryptoServiceProvider()
        Dim myEncoder As New UTF8Encoding()
        Dim clearBytes() As Byte = myEncoder.GetBytes(Password)
        Dim hashBytes() As Byte = myHasher.ComputeHash(clearBytes)
        Password = myEncoder.GetString(hashBytes)
        Dim sqlString As String = "INSERT INTO [User]([UserName], [Password], [Credential]) VALUES(@userName, @Password, @credential)"
        Dim selectCommand As OleDbCommand
        selectCommand = New OleDbCommand(sqlString, myConnection)
        selectCommand.Parameters.AddWithValue("@userName", userName)
        selectCommand.Parameters.AddWithValue("@Password", Password)
        selectCommand.Parameters.AddWithValue("@credential", credential)
        Try
            myConnection.Open()
            selectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)
        Finally
            If myConnection.State = ConnectionState.Open Then
                myConnection.Close()
            End If
        End Try

    End Sub

    Public Function verifyUser(ByVal username As String, ByVal password As String)
        Dim myHasher As New SHA1CryptoServiceProvider()
        Dim myEncoder As New UTF8Encoding()
        Dim clearBytes() As Byte = myEncoder.GetBytes(password)
        Dim hashBytes() As Byte = myHasher.ComputeHash(clearBytes)
        Dim sqlString As String
        password = myEncoder.GetString(hashBytes)
        sqlString = "SELECT Count(*) from [User] where [Password] = @password and UserName = @username"
        Dim myCommand As New OleDbCommand(sqlString, myConnection)
        myCommand.Parameters.AddWithValue("@password", password)
        myCommand.Parameters.AddWithValue("@username", username)
        Try
            myConnection.Open()
            Dim numRows As Integer = myCommand.ExecuteScalar()
            If numRows = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        Finally
            If myConnection.State = ConnectionState.Open Then
                myConnection.Close()
            End If
        End Try


    End Function

    Public Sub New()
        dsQuestion = New DataSet
        row = 0
    End Sub
End Class

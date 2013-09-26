Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.OleDb

Public Class frmPassword
    Dim PasswordOK As Boolean
    Dim contNumber As Boolean
    Dim contAlpha As Boolean
    Dim intPassword As Integer
    Dim credential As Boolean
    Dim userName As String
    Dim myDbhandler As Dbhandler


    Function IsValid() As Boolean
        Dim strPassword As String
        Dim i As Integer
        Dim PasswordOK As Boolean
        Dim hasOneNumber As Boolean
        Dim hasOneUCaseLetter As Boolean
        Dim hasOneLCaseLetter As Boolean

        PasswordOK = False

        strPassword = CStr(txtPassword.Text)

        If txtPassword.TextLength < 6 Then
            IsValid = False
        ElseIf strPassword.Length >= 6 Then
            hasOneNumber = False
            hasOneUCaseLetter = False
            hasOneLCaseLetter = False
            For i = 0 To strPassword.Length - 1
                Select Case Asc(strPassword.Substring(i, 1))
                    Case Asc("0") To Asc("9")
                        hasOneNumber = True
                    Case Asc("A") To Asc("Z")
                        hasOneUCaseLetter = True
                    Case Asc("a") To Asc("z")
                        hasOneLCaseLetter = True
                End Select
            Next
            If hasOneNumber _
            And hasOneUCaseLetter _
            And hasOneLCaseLetter And strPassword = txtConfirm.Text Then
                IsValid = True
            End If

        End If

        Return IsValid
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPassword.Click
        myDbhandler = New Dbhandler

        If IsValid() = False Then
            lblValidated.Text = "Password is invalid"
            lblValidated.BackColor = Color.Red
            txtPassword.Text = ""
            txtConfirm.Text = ""
            txtPassword.Focus()

        Else
            lblValidated.Text = "Password is valid"
            lblValidated.BackColor = Color.Green
            userName = txtUserName.Text
            If radUserInst.Checked Then
                credential = True
            End If
            myDbhandler.connect()
            myDbhandler.insertUser(txtUserName.Text, txtPassword.Text, credential)
            Dim myForm As New frmLogin
            Me.Hide()
            myForm.ShowDialog()
            Me.Close()


        End If




    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtPassword.Text = ""

        lblValidated.Text = ""
    End Sub

    Private Sub frmPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtConfirm.UseSystemPasswordChar = True
    End Sub

    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub txtConfirm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirm.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class

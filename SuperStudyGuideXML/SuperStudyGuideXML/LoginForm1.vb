Public Class frmLogin
    Private myDbhandler As Dbhandler

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        myDbhandler = New Dbhandler
        myDbhandler.connect()
        Dim verified As Boolean = myDbhandler.verifyUser(txtUsername.Text, txtPassword.Text)
        If verified Then
            Dim myForm As New frmMain
            myForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Incorrect username and password combination.")
            txtPassword.Clear()
        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

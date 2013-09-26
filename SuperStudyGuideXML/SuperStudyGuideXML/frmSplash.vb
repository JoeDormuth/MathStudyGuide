Public Class frmSplash

    Private Sub frmSplash_Load(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myForm As New SplashScreen1
        myForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        Dim myForm As New frmLogin
        Me.Hide()
        myForm.ShowDialog()
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Dim myForm As New frmPassword
        myForm.ShowDialog()

    End Sub
End Class
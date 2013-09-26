Public Class frmMain

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    'Private Sub frmMain_MouseClick(ByVal sender As System.Object, _
    'ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
    '    If e.Location.X >= 323 And e.Location.X <= 525 And e.Location.Y >= 405 And e.Location.Y <= 452 Then
    '        Dim myForm As New frmQuestion()
    '        myForm.ShowDialog()
    '    End If
    'End Sub

    Private Sub cboUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUnit.SelectedIndexChanged
        If cboUnit.SelectedIndex = 1 Then
            numU = 1
        ElseIf cboUnit.SelectedIndex = 2 Then
            numU = 2
        ElseIf cboUnit.SelectedIndex = 3 Then
            numU = 3
        ElseIf cboUnit.SelectedIndex = 4 Then
            numU = 4
        ElseIf cboUnit.SelectedIndex = 5 Then
            numU = 5
        ElseIf cboUnit.SelectedIndex = 6 Then
            numU = 6
        ElseIf cboUnit.SelectedIndex = 7 Then
            numU = 7
        ElseIf cboUnit.SelectedIndex = 8 Then
            numU = 8
        ElseIf cboUnit.SelectedIndex = 9 Then
            numU = 9
        ElseIf cboUnit.SelectedIndex = 10 Then
            numU = 10
        End If
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If cboUnit.Text <> "" Then
            Dim myForm As New frmQuestion(Me)
            Me.Hide()
            myForm.ShowDialog()
        Else
            MessageBox.Show("Please select a unit.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class

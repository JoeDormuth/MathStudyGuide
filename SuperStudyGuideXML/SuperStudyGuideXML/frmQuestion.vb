

Public Class frmQuestion
    Private row As Integer
    Private dsQuestion As DataSet
    Private ansA, ansB, ansC, ansD As Boolean
    Private myDbhandler As Dbhandler
    Private myMain As frmMain

    Private Sub frmQuestion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myMain.Show()
    End Sub


    Private Sub frmQuestion_Load(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles MyBase.Load
        myDbhandler.connect()
        myDbhandler.loadQ()
        row = 0
    End Sub


    Private Sub btnNext_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnNext.Click
        Dim thisQuestion As Question = myDbhandler.NextQ()
        Dim thisImage As Image = thisQuestion.QuestionImage
        ansA = thisQuestion.QuestionAnsA
        ansB = thisQuestion.QuestionAnsB
        ansC = thisQuestion.QuestionAnsC
        ansD = thisQuestion.QuestionAnsD
        Dim QType As Boolean = thisQuestion.QuestionQType
        If ((thisImage.Width <= picQuestion.Width) And (thisImage.Height <= picQuestion.Height)) Then
            picQuestion.SizeMode = PictureBoxSizeMode.Normal
        Else
            picQuestion.SizeMode = PictureBoxSizeMode.Zoom
        End If
        picQuestion.Image = thisImage
        If QType = True Then
            chkC.Visible = False
            chkD.Visible = False
        Else
            chkC.Visible = True
            chkD.Visible = True
        End If
        btnCheckAns.Enabled = True
        chkA.Checked = False
        chkB.Checked = False
        chkC.Checked = False
        chkD.Checked = False

    End Sub

    Private Sub btnCheckAns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAns.Click
        If ((chkA.Checked = ansA) And (chkB.Checked = ansB) And (chkC.Checked = ansC) And (chkD.Checked = ansD)) Then
            MessageBox.Show("Good Job Champ!", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("Sorry Try Again Bub", "Wrong Answer", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If

    End Sub

    Public Sub New(ByVal myMain As frmMain)
        InitializeComponent()
        Me.myMain = myMain
        myDbhandler = New Dbhandler()


    End Sub
End Class
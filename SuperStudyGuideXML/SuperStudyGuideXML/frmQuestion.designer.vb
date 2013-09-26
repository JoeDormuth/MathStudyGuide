<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNext = New System.Windows.Forms.Button
        Me.chkA = New System.Windows.Forms.CheckBox
        Me.chkB = New System.Windows.Forms.CheckBox
        Me.chkC = New System.Windows.Forms.CheckBox
        Me.chkD = New System.Windows.Forms.CheckBox
        Me.btnCheckAns = New System.Windows.Forms.Button
        Me.picQuestion = New System.Windows.Forms.PictureBox
        CType(Me.picQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(600, 507)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'chkA
        '
        Me.chkA.AutoSize = True
        Me.chkA.Location = New System.Drawing.Point(12, 414)
        Me.chkA.Name = "chkA"
        Me.chkA.Size = New System.Drawing.Size(33, 17)
        Me.chkA.TabIndex = 2
        Me.chkA.Text = "A"
        Me.chkA.UseVisualStyleBackColor = True
        '
        'chkB
        '
        Me.chkB.AutoSize = True
        Me.chkB.Location = New System.Drawing.Point(12, 439)
        Me.chkB.Name = "chkB"
        Me.chkB.Size = New System.Drawing.Size(33, 17)
        Me.chkB.TabIndex = 3
        Me.chkB.Text = "B"
        Me.chkB.UseVisualStyleBackColor = True
        '
        'chkC
        '
        Me.chkC.AutoSize = True
        Me.chkC.Location = New System.Drawing.Point(12, 462)
        Me.chkC.Name = "chkC"
        Me.chkC.Size = New System.Drawing.Size(33, 17)
        Me.chkC.TabIndex = 4
        Me.chkC.Text = "C"
        Me.chkC.UseVisualStyleBackColor = True
        '
        'chkD
        '
        Me.chkD.AutoSize = True
        Me.chkD.Location = New System.Drawing.Point(12, 485)
        Me.chkD.Name = "chkD"
        Me.chkD.Size = New System.Drawing.Size(34, 17)
        Me.chkD.TabIndex = 5
        Me.chkD.Text = "D"
        Me.chkD.UseVisualStyleBackColor = True
        '
        'btnCheckAns
        '
        Me.btnCheckAns.Enabled = False
        Me.btnCheckAns.Location = New System.Drawing.Point(600, 456)
        Me.btnCheckAns.Name = "btnCheckAns"
        Me.btnCheckAns.Size = New System.Drawing.Size(75, 45)
        Me.btnCheckAns.TabIndex = 6
        Me.btnCheckAns.Text = "Check Answer"
        Me.btnCheckAns.UseVisualStyleBackColor = True
        '
        'picQuestion
        '
        Me.picQuestion.BackColor = System.Drawing.Color.White
        Me.picQuestion.Location = New System.Drawing.Point(12, 12)
        Me.picQuestion.Name = "picQuestion"
        Me.picQuestion.Size = New System.Drawing.Size(691, 396)
        Me.picQuestion.TabIndex = 0
        Me.picQuestion.TabStop = False
        '
        'frmQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 538)
        Me.Controls.Add(Me.btnCheckAns)
        Me.Controls.Add(Me.chkD)
        Me.Controls.Add(Me.chkC)
        Me.Controls.Add(Me.chkB)
        Me.Controls.Add(Me.chkA)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.picQuestion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmQuestion"
        Me.Text = "Math 1 Study Guide Question"
        CType(Me.picQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picQuestion As System.Windows.Forms.PictureBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents chkA As System.Windows.Forms.CheckBox
    Friend WithEvents chkB As System.Windows.Forms.CheckBox
    Friend WithEvents chkC As System.Windows.Forms.CheckBox
    Friend WithEvents chkD As System.Windows.Forms.CheckBox
    Friend WithEvents btnCheckAns As System.Windows.Forms.Button
End Class

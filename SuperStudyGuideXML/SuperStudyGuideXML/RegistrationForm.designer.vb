<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmPassword
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnPassword As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPassword))
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.btnPassword = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.radUserStu = New System.Windows.Forms.RadioButton
        Me.radUserInst = New System.Windows.Forms.RadioButton
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtNote = New System.Windows.Forms.TextBox
        Me.lblValidated = New System.Windows.Forms.Label
        Me.txtConfirm = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(168, 19)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "ENTER YOUR USER NAME:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.ForeColor = System.Drawing.Color.White
        Me.PasswordLabel.Location = New System.Drawing.Point(171, 68)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 0
        Me.PasswordLabel.Text = "ENTER YOUR PASSWORD:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(171, 45)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(220, 20)
        Me.txtUserName.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(172, 90)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(220, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnPassword
        '
        Me.btnPassword.ForeColor = System.Drawing.Color.White
        Me.btnPassword.Location = New System.Drawing.Point(29, 219)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(94, 23)
        Me.btnPassword.TabIndex = 4
        Me.btnPassword.Text = "&Validate Password"
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(253, 219)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&Clear"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImage = CType(resources.GetObject("LogoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'radUserStu
        '
        Me.radUserStu.AutoSize = True
        Me.radUserStu.Checked = True
        Me.radUserStu.ForeColor = System.Drawing.Color.White
        Me.radUserStu.Location = New System.Drawing.Point(235, 176)
        Me.radUserStu.Name = "radUserStu"
        Me.radUserStu.Size = New System.Drawing.Size(62, 17)
        Me.radUserStu.TabIndex = 5
        Me.radUserStu.TabStop = True
        Me.radUserStu.Text = "Student"
        Me.radUserStu.UseVisualStyleBackColor = True
        '
        'radUserInst
        '
        Me.radUserInst.AutoSize = True
        Me.radUserInst.ForeColor = System.Drawing.Color.White
        Me.radUserInst.Location = New System.Drawing.Point(319, 176)
        Me.radUserInst.Name = "radUserInst"
        Me.radUserInst.Size = New System.Drawing.Size(69, 17)
        Me.radUserInst.TabIndex = 6
        Me.radUserInst.Text = "Instructor"
        Me.radUserInst.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(139, 219)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        '
        'txtNote
        '
        Me.txtNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.ForeColor = System.Drawing.Color.White
        Me.txtNote.Location = New System.Drawing.Point(47, 248)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(285, 80)
        Me.txtNote.TabIndex = 11
        Me.txtNote.Text = "(Note: Password must be six characters or greater with at least; one numeric char" & _
            "acter, one upper case and one lower case letter.)"
        '
        'lblValidated
        '
        Me.lblValidated.AutoSize = True
        Me.lblValidated.BackColor = System.Drawing.Color.Red
        Me.lblValidated.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidated.ForeColor = System.Drawing.Color.White
        Me.lblValidated.Location = New System.Drawing.Point(151, 314)
        Me.lblValidated.Name = "lblValidated"
        Me.lblValidated.Size = New System.Drawing.Size(0, 24)
        Me.lblValidated.TabIndex = 10
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(170, 139)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(222, 20)
        Me.txtConfirm.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(172, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RETYPE PASSWORD:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmPassword
        '
        Me.AcceptButton = Me.btnPassword
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(401, 338)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.lblValidated)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.radUserInst)
        Me.Controls.Add(Me.radUserStu)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPassword"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registration Form"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radUserStu As System.Windows.Forms.RadioButton
    Friend WithEvents radUserInst As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents lblValidated As System.Windows.Forms.Label
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

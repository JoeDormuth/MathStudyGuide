<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.btnStart = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cboUnit
        '
        Me.cboUnit.BackColor = System.Drawing.Color.DarkGreen
        Me.cboUnit.ForeColor = System.Drawing.Color.White
        Me.cboUnit.FormattingEnabled = True
        Me.cboUnit.Items.AddRange(New Object() {"", "Unit 1", "Unit 2", "Unit 3", "Unit 4", "Unit 5", "Unit 6", "Unit 7", "Unit 8", "Unit 9", "Unit 10"})
        Me.cboUnit.Location = New System.Drawing.Point(413, 422)
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.Size = New System.Drawing.Size(121, 21)
        Me.cboUnit.TabIndex = 0
        '
        'btnStart
        '
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(413, 479)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(121, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(564, 567)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.cboUnit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.Text = "Math 1 Study Guide Login"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents btnStart As System.Windows.Forms.Button

End Class

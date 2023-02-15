<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParent
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
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtTimes = New System.Windows.Forms.TextBox()
        Me.btnParentOk = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblTimes = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radParentYes = New System.Windows.Forms.RadioButton()
        Me.radParentNo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(176, 25)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(164, 26)
        Me.txtPassword.TabIndex = 0
        Me.txtPassword.Text = "XXXXX"
        '
        'txtTimes
        '
        Me.txtTimes.Location = New System.Drawing.Point(176, 66)
        Me.txtTimes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTimes.Name = "txtTimes"
        Me.txtTimes.Size = New System.Drawing.Size(164, 26)
        Me.txtTimes.TabIndex = 1
        Me.txtTimes.Text = "XX"
        '
        'btnParentOk
        '
        Me.btnParentOk.BackColor = System.Drawing.Color.Black
        Me.btnParentOk.ForeColor = System.Drawing.Color.White
        Me.btnParentOk.Location = New System.Drawing.Point(98, 182)
        Me.btnParentOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnParentOk.Name = "btnParentOk"
        Me.btnParentOk.Size = New System.Drawing.Size(167, 35)
        Me.btnParentOk.TabIndex = 2
        Me.btnParentOk.Text = "Ok"
        Me.btnParentOk.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(20, 29)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(86, 20)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'lblTimes
        '
        Me.lblTimes.AutoSize = True
        Me.lblTimes.Location = New System.Drawing.Point(20, 71)
        Me.lblTimes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimes.Name = "lblTimes"
        Me.lblTimes.Size = New System.Drawing.Size(143, 20)
        Me.lblTimes.TabIndex = 4
        Me.lblTimes.Text = "How Many Times"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radParentNo)
        Me.GroupBox1.Controls.Add(Me.radParentYes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 74)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Spelling and Vocab Once?"
        '
        'radParentYes
        '
        Me.radParentYes.AutoSize = True
        Me.radParentYes.Location = New System.Drawing.Point(7, 26)
        Me.radParentYes.Name = "radParentYes"
        Me.radParentYes.Size = New System.Drawing.Size(58, 24)
        Me.radParentYes.TabIndex = 0
        Me.radParentYes.TabStop = True
        Me.radParentYes.Text = "Yes"
        Me.radParentYes.UseVisualStyleBackColor = True
        '
        'radParentNo
        '
        Me.radParentNo.AutoSize = True
        Me.radParentNo.Checked = True
        Me.radParentNo.Location = New System.Drawing.Point(7, 44)
        Me.radParentNo.Name = "radParentNo"
        Me.radParentNo.Size = New System.Drawing.Size(49, 24)
        Me.radParentNo.TabIndex = 1
        Me.radParentNo.TabStop = True
        Me.radParentNo.Text = "No"
        Me.radParentNo.UseVisualStyleBackColor = True
        '
        'frmParent
        '
        Me.AcceptButton = Me.btnParentOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(364, 243)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTimes)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.btnParentOk)
        Me.Controls.Add(Me.txtTimes)
        Me.Controls.Add(Me.txtPassword)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmParent"
        Me.Text = "frmParent"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtTimes As TextBox
    Friend WithEvents btnParentOk As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblTimes As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radParentNo As RadioButton
    Friend WithEvents radParentYes As RadioButton
End Class

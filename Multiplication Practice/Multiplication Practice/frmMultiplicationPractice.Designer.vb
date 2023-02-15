<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiplicationPractice
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
        Me.lblMultiplicand = New System.Windows.Forms.Label()
        Me.lblMultiplier = New System.Windows.Forms.Label()
        Me.lblEquals = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblProblemNumber = New System.Windows.Forms.Label()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMultiplicand
        '
        Me.lblMultiplicand.AutoSize = True
        Me.lblMultiplicand.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiplicand.Location = New System.Drawing.Point(189, 70)
        Me.lblMultiplicand.Name = "lblMultiplicand"
        Me.lblMultiplicand.Size = New System.Drawing.Size(32, 31)
        Me.lblMultiplicand.TabIndex = 0
        Me.lblMultiplicand.Text = "X"
        Me.lblMultiplicand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMultiplier
        '
        Me.lblMultiplier.AutoSize = True
        Me.lblMultiplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiplier.Location = New System.Drawing.Point(171, 101)
        Me.lblMultiplier.Name = "lblMultiplier"
        Me.lblMultiplier.Size = New System.Drawing.Size(52, 31)
        Me.lblMultiplier.TabIndex = 2
        Me.lblMultiplier.Text = "x X"
        Me.lblMultiplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEquals
        '
        Me.lblEquals.AutoSize = True
        Me.lblEquals.Location = New System.Drawing.Point(145, 132)
        Me.lblEquals.Name = "lblEquals"
        Me.lblEquals.Size = New System.Drawing.Size(115, 13)
        Me.lblEquals.TabIndex = 3
        Me.lblEquals.Text = "__________________"
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(158, 148)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(79, 38)
        Me.txtAnswer.TabIndex = 4
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(3, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(331, 25)
        Me.lblHeading.TabIndex = 5
        Me.lblHeading.Text = "Solve the Multiplication Problems"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(123, 223)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(98, 33)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblProblemNumber
        '
        Me.lblProblemNumber.AutoSize = True
        Me.lblProblemNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProblemNumber.Location = New System.Drawing.Point(67, 70)
        Me.lblProblemNumber.Name = "lblProblemNumber"
        Me.lblProblemNumber.Size = New System.Drawing.Size(20, 17)
        Me.lblProblemNumber.TabIndex = 7
        Me.lblProblemNumber.Text = "1."
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = True
        Me.lblWrong.Location = New System.Drawing.Point(8, 189)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(21, 13)
        Me.lblWrong.TabIndex = 8
        Me.lblWrong.Text = "XX"
        Me.lblWrong.Visible = False
        '
        'frmMultiplicationPractice
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(329, 268)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.lblProblemNumber)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblMultiplier)
        Me.Controls.Add(Me.lblMultiplicand)
        Me.Controls.Add(Me.lblEquals)
        Me.Name = "frmMultiplicationPractice"
        Me.Text = "Multiplication Facts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMultiplicand As Label
    Friend WithEvents lblMultiplier As Label
    Friend WithEvents lblEquals As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblProblemNumber As Label
    Friend WithEvents lblWrong As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyActivity
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSIMath = New System.Windows.Forms.Label()
        Me.lblStudyIsland = New System.Windows.Forms.Label()
        Me.txtMath = New System.Windows.Forms.TextBox()
        Me.lblEnglish = New System.Windows.Forms.Label()
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.lblScience = New System.Windows.Forms.Label()
        Me.txtScience = New System.Windows.Forms.TextBox()
        Me.lblMyOn = New System.Windows.Forms.Label()
        Me.txtMyOn = New System.Windows.Forms.TextBox()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.mnuDailyActivity = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuParent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTimes = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpHomework = New System.Windows.Forms.GroupBox()
        Me.radHomeworkNo = New System.Windows.Forms.RadioButton()
        Me.radHomeworkYes = New System.Windows.Forms.RadioButton()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.lblMaxStudyIsland = New System.Windows.Forms.Label()
        Me.lblMaxMyOn = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnHangman = New System.Windows.Forms.Button()
        Me.btnVocab = New System.Windows.Forms.Button()
        Me.btnMultiplicationForm = New System.Windows.Forms.Button()
        Me.mnuDailyActivity.SuspendLayout()
        Me.grpHomework.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.DarkRed
        Me.lblHeading.Location = New System.Drawing.Point(200, 53)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(391, 62)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Enter Your Scores and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I want them done XX times"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSIMath
        '
        Me.lblSIMath.AutoSize = True
        Me.lblSIMath.BackColor = System.Drawing.Color.Transparent
        Me.lblSIMath.ForeColor = System.Drawing.Color.DarkRed
        Me.lblSIMath.Location = New System.Drawing.Point(147, 148)
        Me.lblSIMath.Name = "lblSIMath"
        Me.lblSIMath.Size = New System.Drawing.Size(46, 18)
        Me.lblSIMath.TabIndex = 1
        Me.lblSIMath.Text = "Math"
        '
        'lblStudyIsland
        '
        Me.lblStudyIsland.AutoSize = True
        Me.lblStudyIsland.BackColor = System.Drawing.Color.Transparent
        Me.lblStudyIsland.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStudyIsland.Location = New System.Drawing.Point(240, 124)
        Me.lblStudyIsland.Name = "lblStudyIsland"
        Me.lblStudyIsland.Size = New System.Drawing.Size(98, 18)
        Me.lblStudyIsland.TabIndex = 2
        Me.lblStudyIsland.Text = "Study Island"
        '
        'txtMath
        '
        Me.txtMath.ForeColor = System.Drawing.Color.Black
        Me.txtMath.Location = New System.Drawing.Point(199, 145)
        Me.txtMath.Name = "txtMath"
        Me.txtMath.Size = New System.Drawing.Size(47, 26)
        Me.txtMath.TabIndex = 1
        Me.txtMath.Text = "XXX"
        Me.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEnglish
        '
        Me.lblEnglish.AutoSize = True
        Me.lblEnglish.BackColor = System.Drawing.Color.Transparent
        Me.lblEnglish.Location = New System.Drawing.Point(260, 148)
        Me.lblEnglish.Name = "lblEnglish"
        Me.lblEnglish.Size = New System.Drawing.Size(59, 18)
        Me.lblEnglish.TabIndex = 4
        Me.lblEnglish.Text = "English"
        '
        'txtEnglish
        '
        Me.txtEnglish.Location = New System.Drawing.Point(325, 145)
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.Size = New System.Drawing.Size(47, 26)
        Me.txtEnglish.TabIndex = 2
        Me.txtEnglish.Text = "XXX"
        Me.txtEnglish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblScience
        '
        Me.lblScience.AutoSize = True
        Me.lblScience.BackColor = System.Drawing.Color.Transparent
        Me.lblScience.Location = New System.Drawing.Point(389, 148)
        Me.lblScience.Name = "lblScience"
        Me.lblScience.Size = New System.Drawing.Size(60, 18)
        Me.lblScience.TabIndex = 6
        Me.lblScience.Text = "Science"
        '
        'txtScience
        '
        Me.txtScience.Location = New System.Drawing.Point(455, 145)
        Me.txtScience.Name = "txtScience"
        Me.txtScience.Size = New System.Drawing.Size(47, 26)
        Me.txtScience.TabIndex = 3
        Me.txtScience.Text = "XXX"
        Me.txtScience.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMyOn
        '
        Me.lblMyOn.AutoSize = True
        Me.lblMyOn.BackColor = System.Drawing.Color.Transparent
        Me.lblMyOn.Location = New System.Drawing.Point(547, 124)
        Me.lblMyOn.Name = "lblMyOn"
        Me.lblMyOn.Size = New System.Drawing.Size(96, 18)
        Me.lblMyOn.TabIndex = 8
        Me.lblMyOn.Text = "MyOn Score"
        '
        'txtMyOn
        '
        Me.txtMyOn.Location = New System.Drawing.Point(572, 145)
        Me.txtMyOn.Name = "txtMyOn"
        Me.txtMyOn.Size = New System.Drawing.Size(47, 26)
        Me.txtMyOn.TabIndex = 4
        Me.txtMyOn.Text = "XXX"
        Me.txtMyOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.DarkRed
        Me.btnAccept.ForeColor = System.Drawing.Color.White
        Me.btnAccept.Location = New System.Drawing.Point(308, 400)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(174, 32)
        Me.btnAccept.TabIndex = 7
        Me.btnAccept.Text = "Click here when done"
        Me.btnAccept.UseVisualStyleBackColor = False
        Me.btnAccept.Visible = False
        '
        'mnuDailyActivity
        '
        Me.mnuDailyActivity.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuParent})
        Me.mnuDailyActivity.Location = New System.Drawing.Point(0, 0)
        Me.mnuDailyActivity.Name = "mnuDailyActivity"
        Me.mnuDailyActivity.Size = New System.Drawing.Size(791, 24)
        Me.mnuDailyActivity.TabIndex = 14
        Me.mnuDailyActivity.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuFile.ForeColor = System.Drawing.Color.Black
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuParent
        '
        Me.mnuParent.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTimes})
        Me.mnuParent.ForeColor = System.Drawing.Color.Black
        Me.mnuParent.Name = "mnuParent"
        Me.mnuParent.Size = New System.Drawing.Size(53, 20)
        Me.mnuParent.Text = "&Parent"
        '
        'mnuTimes
        '
        Me.mnuTimes.Name = "mnuTimes"
        Me.mnuTimes.Size = New System.Drawing.Size(106, 22)
        Me.mnuTimes.Text = "&Times"
        '
        'grpHomework
        '
        Me.grpHomework.BackColor = System.Drawing.Color.Transparent
        Me.grpHomework.Controls.Add(Me.radHomeworkNo)
        Me.grpHomework.Controls.Add(Me.radHomeworkYes)
        Me.grpHomework.Location = New System.Drawing.Point(430, 187)
        Me.grpHomework.Name = "grpHomework"
        Me.grpHomework.Size = New System.Drawing.Size(264, 149)
        Me.grpHomework.TabIndex = 5
        Me.grpHomework.TabStop = False
        Me.grpHomework.Text = "Did you give Mom or Dad your papers and tell them if you have to study or have ho" &
    "mework?"
        '
        'radHomeworkNo
        '
        Me.radHomeworkNo.AutoSize = True
        Me.radHomeworkNo.Checked = True
        Me.radHomeworkNo.Location = New System.Drawing.Point(90, 90)
        Me.radHomeworkNo.Name = "radHomeworkNo"
        Me.radHomeworkNo.Size = New System.Drawing.Size(46, 22)
        Me.radHomeworkNo.TabIndex = 5
        Me.radHomeworkNo.TabStop = True
        Me.radHomeworkNo.Text = "No"
        Me.radHomeworkNo.UseVisualStyleBackColor = True
        '
        'radHomeworkYes
        '
        Me.radHomeworkYes.AutoSize = True
        Me.radHomeworkYes.Location = New System.Drawing.Point(90, 61)
        Me.radHomeworkYes.Name = "radHomeworkYes"
        Me.radHomeworkYes.Size = New System.Drawing.Size(52, 22)
        Me.radHomeworkYes.TabIndex = 6
        Me.radHomeworkYes.Text = "Yes"
        Me.radHomeworkYes.UseVisualStyleBackColor = True
        '
        'lstScores
        '
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 18
        Me.lstScores.Location = New System.Drawing.Point(72, 230)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(174, 94)
        Me.lstScores.TabIndex = 16
        Me.lstScores.TabStop = False
        Me.lstScores.Visible = False
        '
        'lblMaxStudyIsland
        '
        Me.lblMaxStudyIsland.AutoSize = True
        Me.lblMaxStudyIsland.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxStudyIsland.Location = New System.Drawing.Point(55, 176)
        Me.lblMaxStudyIsland.Name = "lblMaxStudyIsland"
        Me.lblMaxStudyIsland.Size = New System.Drawing.Size(283, 18)
        Me.lblMaxStudyIsland.TabIndex = 17
        Me.lblMaxStudyIsland.Text = "You must have XXX out of XXX points."
        '
        'lblMaxMyOn
        '
        Me.lblMaxMyOn.AutoSize = True
        Me.lblMaxMyOn.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxMyOn.Location = New System.Drawing.Point(55, 197)
        Me.lblMaxMyOn.Name = "lblMaxMyOn"
        Me.lblMaxMyOn.Size = New System.Drawing.Size(283, 18)
        Me.lblMaxMyOn.TabIndex = 18
        Me.lblMaxMyOn.Text = "You must have XXX out of XXX points."
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkRed
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(532, 400)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(174, 32)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'btnHangman
        '
        Me.btnHangman.Location = New System.Drawing.Point(532, 355)
        Me.btnHangman.Name = "btnHangman"
        Me.btnHangman.Size = New System.Drawing.Size(174, 32)
        Me.btnHangman.TabIndex = 20
        Me.btnHangman.Text = "Hangman Spelling"
        Me.btnHangman.UseVisualStyleBackColor = True
        '
        'btnVocab
        '
        Me.btnVocab.Location = New System.Drawing.Point(308, 355)
        Me.btnVocab.Name = "btnVocab"
        Me.btnVocab.Size = New System.Drawing.Size(174, 32)
        Me.btnVocab.TabIndex = 21
        Me.btnVocab.Text = "Vocabulary Matching"
        Me.btnVocab.UseVisualStyleBackColor = True
        '
        'btnMultiplicationForm
        '
        Me.btnMultiplicationForm.Location = New System.Drawing.Point(84, 355)
        Me.btnMultiplicationForm.Name = "btnMultiplicationForm"
        Me.btnMultiplicationForm.Size = New System.Drawing.Size(174, 32)
        Me.btnMultiplicationForm.TabIndex = 22
        Me.btnMultiplicationForm.Text = "Multiplication Practice"
        Me.btnMultiplicationForm.UseVisualStyleBackColor = True
        '
        'frmDailyActivity
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Elijah_Scores.My.Resources.Resources.mk7SR2m
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(791, 506)
        Me.Controls.Add(Me.btnMultiplicationForm)
        Me.Controls.Add(Me.btnVocab)
        Me.Controls.Add(Me.btnHangman)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMaxMyOn)
        Me.Controls.Add(Me.lblMaxStudyIsland)
        Me.Controls.Add(Me.lstScores)
        Me.Controls.Add(Me.grpHomework)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.txtMyOn)
        Me.Controls.Add(Me.lblMyOn)
        Me.Controls.Add(Me.txtScience)
        Me.Controls.Add(Me.lblScience)
        Me.Controls.Add(Me.txtEnglish)
        Me.Controls.Add(Me.lblEnglish)
        Me.Controls.Add(Me.txtMath)
        Me.Controls.Add(Me.lblStudyIsland)
        Me.Controls.Add(Me.lblSIMath)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.mnuDailyActivity)
        Me.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.MainMenuStrip = Me.mnuDailyActivity
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDailyActivity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Activity"
        Me.mnuDailyActivity.ResumeLayout(False)
        Me.mnuDailyActivity.PerformLayout()
        Me.grpHomework.ResumeLayout(False)
        Me.grpHomework.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSIMath As Label
    Friend WithEvents lblStudyIsland As Label
    Friend WithEvents txtMath As TextBox
    Friend WithEvents lblEnglish As Label
    Friend WithEvents txtEnglish As TextBox
    Friend WithEvents lblScience As Label
    Friend WithEvents txtScience As TextBox
    Friend WithEvents lblMyOn As Label
    Friend WithEvents txtMyOn As TextBox
    Friend WithEvents btnAccept As Button
    Friend WithEvents mnuDailyActivity As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuParent As ToolStripMenuItem
    Friend WithEvents mnuTimes As ToolStripMenuItem
    Friend WithEvents grpHomework As GroupBox
    Friend WithEvents radHomeworkNo As RadioButton
    Friend WithEvents radHomeworkYes As RadioButton
    Friend WithEvents lstScores As ListBox
    Friend WithEvents lblMaxStudyIsland As Label
    Friend WithEvents lblMaxMyOn As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnHangman As Button
    Friend WithEvents btnVocab As Button
    Friend WithEvents btnMultiplicationForm As Button
End Class

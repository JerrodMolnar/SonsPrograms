<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyActivities
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
        Me.grpTakePills = New System.Windows.Forms.GroupBox()
        Me.radPillsNo = New System.Windows.Forms.RadioButton()
        Me.radPillsYes = New System.Windows.Forms.RadioButton()
        Me.grpSpellingWords = New System.Windows.Forms.GroupBox()
        Me.radSpellingNo = New System.Windows.Forms.RadioButton()
        Me.radSpellingYes = New System.Windows.Forms.RadioButton()
        Me.lblStudyIsland = New System.Windows.Forms.Label()
        Me.txtMath = New System.Windows.Forms.TextBox()
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.txtScience = New System.Windows.Forms.TextBox()
        Me.lblMath = New System.Windows.Forms.Label()
        Me.lblEnglish = New System.Windows.Forms.Label()
        Me.lblScience = New System.Windows.Forms.Label()
        Me.lblMyOn = New System.Windows.Forms.Label()
        Me.txtMyOn = New System.Windows.Forms.TextBox()
        Me.grpOtherHwDone = New System.Windows.Forms.GroupBox()
        Me.radSchoolworkDoneNo = New System.Windows.Forms.RadioButton()
        Me.radSchoolworkDoneYes = New System.Windows.Forms.RadioButton()
        Me.grpSchoolwork = New System.Windows.Forms.GroupBox()
        Me.radSchoolworkNo = New System.Windows.Forms.RadioButton()
        Me.radSchoolworkYes = New System.Windows.Forms.RadioButton()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnRetry = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpTakePills.SuspendLayout()
        Me.grpSpellingWords.SuspendLayout()
        Me.grpOtherHwDone.SuspendLayout()
        Me.grpSchoolwork.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Maroon
        Me.lblHeading.Location = New System.Drawing.Point(61, 38)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(563, 29)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Did You Do All That is Required Before Playing Xbox?"
        '
        'grpTakePills
        '
        Me.grpTakePills.Controls.Add(Me.radPillsNo)
        Me.grpTakePills.Controls.Add(Me.radPillsYes)
        Me.grpTakePills.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTakePills.Location = New System.Drawing.Point(41, 70)
        Me.grpTakePills.Name = "grpTakePills"
        Me.grpTakePills.Size = New System.Drawing.Size(167, 84)
        Me.grpTakePills.TabIndex = 1
        Me.grpTakePills.TabStop = False
        Me.grpTakePills.Text = "Did you take your pills?"
        '
        'radPillsNo
        '
        Me.radPillsNo.AutoSize = True
        Me.radPillsNo.Checked = True
        Me.radPillsNo.Location = New System.Drawing.Point(7, 53)
        Me.radPillsNo.Name = "radPillsNo"
        Me.radPillsNo.Size = New System.Drawing.Size(44, 22)
        Me.radPillsNo.TabIndex = 1
        Me.radPillsNo.TabStop = True
        Me.radPillsNo.Text = "No"
        Me.radPillsNo.UseVisualStyleBackColor = True
        '
        'radPillsYes
        '
        Me.radPillsYes.AutoSize = True
        Me.radPillsYes.Location = New System.Drawing.Point(7, 24)
        Me.radPillsYes.Name = "radPillsYes"
        Me.radPillsYes.Size = New System.Drawing.Size(47, 22)
        Me.radPillsYes.TabIndex = 0
        Me.radPillsYes.Text = "Yes"
        Me.radPillsYes.UseVisualStyleBackColor = True
        '
        'grpSpellingWords
        '
        Me.grpSpellingWords.Controls.Add(Me.radSpellingNo)
        Me.grpSpellingWords.Controls.Add(Me.radSpellingYes)
        Me.grpSpellingWords.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSpellingWords.Location = New System.Drawing.Point(383, 70)
        Me.grpSpellingWords.Name = "grpSpellingWords"
        Me.grpSpellingWords.Size = New System.Drawing.Size(236, 84)
        Me.grpSpellingWords.TabIndex = 2
        Me.grpSpellingWords.TabStop = False
        Me.grpSpellingWords.Text = "Did you write your spelling words?"
        '
        'radSpellingNo
        '
        Me.radSpellingNo.AutoSize = True
        Me.radSpellingNo.Checked = True
        Me.radSpellingNo.Location = New System.Drawing.Point(6, 53)
        Me.radSpellingNo.Name = "radSpellingNo"
        Me.radSpellingNo.Size = New System.Drawing.Size(44, 22)
        Me.radSpellingNo.TabIndex = 2
        Me.radSpellingNo.TabStop = True
        Me.radSpellingNo.Text = "No"
        Me.radSpellingNo.UseVisualStyleBackColor = True
        '
        'radSpellingYes
        '
        Me.radSpellingYes.AutoSize = True
        Me.radSpellingYes.Location = New System.Drawing.Point(6, 22)
        Me.radSpellingYes.Name = "radSpellingYes"
        Me.radSpellingYes.Size = New System.Drawing.Size(47, 22)
        Me.radSpellingYes.TabIndex = 2
        Me.radSpellingYes.Text = "Yes"
        Me.radSpellingYes.UseVisualStyleBackColor = True
        '
        'lblStudyIsland
        '
        Me.lblStudyIsland.AutoSize = True
        Me.lblStudyIsland.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudyIsland.ForeColor = System.Drawing.Color.Maroon
        Me.lblStudyIsland.Location = New System.Drawing.Point(219, 169)
        Me.lblStudyIsland.Name = "lblStudyIsland"
        Me.lblStudyIsland.Size = New System.Drawing.Size(222, 29)
        Me.lblStudyIsland.TabIndex = 3
        Me.lblStudyIsland.Text = "Study Island scores?"
        '
        'txtMath
        '
        Me.txtMath.Location = New System.Drawing.Point(117, 211)
        Me.txtMath.Name = "txtMath"
        Me.txtMath.Size = New System.Drawing.Size(100, 28)
        Me.txtMath.TabIndex = 4
        '
        'txtEnglish
        '
        Me.txtEnglish.Location = New System.Drawing.Point(320, 211)
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.Size = New System.Drawing.Size(100, 28)
        Me.txtEnglish.TabIndex = 5
        '
        'txtScience
        '
        Me.txtScience.Location = New System.Drawing.Point(525, 211)
        Me.txtScience.Name = "txtScience"
        Me.txtScience.Size = New System.Drawing.Size(100, 28)
        Me.txtScience.TabIndex = 6
        '
        'lblMath
        '
        Me.lblMath.AutoSize = True
        Me.lblMath.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMath.Location = New System.Drawing.Point(35, 214)
        Me.lblMath.Name = "lblMath"
        Me.lblMath.Size = New System.Drawing.Size(77, 21)
        Me.lblMath.TabIndex = 7
        Me.lblMath.Text = "Math -->"
        '
        'lblEnglish
        '
        Me.lblEnglish.AutoSize = True
        Me.lblEnglish.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnglish.Location = New System.Drawing.Point(222, 214)
        Me.lblEnglish.Name = "lblEnglish"
        Me.lblEnglish.Size = New System.Drawing.Size(93, 21)
        Me.lblEnglish.TabIndex = 8
        Me.lblEnglish.Text = "English -->"
        '
        'lblScience
        '
        Me.lblScience.AutoSize = True
        Me.lblScience.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScience.Location = New System.Drawing.Point(425, 214)
        Me.lblScience.Name = "lblScience"
        Me.lblScience.Size = New System.Drawing.Size(95, 21)
        Me.lblScience.TabIndex = 9
        Me.lblScience.Text = "Science -->"
        '
        'lblMyOn
        '
        Me.lblMyOn.AutoSize = True
        Me.lblMyOn.Font = New System.Drawing.Font("Microsoft Tai Le", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyOn.ForeColor = System.Drawing.Color.Maroon
        Me.lblMyOn.Location = New System.Drawing.Point(256, 269)
        Me.lblMyOn.Name = "lblMyOn"
        Me.lblMyOn.Size = New System.Drawing.Size(149, 29)
        Me.lblMyOn.TabIndex = 10
        Me.lblMyOn.Text = "MyOn Score?"
        '
        'txtMyOn
        '
        Me.txtMyOn.Location = New System.Drawing.Point(280, 313)
        Me.txtMyOn.Name = "txtMyOn"
        Me.txtMyOn.Size = New System.Drawing.Size(100, 28)
        Me.txtMyOn.TabIndex = 11
        '
        'grpOtherHwDone
        '
        Me.grpOtherHwDone.BackColor = System.Drawing.Color.Transparent
        Me.grpOtherHwDone.Controls.Add(Me.radSchoolworkDoneNo)
        Me.grpOtherHwDone.Controls.Add(Me.radSchoolworkDoneYes)
        Me.grpOtherHwDone.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOtherHwDone.ForeColor = System.Drawing.Color.Maroon
        Me.grpOtherHwDone.Location = New System.Drawing.Point(194, 491)
        Me.grpOtherHwDone.Name = "grpOtherHwDone"
        Me.grpOtherHwDone.Size = New System.Drawing.Size(322, 100)
        Me.grpOtherHwDone.TabIndex = 14
        Me.grpOtherHwDone.TabStop = False
        Me.grpOtherHwDone.Text = "Did you do Homework from school?"
        '
        'radSchoolworkDoneNo
        '
        Me.radSchoolworkDoneNo.AutoSize = True
        Me.radSchoolworkDoneNo.Checked = True
        Me.radSchoolworkDoneNo.ForeColor = System.Drawing.Color.Black
        Me.radSchoolworkDoneNo.Location = New System.Drawing.Point(112, 59)
        Me.radSchoolworkDoneNo.Name = "radSchoolworkDoneNo"
        Me.radSchoolworkDoneNo.Size = New System.Drawing.Size(51, 25)
        Me.radSchoolworkDoneNo.TabIndex = 3
        Me.radSchoolworkDoneNo.TabStop = True
        Me.radSchoolworkDoneNo.Text = "No"
        Me.radSchoolworkDoneNo.UseVisualStyleBackColor = True
        '
        'radSchoolworkDoneYes
        '
        Me.radSchoolworkDoneYes.AutoSize = True
        Me.radSchoolworkDoneYes.ForeColor = System.Drawing.Color.Black
        Me.radSchoolworkDoneYes.Location = New System.Drawing.Point(112, 27)
        Me.radSchoolworkDoneYes.Name = "radSchoolworkDoneYes"
        Me.radSchoolworkDoneYes.Size = New System.Drawing.Size(54, 25)
        Me.radSchoolworkDoneYes.TabIndex = 2
        Me.radSchoolworkDoneYes.Text = "Yes"
        Me.radSchoolworkDoneYes.UseVisualStyleBackColor = True
        '
        'grpSchoolwork
        '
        Me.grpSchoolwork.Controls.Add(Me.radSchoolworkNo)
        Me.grpSchoolwork.Controls.Add(Me.radSchoolworkYes)
        Me.grpSchoolwork.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSchoolwork.ForeColor = System.Drawing.Color.Maroon
        Me.grpSchoolwork.Location = New System.Drawing.Point(148, 364)
        Me.grpSchoolwork.Name = "grpSchoolwork"
        Me.grpSchoolwork.Size = New System.Drawing.Size(389, 100)
        Me.grpSchoolwork.TabIndex = 15
        Me.grpSchoolwork.TabStop = False
        Me.grpSchoolwork.Text = "Do you have any homework from school today?"
        '
        'radSchoolworkNo
        '
        Me.radSchoolworkNo.AutoSize = True
        Me.radSchoolworkNo.Checked = True
        Me.radSchoolworkNo.ForeColor = System.Drawing.Color.Black
        Me.radSchoolworkNo.Location = New System.Drawing.Point(158, 54)
        Me.radSchoolworkNo.Name = "radSchoolworkNo"
        Me.radSchoolworkNo.Size = New System.Drawing.Size(51, 25)
        Me.radSchoolworkNo.TabIndex = 5
        Me.radSchoolworkNo.TabStop = True
        Me.radSchoolworkNo.Text = "No"
        Me.radSchoolworkNo.UseVisualStyleBackColor = True
        '
        'radSchoolworkYes
        '
        Me.radSchoolworkYes.AutoSize = True
        Me.radSchoolworkYes.ForeColor = System.Drawing.Color.Black
        Me.radSchoolworkYes.Location = New System.Drawing.Point(158, 22)
        Me.radSchoolworkYes.Name = "radSchoolworkYes"
        Me.radSchoolworkYes.Size = New System.Drawing.Size(54, 25)
        Me.radSchoolworkYes.TabIndex = 4
        Me.radSchoolworkYes.Text = "Yes"
        Me.radSchoolworkYes.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.IndianRed
        Me.btnDone.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(57, 593)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(571, 65)
        Me.btnDone.TabIndex = 16
        Me.btnDone.Text = "Press Here When Done"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'btnRetry
        '
        Me.btnRetry.BackColor = System.Drawing.Color.IndianRed
        Me.btnRetry.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetry.Location = New System.Drawing.Point(59, 664)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(569, 65)
        Me.btnRetry.TabIndex = 17
        Me.btnRetry.Text = "Retry"
        Me.btnRetry.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'frmDailyActivities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(684, 733)
        Me.Controls.Add(Me.btnRetry)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.grpSchoolwork)
        Me.Controls.Add(Me.grpOtherHwDone)
        Me.Controls.Add(Me.txtMyOn)
        Me.Controls.Add(Me.lblMyOn)
        Me.Controls.Add(Me.lblScience)
        Me.Controls.Add(Me.lblEnglish)
        Me.Controls.Add(Me.lblMath)
        Me.Controls.Add(Me.txtScience)
        Me.Controls.Add(Me.txtEnglish)
        Me.Controls.Add(Me.txtMath)
        Me.Controls.Add(Me.lblStudyIsland)
        Me.Controls.Add(Me.grpSpellingWords)
        Me.Controls.Add(Me.grpTakePills)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDailyActivities"
        Me.Text = "Elijah's Daily Activities"
        Me.grpTakePills.ResumeLayout(False)
        Me.grpTakePills.PerformLayout()
        Me.grpSpellingWords.ResumeLayout(False)
        Me.grpSpellingWords.PerformLayout()
        Me.grpOtherHwDone.ResumeLayout(False)
        Me.grpOtherHwDone.PerformLayout()
        Me.grpSchoolwork.ResumeLayout(False)
        Me.grpSchoolwork.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents grpTakePills As GroupBox
    Friend WithEvents radPillsNo As RadioButton
    Friend WithEvents radPillsYes As RadioButton
    Friend WithEvents grpSpellingWords As GroupBox
    Friend WithEvents radSpellingNo As RadioButton
    Friend WithEvents radSpellingYes As RadioButton
    Friend WithEvents lblStudyIsland As Label
    Friend WithEvents txtMath As TextBox
    Friend WithEvents txtEnglish As TextBox
    Friend WithEvents txtScience As TextBox
    Friend WithEvents lblMath As Label
    Friend WithEvents lblEnglish As Label
    Friend WithEvents lblScience As Label
    Friend WithEvents lblMyOn As Label
    Friend WithEvents txtMyOn As TextBox
    Friend WithEvents grpOtherHwDone As GroupBox
    Friend WithEvents radSchoolworkDoneNo As RadioButton
    Friend WithEvents radSchoolworkDoneYes As RadioButton
    Friend WithEvents grpSchoolwork As GroupBox
    Friend WithEvents radSchoolworkNo As RadioButton
    Friend WithEvents radSchoolworkYes As RadioButton
    Friend WithEvents btnDone As Button
    Friend WithEvents btnRetry As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHangman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lstWords = New System.Windows.Forms.ListBox()
        Me.SpellingWordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkipVocabWordsDataSet = New Hangman.SkipVocabWordsDataSet()
        Me.txtInputLetter = New System.Windows.Forms.TextBox()
        Me.SpellingWordsTableAdapter = New Hangman.SkipVocabWordsDataSetTableAdapters.SpellingWordsTableAdapter()
        Me.TableAdapterManager = New Hangman.SkipVocabWordsDataSetTableAdapters.TableAdapterManager()
        Me.grpLetters = New System.Windows.Forms.GroupBox()
        Me.lblZ = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblW = New System.Windows.Forms.Label()
        Me.lblV = New System.Windows.Forms.Label()
        Me.lblU = New System.Windows.Forms.Label()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblQ = New System.Windows.Forms.Label()
        Me.lblP = New System.Windows.Forms.Label()
        Me.lblO = New System.Windows.Forms.Label()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblM = New System.Windows.Forms.Label()
        Me.lblL = New System.Windows.Forms.Label()
        Me.lblK = New System.Windows.Forms.Label()
        Me.lblj = New System.Windows.Forms.Label()
        Me.lblI = New System.Windows.Forms.Label()
        Me.lblH = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.lblF = New System.Windows.Forms.Label()
        Me.lblE = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblSecretWord = New System.Windows.Forms.Label()
        Me.lstLettersUsed = New System.Windows.Forms.ListBox()
        Me.lblWords = New System.Windows.Forms.Label()
        Me.lblLettersUsed = New System.Windows.Forms.Label()
        Me.txtSpellWord = New System.Windows.Forms.TextBox()
        Me.lblSpellWord = New System.Windows.Forms.Label()
        CType(Me.SpellingWordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkipVocabWordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLetters.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstWords
        '
        Me.lstWords.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SpellingWordsBindingSource, "Words", True))
        Me.lstWords.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.ItemHeight = 19
        Me.lstWords.Location = New System.Drawing.Point(461, 226)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(152, 403)
        Me.lstWords.TabIndex = 2
        '
        'SpellingWordsBindingSource
        '
        Me.SpellingWordsBindingSource.DataMember = "SpellingWords"
        Me.SpellingWordsBindingSource.DataSource = Me.SkipVocabWordsDataSet
        '
        'SkipVocabWordsDataSet
        '
        Me.SkipVocabWordsDataSet.DataSetName = "SkipVocabWordsDataSet"
        Me.SkipVocabWordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtInputLetter
        '
        Me.txtInputLetter.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputLetter.Location = New System.Drawing.Point(115, 66)
        Me.txtInputLetter.Name = "txtInputLetter"
        Me.txtInputLetter.Size = New System.Drawing.Size(100, 26)
        Me.txtInputLetter.TabIndex = 3
        '
        'SpellingWordsTableAdapter
        '
        Me.SpellingWordsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SpellingWordsTableAdapter = Me.SpellingWordsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Hangman.SkipVocabWordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'grpLetters
        '
        Me.grpLetters.Controls.Add(Me.lblZ)
        Me.grpLetters.Controls.Add(Me.lblY)
        Me.grpLetters.Controls.Add(Me.lblX)
        Me.grpLetters.Controls.Add(Me.lblW)
        Me.grpLetters.Controls.Add(Me.lblV)
        Me.grpLetters.Controls.Add(Me.lblU)
        Me.grpLetters.Controls.Add(Me.lblT)
        Me.grpLetters.Controls.Add(Me.lblS)
        Me.grpLetters.Controls.Add(Me.lblR)
        Me.grpLetters.Controls.Add(Me.lblQ)
        Me.grpLetters.Controls.Add(Me.lblP)
        Me.grpLetters.Controls.Add(Me.lblO)
        Me.grpLetters.Controls.Add(Me.lblN)
        Me.grpLetters.Controls.Add(Me.lblM)
        Me.grpLetters.Controls.Add(Me.lblL)
        Me.grpLetters.Controls.Add(Me.lblK)
        Me.grpLetters.Controls.Add(Me.lblj)
        Me.grpLetters.Controls.Add(Me.lblI)
        Me.grpLetters.Controls.Add(Me.lblH)
        Me.grpLetters.Controls.Add(Me.lblG)
        Me.grpLetters.Controls.Add(Me.lblF)
        Me.grpLetters.Controls.Add(Me.lblE)
        Me.grpLetters.Controls.Add(Me.lblD)
        Me.grpLetters.Controls.Add(Me.lblC)
        Me.grpLetters.Controls.Add(Me.lblB)
        Me.grpLetters.Controls.Add(Me.lblA)
        Me.grpLetters.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLetters.Location = New System.Drawing.Point(12, 109)
        Me.grpLetters.Name = "grpLetters"
        Me.grpLetters.Size = New System.Drawing.Size(571, 72)
        Me.grpLetters.TabIndex = 4
        Me.grpLetters.TabStop = False
        Me.grpLetters.Text = "Letters:"
        '
        'lblZ
        '
        Me.lblZ.AutoSize = True
        Me.lblZ.Location = New System.Drawing.Point(533, 42)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.Size = New System.Drawing.Size(18, 19)
        Me.lblZ.TabIndex = 25
        Me.lblZ.Text = "Z"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(490, 42)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(20, 19)
        Me.lblY.TabIndex = 24
        Me.lblY.Text = "Y"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(445, 42)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(20, 19)
        Me.lblX.TabIndex = 23
        Me.lblX.Text = "X"
        '
        'lblW
        '
        Me.lblW.AutoSize = True
        Me.lblW.Location = New System.Drawing.Point(404, 42)
        Me.lblW.Name = "lblW"
        Me.lblW.Size = New System.Drawing.Size(24, 19)
        Me.lblW.TabIndex = 22
        Me.lblW.Text = "W"
        '
        'lblV
        '
        Me.lblV.AutoSize = True
        Me.lblV.Location = New System.Drawing.Point(365, 42)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(20, 19)
        Me.lblV.TabIndex = 21
        Me.lblV.Text = "V"
        '
        'lblU
        '
        Me.lblU.AutoSize = True
        Me.lblU.Location = New System.Drawing.Point(323, 42)
        Me.lblU.Name = "lblU"
        Me.lblU.Size = New System.Drawing.Size(20, 19)
        Me.lblU.TabIndex = 20
        Me.lblU.Text = "U"
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.Location = New System.Drawing.Point(277, 42)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(18, 19)
        Me.lblT.TabIndex = 19
        Me.lblT.Text = "T"
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.Location = New System.Drawing.Point(230, 42)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(18, 19)
        Me.lblS.TabIndex = 18
        Me.lblS.Text = "S"
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Location = New System.Drawing.Point(187, 42)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(19, 19)
        Me.lblR.TabIndex = 17
        Me.lblR.Text = "R"
        '
        'lblQ
        '
        Me.lblQ.AutoSize = True
        Me.lblQ.Location = New System.Drawing.Point(142, 42)
        Me.lblQ.Name = "lblQ"
        Me.lblQ.Size = New System.Drawing.Size(21, 19)
        Me.lblQ.TabIndex = 16
        Me.lblQ.Text = "Q"
        '
        'lblP
        '
        Me.lblP.AutoSize = True
        Me.lblP.Location = New System.Drawing.Point(100, 42)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(18, 19)
        Me.lblP.TabIndex = 15
        Me.lblP.Text = "P"
        '
        'lblO
        '
        Me.lblO.AutoSize = True
        Me.lblO.Location = New System.Drawing.Point(55, 42)
        Me.lblO.Name = "lblO"
        Me.lblO.Size = New System.Drawing.Size(21, 19)
        Me.lblO.TabIndex = 14
        Me.lblO.Text = "O"
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(10, 42)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(21, 19)
        Me.lblN.TabIndex = 13
        Me.lblN.Text = "N"
        '
        'lblM
        '
        Me.lblM.AutoSize = True
        Me.lblM.Location = New System.Drawing.Point(531, 22)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(23, 19)
        Me.lblM.TabIndex = 12
        Me.lblM.Text = "M"
        '
        'lblL
        '
        Me.lblL.AutoSize = True
        Me.lblL.Location = New System.Drawing.Point(491, 21)
        Me.lblL.Name = "lblL"
        Me.lblL.Size = New System.Drawing.Size(18, 19)
        Me.lblL.TabIndex = 11
        Me.lblL.Text = "L"
        '
        'lblK
        '
        Me.lblK.AutoSize = True
        Me.lblK.Location = New System.Drawing.Point(445, 21)
        Me.lblK.Name = "lblK"
        Me.lblK.Size = New System.Drawing.Size(21, 19)
        Me.lblK.TabIndex = 10
        Me.lblK.Text = "K"
        '
        'lblj
        '
        Me.lblj.AutoSize = True
        Me.lblj.Location = New System.Drawing.Point(409, 23)
        Me.lblj.Name = "lblj"
        Me.lblj.Size = New System.Drawing.Size(15, 19)
        Me.lblj.TabIndex = 9
        Me.lblj.Text = "J"
        '
        'lblI
        '
        Me.lblI.AutoSize = True
        Me.lblI.Location = New System.Drawing.Point(368, 21)
        Me.lblI.Name = "lblI"
        Me.lblI.Size = New System.Drawing.Size(14, 19)
        Me.lblI.TabIndex = 8
        Me.lblI.Text = "I"
        '
        'lblH
        '
        Me.lblH.AutoSize = True
        Me.lblH.Location = New System.Drawing.Point(323, 22)
        Me.lblH.Name = "lblH"
        Me.lblH.Size = New System.Drawing.Size(20, 19)
        Me.lblH.TabIndex = 7
        Me.lblH.Text = "H"
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.Location = New System.Drawing.Point(276, 23)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(20, 19)
        Me.lblG.TabIndex = 6
        Me.lblG.Text = "G"
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Location = New System.Drawing.Point(230, 23)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(18, 19)
        Me.lblF.TabIndex = 5
        Me.lblF.Text = "F"
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.Location = New System.Drawing.Point(187, 23)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(18, 19)
        Me.lblE.TabIndex = 4
        Me.lblE.Text = "E"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Location = New System.Drawing.Point(142, 23)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(20, 19)
        Me.lblD.TabIndex = 3
        Me.lblD.Text = "D"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Location = New System.Drawing.Point(99, 22)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(20, 19)
        Me.lblC.TabIndex = 2
        Me.lblC.Text = "C"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(56, 23)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(19, 19)
        Me.lblB.TabIndex = 1
        Me.lblB.Text = "B"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(10, 23)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(20, 19)
        Me.lblA.TabIndex = 0
        Me.lblA.Text = "A"
        '
        'lblSecretWord
        '
        Me.lblSecretWord.AutoSize = True
        Me.lblSecretWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretWord.Location = New System.Drawing.Point(371, 61)
        Me.lblSecretWord.Name = "lblSecretWord"
        Me.lblSecretWord.Size = New System.Drawing.Size(212, 31)
        Me.lblSecretWord.TabIndex = 5
        Me.lblSecretWord.Text = "XXXXXXXXXXX"
        '
        'lstLettersUsed
        '
        Me.lstLettersUsed.FormattingEnabled = True
        Me.lstLettersUsed.Location = New System.Drawing.Point(420, 226)
        Me.lstLettersUsed.Name = "lstLettersUsed"
        Me.lstLettersUsed.Size = New System.Drawing.Size(39, 381)
        Me.lstLettersUsed.TabIndex = 6
        '
        'lblWords
        '
        Me.lblWords.AutoSize = True
        Me.lblWords.Location = New System.Drawing.Point(478, 207)
        Me.lblWords.Name = "lblWords"
        Me.lblWords.Size = New System.Drawing.Size(41, 13)
        Me.lblWords.TabIndex = 7
        Me.lblWords.Text = "Words:"
        '
        'lblLettersUsed
        '
        Me.lblLettersUsed.AutoSize = True
        Me.lblLettersUsed.Location = New System.Drawing.Point(420, 197)
        Me.lblLettersUsed.Name = "lblLettersUsed"
        Me.lblLettersUsed.Size = New System.Drawing.Size(39, 26)
        Me.lblLettersUsed.TabIndex = 8
        Me.lblLettersUsed.Text = "Letters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Used:"
        '
        'txtSpellWord
        '
        Me.txtSpellWord.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpellWord.Location = New System.Drawing.Point(115, 66)
        Me.txtSpellWord.Name = "txtSpellWord"
        Me.txtSpellWord.Size = New System.Drawing.Size(100, 26)
        Me.txtSpellWord.TabIndex = 9
        Me.txtSpellWord.Text = "Spell The Word"
        '
        'lblSpellWord
        '
        Me.lblSpellWord.AutoSize = True
        Me.lblSpellWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpellWord.Location = New System.Drawing.Point(66, 9)
        Me.lblSpellWord.Name = "lblSpellWord"
        Me.lblSpellWord.Size = New System.Drawing.Size(199, 31)
        Me.lblSpellWord.TabIndex = 10
        Me.lblSpellWord.Text = "Spell The Word"
        '
        'frmHangman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(652, 659)
        Me.Controls.Add(Me.lblSpellWord)
        Me.Controls.Add(Me.txtSpellWord)
        Me.Controls.Add(Me.lblLettersUsed)
        Me.Controls.Add(Me.lblWords)
        Me.Controls.Add(Me.lstLettersUsed)
        Me.Controls.Add(Me.lblSecretWord)
        Me.Controls.Add(Me.grpLetters)
        Me.Controls.Add(Me.txtInputLetter)
        Me.Controls.Add(Me.lstWords)
        Me.Name = "frmHangman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hangman Spelling Words"
        CType(Me.SpellingWordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkipVocabWordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLetters.ResumeLayout(False)
        Me.grpLetters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SkipVocabWordsDataSet As SkipVocabWordsDataSet
    Friend WithEvents SpellingWordsBindingSource As BindingSource
    Friend WithEvents SpellingWordsTableAdapter As SkipVocabWordsDataSetTableAdapters.SpellingWordsTableAdapter
    Friend WithEvents TableAdapterManager As SkipVocabWordsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lstWords As ListBox
    Friend WithEvents txtInputLetter As TextBox
    Friend WithEvents grpLetters As GroupBox
    Friend WithEvents lblZ As Label
    Friend WithEvents lblY As Label
    Friend WithEvents lblX As Label
    Friend WithEvents lblW As Label
    Friend WithEvents lblV As Label
    Friend WithEvents lblU As Label
    Friend WithEvents lblT As Label
    Friend WithEvents lblS As Label
    Friend WithEvents lblR As Label
    Friend WithEvents lblQ As Label
    Friend WithEvents lblP As Label
    Friend WithEvents lblO As Label
    Friend WithEvents lblN As Label
    Friend WithEvents lblM As Label
    Friend WithEvents lblL As Label
    Friend WithEvents lblK As Label
    Friend WithEvents lblj As Label
    Friend WithEvents lblI As Label
    Friend WithEvents lblH As Label
    Friend WithEvents lblG As Label
    Friend WithEvents lblF As Label
    Friend WithEvents lblE As Label
    Friend WithEvents lblD As Label
    Friend WithEvents lblC As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblSecretWord As Label
    Friend WithEvents lstLettersUsed As ListBox
    Friend WithEvents lblWords As Label
    Friend WithEvents lblLettersUsed As Label
    Friend WithEvents txtSpellWord As TextBox
    Friend WithEvents lblSpellWord As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVocabWords
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
        Me.VocabWordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkipVocabWordsDataSet = New Elijah_Vocab_Words.SkipVocabWordsDataSet()
        Me.VocabWordsTableAdapter = New Elijah_Vocab_Words.SkipVocabWordsDataSetTableAdapters.VocabWordsTableAdapter()
        Me.TableAdapterManager = New Elijah_Vocab_Words.SkipVocabWordsDataSetTableAdapters.TableAdapterManager()
        Me.lstWords = New System.Windows.Forms.ListBox()
        Me.lstDefinitions = New System.Windows.Forms.ListBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblRandomWord = New System.Windows.Forms.Label()
        Me.lblDefinition = New System.Windows.Forms.Label()
        Me.lblRandomDefinition = New System.Windows.Forms.Label()
        Me.txtEnterWord = New System.Windows.Forms.TextBox()
        Me.lblEnterWord = New System.Windows.Forms.Label()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblDefinitions = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblNeedWord = New System.Windows.Forms.Label()
        CType(Me.VocabWordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkipVocabWordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VocabWordsBindingSource
        '
        Me.VocabWordsBindingSource.DataMember = "VocabWords"
        Me.VocabWordsBindingSource.DataSource = Me.SkipVocabWordsDataSet
        '
        'SkipVocabWordsDataSet
        '
        Me.SkipVocabWordsDataSet.DataSetName = "SkipVocabWordsDataSet"
        Me.SkipVocabWordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VocabWordsTableAdapter
        '
        Me.VocabWordsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Elijah_Vocab_Words.SkipVocabWordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VocabWordsTableAdapter = Me.VocabWordsTableAdapter
        '
        'lstWords
        '
        Me.lstWords.BackColor = System.Drawing.Color.DarkKhaki
        Me.lstWords.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VocabWordsBindingSource, "Words", True))
        Me.lstWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.ItemHeight = 20
        Me.lstWords.Location = New System.Drawing.Point(26, 114)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstWords.Size = New System.Drawing.Size(145, 484)
        Me.lstWords.TabIndex = 5
        Me.lstWords.Visible = False
        '
        'lstDefinitions
        '
        Me.lstDefinitions.BackColor = System.Drawing.Color.DarkKhaki
        Me.lstDefinitions.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VocabWordsBindingSource, "Definitions", True))
        Me.lstDefinitions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDefinitions.FormattingEnabled = True
        Me.lstDefinitions.HorizontalScrollbar = True
        Me.lstDefinitions.ItemHeight = 20
        Me.lstDefinitions.Location = New System.Drawing.Point(287, 97)
        Me.lstDefinitions.Name = "lstDefinitions"
        Me.lstDefinitions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstDefinitions.ScrollAlwaysVisible = True
        Me.lstDefinitions.Size = New System.Drawing.Size(1009, 604)
        Me.lstDefinitions.TabIndex = 6
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(353, 32)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(373, 31)
        Me.lblHeading.TabIndex = 7
        Me.lblHeading.Text = "Match a Word With a Definition."
        '
        'lblRandomWord
        '
        Me.lblRandomWord.AutoSize = True
        Me.lblRandomWord.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblRandomWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandomWord.Location = New System.Drawing.Point(22, 134)
        Me.lblRandomWord.Name = "lblRandomWord"
        Me.lblRandomWord.Size = New System.Drawing.Size(141, 20)
        Me.lblRandomWord.TabIndex = 8
        Me.lblRandomWord.Text = "XXXXXXXXXXXX"
        '
        'lblDefinition
        '
        Me.lblDefinition.AutoSize = True
        Me.lblDefinition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefinition.Location = New System.Drawing.Point(518, 178)
        Me.lblDefinition.Name = "lblDefinition"
        Me.lblDefinition.Size = New System.Drawing.Size(80, 20)
        Me.lblDefinition.TabIndex = 9
        Me.lblDefinition.Text = "Definition:"
        Me.lblDefinition.Visible = False
        '
        'lblRandomDefinition
        '
        Me.lblRandomDefinition.AutoSize = True
        Me.lblRandomDefinition.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblRandomDefinition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandomDefinition.Location = New System.Drawing.Point(604, 178)
        Me.lblRandomDefinition.Name = "lblRandomDefinition"
        Me.lblRandomDefinition.Size = New System.Drawing.Size(273, 20)
        Me.lblRandomDefinition.TabIndex = 10
        Me.lblRandomDefinition.Text = "XXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblRandomDefinition.Visible = False
        '
        'txtEnterWord
        '
        Me.txtEnterWord.BackColor = System.Drawing.Color.DarkKhaki
        Me.txtEnterWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterWord.Location = New System.Drawing.Point(522, 120)
        Me.txtEnterWord.Name = "txtEnterWord"
        Me.txtEnterWord.Size = New System.Drawing.Size(185, 26)
        Me.txtEnterWord.TabIndex = 11
        Me.txtEnterWord.Visible = False
        '
        'lblEnterWord
        '
        Me.lblEnterWord.AutoSize = True
        Me.lblEnterWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterWord.Location = New System.Drawing.Point(518, 97)
        Me.lblEnterWord.Name = "lblEnterWord"
        Me.lblEnterWord.Size = New System.Drawing.Size(94, 20)
        Me.lblEnterWord.TabIndex = 12
        Me.lblEnterWord.Text = "Enter Word:"
        Me.lblEnterWord.Visible = False
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord.Location = New System.Drawing.Point(46, 114)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(51, 20)
        Me.lblWord.TabIndex = 13
        Me.lblWord.Text = "Word:"
        '
        'lblDefinitions
        '
        Me.lblDefinitions.AutoSize = True
        Me.lblDefinitions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefinitions.Location = New System.Drawing.Point(786, 74)
        Me.lblDefinitions.Name = "lblDefinitions"
        Me.lblDefinitions.Size = New System.Drawing.Size(84, 20)
        Me.lblDefinitions.TabIndex = 14
        Me.lblDefinitions.Text = "Definitions"
        '
        'btnSubmit
        '
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.Location = New System.Drawing.Point(522, 218)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(185, 23)
        Me.btnSubmit.TabIndex = 15
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        Me.btnSubmit.Visible = False
        '
        'lblNeedWord
        '
        Me.lblNeedWord.AutoSize = True
        Me.lblNeedWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblNeedWord.Location = New System.Drawing.Point(517, 149)
        Me.lblNeedWord.Name = "lblNeedWord"
        Me.lblNeedWord.Size = New System.Drawing.Size(184, 25)
        Me.lblNeedWord.TabIndex = 16
        Me.lblNeedWord.Text = "Please enter a word"
        Me.lblNeedWord.Visible = False
        '
        'frmVocabWords
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(1308, 749)
        Me.Controls.Add(Me.lblNeedWord)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblDefinitions)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.lblEnterWord)
        Me.Controls.Add(Me.txtEnterWord)
        Me.Controls.Add(Me.lblRandomDefinition)
        Me.Controls.Add(Me.lblDefinition)
        Me.Controls.Add(Me.lblRandomWord)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lstDefinitions)
        Me.Controls.Add(Me.lstWords)
        Me.Name = "frmVocabWords"
        Me.Text = "Vobulary Test"
        CType(Me.VocabWordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkipVocabWordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SkipVocabWordsDataSet As SkipVocabWordsDataSet
    Friend WithEvents VocabWordsBindingSource As BindingSource
    Friend WithEvents VocabWordsTableAdapter As SkipVocabWordsDataSetTableAdapters.VocabWordsTableAdapter
    Friend WithEvents TableAdapterManager As SkipVocabWordsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lstWords As ListBox
    Friend WithEvents lstDefinitions As ListBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblRandomWord As Label
    Friend WithEvents lblDefinition As Label
    Friend WithEvents lblRandomDefinition As Label
    Friend WithEvents txtEnterWord As TextBox
    Friend WithEvents lblEnterWord As Label
    Friend WithEvents lblWord As Label
    Friend WithEvents lblDefinitions As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblNeedWord As Label
End Class

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
        Me.SkipVocabWordsDataSet = New Elijah_Scores.SkipVocabWordsDataSet()
        Me.VocabWordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VocabWordsTableAdapter = New Elijah_Scores.SkipVocabWordsDataSetTableAdapters.VocabWordsTableAdapter()
        Me.TableAdapterManager = New Elijah_Scores.SkipVocabWordsDataSetTableAdapters.TableAdapterManager()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblDefinitions = New System.Windows.Forms.Label()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblEnterWord = New System.Windows.Forms.Label()
        Me.txtEnterWord = New System.Windows.Forms.TextBox()
        Me.lblRandomDefinition = New System.Windows.Forms.Label()
        Me.lblDefinition = New System.Windows.Forms.Label()
        Me.lblRandomWord = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lstDefinitions = New System.Windows.Forms.ListBox()
        Me.lstWords = New System.Windows.Forms.ListBox()
        Me.lblWordsLeft = New System.Windows.Forms.Label()
        CType(Me.SkipVocabWordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VocabWordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SkipVocabWordsDataSet
        '
        Me.SkipVocabWordsDataSet.DataSetName = "SkipVocabWordsDataSet"
        Me.SkipVocabWordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VocabWordsBindingSource
        '
        Me.VocabWordsBindingSource.DataMember = "VocabWords"
        Me.VocabWordsBindingSource.DataSource = Me.SkipVocabWordsDataSet
        '
        'VocabWordsTableAdapter
        '
        Me.VocabWordsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SpellingWordsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Elijah_Scores.SkipVocabWordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VocabWordsTableAdapter = Me.VocabWordsTableAdapter
        '
        'btnSubmit
        '
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.Location = New System.Drawing.Point(395, 164)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(197, 23)
        Me.btnSubmit.TabIndex = 26
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        Me.btnSubmit.Visible = False
        '
        'lblDefinitions
        '
        Me.lblDefinitions.AutoSize = True
        Me.lblDefinitions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefinitions.Location = New System.Drawing.Point(374, 76)
        Me.lblDefinitions.Name = "lblDefinitions"
        Me.lblDefinitions.Size = New System.Drawing.Size(84, 20)
        Me.lblDefinitions.TabIndex = 25
        Me.lblDefinitions.Text = "Definitions"
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord.Location = New System.Drawing.Point(82, 115)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(51, 20)
        Me.lblWord.TabIndex = 24
        Me.lblWord.Text = "Word:"
        '
        'lblEnterWord
        '
        Me.lblEnterWord.AutoSize = True
        Me.lblEnterWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterWord.Location = New System.Drawing.Point(395, 109)
        Me.lblEnterWord.Name = "lblEnterWord"
        Me.lblEnterWord.Size = New System.Drawing.Size(94, 20)
        Me.lblEnterWord.TabIndex = 23
        Me.lblEnterWord.Text = "Enter Word:"
        Me.lblEnterWord.Visible = False
        '
        'txtEnterWord
        '
        Me.txtEnterWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterWord.Location = New System.Drawing.Point(395, 132)
        Me.txtEnterWord.Name = "txtEnterWord"
        Me.txtEnterWord.Size = New System.Drawing.Size(185, 26)
        Me.txtEnterWord.TabIndex = 22
        Me.txtEnterWord.Visible = False
        '
        'lblRandomDefinition
        '
        Me.lblRandomDefinition.AutoSize = True
        Me.lblRandomDefinition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandomDefinition.Location = New System.Drawing.Point(39, 135)
        Me.lblRandomDefinition.Name = "lblRandomDefinition"
        Me.lblRandomDefinition.Size = New System.Drawing.Size(273, 20)
        Me.lblRandomDefinition.TabIndex = 21
        Me.lblRandomDefinition.Text = "XXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblRandomDefinition.Visible = False
        '
        'lblDefinition
        '
        Me.lblDefinition.AutoSize = True
        Me.lblDefinition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefinition.Location = New System.Drawing.Point(58, 115)
        Me.lblDefinition.Name = "lblDefinition"
        Me.lblDefinition.Size = New System.Drawing.Size(80, 20)
        Me.lblDefinition.TabIndex = 20
        Me.lblDefinition.Text = "Definition:"
        Me.lblDefinition.Visible = False
        '
        'lblRandomWord
        '
        Me.lblRandomWord.AutoSize = True
        Me.lblRandomWord.BackColor = System.Drawing.Color.White
        Me.lblRandomWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandomWord.Location = New System.Drawing.Point(58, 135)
        Me.lblRandomWord.Name = "lblRandomWord"
        Me.lblRandomWord.Size = New System.Drawing.Size(141, 20)
        Me.lblRandomWord.TabIndex = 19
        Me.lblRandomWord.Text = "XXXXXXXXXXXX"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(133, 30)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(373, 31)
        Me.lblHeading.TabIndex = 18
        Me.lblHeading.Text = "Match a Word With a Definition."
        '
        'lstDefinitions
        '
        Me.lstDefinitions.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VocabWordsBindingSource, "Definitions", True))
        Me.lstDefinitions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDefinitions.FormattingEnabled = True
        Me.lstDefinitions.ItemHeight = 20
        Me.lstDefinitions.Location = New System.Drawing.Point(238, 109)
        Me.lstDefinitions.Name = "lstDefinitions"
        Me.lstDefinitions.Size = New System.Drawing.Size(569, 284)
        Me.lstDefinitions.TabIndex = 17
        '
        'lstWords
        '
        Me.lstWords.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VocabWordsBindingSource, "Words", True))
        Me.lstWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.ItemHeight = 20
        Me.lstWords.Location = New System.Drawing.Point(62, 174)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(99, 224)
        Me.lstWords.TabIndex = 16
        Me.lstWords.Visible = False
        '
        'lblWordsLeft
        '
        Me.lblWordsLeft.AutoSize = True
        Me.lblWordsLeft.Location = New System.Drawing.Point(353, 202)
        Me.lblWordsLeft.Name = "lblWordsLeft"
        Me.lblWordsLeft.Size = New System.Drawing.Size(254, 19)
        Me.lblWordsLeft.TabIndex = 27
        Me.lblWordsLeft.Text = "You have XX words left to choose from."
        '
        'frmVocabWords
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(898, 429)
        Me.Controls.Add(Me.lblWordsLeft)
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
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmVocabWords"
        Me.Text = "VocabWords"
        CType(Me.SkipVocabWordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VocabWordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SkipVocabWordsDataSet As SkipVocabWordsDataSet
    Friend WithEvents VocabWordsBindingSource As BindingSource
    Friend WithEvents VocabWordsTableAdapter As SkipVocabWordsDataSetTableAdapters.VocabWordsTableAdapter
    Friend WithEvents TableAdapterManager As SkipVocabWordsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblDefinitions As Label
    Friend WithEvents lblWord As Label
    Friend WithEvents lblEnterWord As Label
    Friend WithEvents txtEnterWord As TextBox
    Friend WithEvents lblRandomDefinition As Label
    Friend WithEvents lblDefinition As Label
    Friend WithEvents lblRandomWord As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents lstDefinitions As ListBox
    Friend WithEvents lstWords As ListBox
    Friend WithEvents lblWordsLeft As Label
End Class

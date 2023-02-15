Option Strict On

Public Class frmVocabWords
    Dim _strWords As New ArrayList()
    Dim _strDefinitions As New ArrayList()
    Dim _intRandom As Integer



    Private Sub lstDefinitions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDefinitions.SelectedIndexChanged


        If lstDefinitions.SelectedIndex >= 0 Then
            If _intRandom = lstDefinitions.SelectedIndex Then
                'Correct Answer
                MsgBox("Correct!!!", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Great Job")
                lstDefinitions.Items.RemoveAt(_intRandom) ' Deletes definition on correct answer
                _strDefinitions.RemoveAt(_intRandom)
                _strWords.RemoveAt(_intRandom)
                If _strWords.Count = 0 Then
                    ' No elements left in array _strWords
                    MsgBox("Now Try This", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Excellent Work!!!!")
                    ShowRandomDefinition()
                    PopulateListBox()
                    RandomWordLabel()
                Else
                    ' New Random Word
                    RandomWordLabel()
                End If
            Else
                MsgBox("Incorrect Answer", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Incorrect")
            End If
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Enter word from definition activity
        Dim strWordEntered As String
        Dim strUCaseWord As String

        ' Change words to uppercase
        strWordEntered = txtEnterWord.Text
        strWordEntered = UCase(strWordEntered)
        strUCaseWord = CType(_strWords(_intRandom), String)
        strUCaseWord = UCase(strUCaseWord)

        If strWordEntered = strUCaseWord Then
            ' Correct Answer
            MsgBox("Correct!!!", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Great Job")
            _strDefinitions.RemoveAt(_intRandom)
            _strWords.RemoveAt(_intRandom)
            lblWordsLeft.Text = "You have " & _strWords.Count & " words to choose."
            If _strDefinitions.Count = 0 Then
                ' All words used
                MsgBox("Vocab Done", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Excellent Work!!!!")
                frmDailyActivity._blnVocabDone = True
                Close()
            Else
                ' All words not used yet
                RandomWordLabel()
                txtEnterWord.Focus()
            End If
        Else
            ' Incorrect answer
            MsgBox("Incorrect, Please Try Again" & vbNewLine & "Look at the word list.", MsgBoxStyle.Critical _
                   Or MsgBoxStyle.OkOnly, "Incorrect Answer")
        End If
        txtEnterWord.Text = ""
    End Sub

    Private Sub RandomWordLabel()
        Dim Generator As System.Random = New System.Random()

        ' Random Word and Definition Generator
        _intRandom = Generator.Next(0, _strWords.Count)
        If _strWords.Count > 0 Then
            lblRandomWord.Text = CType(_strWords(_intRandom), String)
            lblRandomDefinition.Text = CType(_strDefinitions(_intRandom), String)
            lblWordsLeft.Text = "You have " & _strWords.Count & " words to choose."
        Else
            MsgBox("No words in list.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Vocab Not Loaded")
            frmDailyActivity._blnVocabDone = True
            Close()
        End If
    End Sub

    Private Sub PopulateListBox()
        ' Reads database and populates listbox and word array
        Dim strSQL As String = "Select * From VocabWords"

        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" &
            "Data Source=c:\EDATimes\SkipVocabWords.accdb"
        Dim odaVocabWords As New OleDb.OleDbDataAdapter(strSQL, strPath)
        Dim datWords As New DataSet
        Dim intCount As Integer

        'Clear listboxes and array
        lstWords.Items.Clear()
        lstDefinitions.Items.Clear()
        _strWords.Clear()
        _strDefinitions.Clear()

        odaVocabWords.Fill(datWords)
        odaVocabWords.Dispose()

        For intCount = 0 To datWords.Tables(0).Rows.Count - 1
            Dim strWordList As String = (datWords.Tables(0).Rows(intCount)(1).ToString)
            Dim strDefList As String = (datWords.Tables(0).Rows(intCount)(2).ToString)
            ' Add items from database to array and listbox
            _strWords.Add(strWordList)
            _strDefinitions.Add(strDefList)
            lstWords.Items.Add(strWordList)
            lstDefinitions.Items.Add(strDefList)
        Next

    End Sub

    Private Sub ShowRandomWord()
        ' Show matching from random word
        lblRandomWord.Visible = True
        lstDefinitions.Visible = True
        lblWord.Visible = True
        lblDefinitions.Visible = True
        lblDefinition.Visible = False
        lblEnterWord.Visible = False
        lblRandomDefinition.Visible = False
        lstWords.Visible = False
        lblWordsLeft.Visible = False
        txtEnterWord.Visible = False
        btnSubmit.Visible = False
        btnSubmit.Enabled = False

    End Sub

    Private Sub ShowRandomDefinition()
        ' Show random definition and word list
        lblDefinition.Visible = True
        lblEnterWord.Visible = True
        lblRandomDefinition.Visible = True
        lstWords.Visible = True
        txtEnterWord.Visible = True
        lblWordsLeft.Visible = True
        lblRandomWord.Visible = False
        lstDefinitions.Visible = False
        lblWord.Visible = False
        lblDefinitions.Visible = False
        btnSubmit.Visible = True
        btnSubmit.Enabled = True
    End Sub

    Private Sub frmVocabWords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate definitions and generate word label
        PopulateListBox()
        RandomWordLabel()
        ShowRandomWord()
    End Sub


End Class
Option Strict On

Public Class frmVocabWords
    Dim _strWords As New ArrayList()
    Dim _strDefinitions As New ArrayList()
    Dim _intRandom As Integer
    Dim _strComplete As String
    Dim _intTotalWords As Integer
    Dim _intTotalMatch As Integer
    Dim _intTotalDef As Integer
    Dim _intTotalMultiChoice As Integer
    Dim _strWordWrongGuesses As String
    Dim _arrMatchingWordList As New ArrayList()
    Dim _arrMatchingDefinitionList As New ArrayList()
    Dim _arrDefinitionWordList As New ArrayList()
    Dim _arrDefinitionDefinitionList As New ArrayList()
    Dim _arrMultipleChoicWordList As New ArrayList()
    Dim _arrMultipleChoiceDefinitionList As New ArrayList()
    Dim _intWrongGuess As Integer
    Dim _intWrongTotalGuesses As Integer


    Private Sub lstDefinitions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDefinitions.SelectedIndexChanged

        If lstDefinitions.SelectedIndex >= 0 Then
            If _intRandom = lstDefinitions.SelectedIndex Then
                'Correct Answer
                If _intWrongGuess > 0 Then
                    'Collect Information On Wrong Guesses
                    _strWordWrongGuesses += CType(_arrMatchingWordList(_intRandom), String) + " definition was guessed wrong " +
                        CType(_intWrongGuess, String) + " times" + vbNewLine
                End If

                _intWrongGuess = 0
                lstDefinitions.Items.RemoveAt(_intRandom) ' Deletes definition on correct answer
                _arrMatchingDefinitionList.RemoveAt(_intRandom)
                _arrMatchingWordList.RemoveAt(_intRandom)
                If _arrMatchingWordList.Count = 0 Then
                    ' No elements left in array _strWords
                    _strComplete = "Incorrect Guesses = " +
                        CType(_intWrongTotalGuesses, String) + vbTab + " Completed Matching " + CType(_intTotalMatch, String) + " Total Matching Words" + vbNewLine +
                        _strWordWrongGuesses
                    MsgBox(_strComplete + vbNewLine + "Now Try This", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Excellent Work!!!!")
                    WriteToFile()
                    ShowRandomDefinition() 'Shows GUI elements
                    ListSetup(_arrDefinitionWordList, _arrDefinitionDefinitionList)
                    RandomWordLabel(_arrDefinitionWordList, _arrDefinitionDefinitionList)
                    _intWrongTotalGuesses = 0
                    _intWrongGuess = 0
                    _strWordWrongGuesses = ""
                Else
                    ' New Random Word
                    RandomWordLabel(_arrMatchingWordList, _arrMatchingDefinitionList)
                End If
            Else
                'Incorrect Answer
                MsgBox("Incorrect answer for " + CType(_arrMatchingWordList(_intRandom), String), MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Incorrect")
                _intWrongTotalGuesses = _intWrongTotalGuesses + 1
                _intWrongGuess += 1
            End If
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Enter word from definition activity
        Dim strWordEntered As String
        Dim strUCaseWord As String

        ' Change words to uppercase
        strWordEntered = txtEnterWord.Text.ToLower
        strWordEntered = UCase(strWordEntered)
        strUCaseWord = CType(_arrDefinitionWordList(_intRandom), String)
        strUCaseWord = UCase(strUCaseWord)
        If Not strWordEntered = "" Then
            'Check if string is empty
            lblNeedWord.Visible = False
            If strWordEntered = strUCaseWord Then
                ' Correct Answer
                If _intWrongGuess > 0 Then
                    'Collect Information On Wrong Guesses
                    _strWordWrongGuesses += CType(_arrDefinitionWordList(_intRandom), String) + " was guessed wrong " +
                            CType(_intWrongGuess, String) + " times" + vbNewLine
                End If
                _intWrongGuess = 0
                _arrDefinitionDefinitionList.RemoveAt(_intRandom)
                _arrDefinitionWordList.RemoveAt(_intRandom)
                If _arrDefinitionDefinitionList.Count = 0 Then
                    ' All words used
                    _strComplete = "Incorrect Guesses = " +
                            CType(_intWrongTotalGuesses, String) + vbTab + " Completed Definitions " + CType(_intTotalDef, String) + " Total Definition Words" +
                            vbNewLine
                    MsgBox(_strComplete + vbNewLine + "All Done", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Excellent Work!!!!")
                    _strComplete += _strWordWrongGuesses
                    WriteToFile()
                    Close()
                    _intWrongTotalGuesses = 0
                    _strWordWrongGuesses = ""
                Else
                    ' All words not used yet
                    RandomWordLabel(_arrDefinitionWordList, _arrDefinitionDefinitionList)
                    txtEnterWord.Focus()
                End If
            Else
                ' Incorrect answer
                MsgBox("Incorrect, Please Try Again" & vbNewLine & "Look at the word list.", MsgBoxStyle.Critical _
                       Or MsgBoxStyle.OkOnly, "Incorrect Answer")
                _intWrongTotalGuesses = _intWrongTotalGuesses + 1
                _intWrongGuess += 1
            End If
        Else
            ' Show label to ask for word
            lblNeedWord.Visible = True
        End If
        txtEnterWord.Text = ""
    End Sub

    Private Sub RandomWordLabel(Words As ArrayList, Definitions As ArrayList)
        Dim Generator As System.Random = New System.Random()

        ' Random Word and Definition Generator
        _intRandom = Generator.Next(0, Words.Count())
        lblRandomWord.Text = CType(Words(_intRandom), String)
        lblRandomDefinition.Text = CType(Definitions(_intRandom), String)
    End Sub

    Private Sub ListSetup(words As ArrayList, definitions As ArrayList)
        lstDefinitions.Items.Clear()
        lstWords.Items.Clear()
        For i As Integer = 0 To words.Count - 1
            lstDefinitions.Items.Add(definitions(i))
            lstWords.Items.Add(words(i))
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
        lblRandomWord.Visible = False
        lstDefinitions.Visible = False
        lblWord.Visible = False
        lblDefinitions.Visible = False
        btnSubmit.Visible = True
        btnSubmit.Enabled = True
    End Sub

    Private Sub PopulateLists()
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

        odaVocabWords.Fill(datWords)
        odaVocabWords.Dispose()

        For intCount = 0 To datWords.Tables(0).Rows.Count - 1
            Dim strWordList As String = (datWords.Tables(0).Rows(intCount)(1).ToString.ToLower)
            Dim strDefList As String = (datWords.Tables(0).Rows(intCount)(2).ToString.ToLower)
            ' Add items from database to array and listbox
            _strWords.Add(strWordList)
            _strDefinitions.Add(strDefList)
        Next
        _intTotalWords = intCount

        Dim intListDivider As Integer
        Dim intMinusOne As Integer = 0
        If Not _strWords.Count Mod 2 = 0 Then
            intListDivider = Convert.ToInt32(Math.Ceiling(intCount / 2))
            intMinusOne = 1
        Else
            intListDivider = CInt(intCount / 2)
            intMinusOne = 0
        End If

        For i As Integer = 0 To _strWords.Count - 1
            If i < intListDivider Then
                _arrMatchingWordList.Add(_strWords(i))
                _arrMatchingDefinitionList.Add(_strDefinitions(i))
            ElseIf i >= intListDivider - intMinusOne And i < intListDivider * 2 Then
                _arrDefinitionWordList.Add(_strWords(i))
                _arrDefinitionDefinitionList.Add(_strDefinitions(i))
                'ElseIf i > intListDivider * 2 - (intMinusOne * 2) Then
                '    _arrMultipleChoicWordList.Add(_strWords(i))
                '    _arrMultipleChoiceDefinitionList.Add(_strDefinitions(i))
            End If
        Next
        _intTotalMatch = _arrMatchingWordList.Count
        _intTotalDef = _arrDefinitionWordList.Count
        _intTotalMultiChoice = _arrMultipleChoicWordList.Count
        Debug.Print(CType(intCount, String) + " intCount " + CType(_intTotalMatch, String) + "_intTotalMatch " + CType(_intTotalDef, String) + "_intTotalDef ")
    End Sub

    Private Sub frmVocabWords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate definitions and generate word label
        PopulateLists()
        ListSetup(_arrMatchingWordList, _arrMatchingDefinitionList)
        RandomWordLabel(_arrMatchingWordList, _arrMatchingDefinitionList)
        ShowRandomWord()
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'When form is closed
        WriteToFile("Form was Closed Early" + vbNewLine + _strWordWrongGuesses)
    End Sub

    Private Sub WriteToFile()
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("c:\EDATimes\ElijahVocabWordsComplete.txt", True)
        file.WriteLine(CType(System.DateTime.Now, String) + vbNewLine + _strComplete + vbNewLine + CType(_intTotalWords, String) +
                       " Total Words" + vbNewLine)
        file.Close()
        _strComplete = ""
    End Sub

    Private Sub WriteToFile(s As String)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("c:\EDATimes\ElijahVocabWordsComplete.txt", True)
        file.WriteLine(s + CType(System.DateTime.Now, String) + vbNewLine + _strComplete + vbNewLine + CType(_intTotalWords, String) +
                       " Total Words" + vbNewLine)
        file.Close()
        _strComplete = ""
    End Sub

End Class
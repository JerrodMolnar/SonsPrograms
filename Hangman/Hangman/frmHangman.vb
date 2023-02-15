Option Strict On

Public Class frmHangman
    Dim _strWords As New ArrayList
    Dim _intRandom As Integer
    Dim _strSecretWord As String
    Dim _intMisses As Integer
    Dim _strLetterGuessed As String
    Dim _lstlettersguessed As New List(Of String)
    Dim _intNumberOfHangs As Integer

    Private Sub txtInputLetter_TextChanged(sender As Object, e As EventArgs) Handles txtInputLetter.TextChanged
        ' Text inserted in textbox
        If txtInputLetter.Text <> Space(1) Then
            ' Textbox isn't a space
            _strLetterGuessed = txtInputLetter.Text.ToUpper
            HideLetter(_strLetterGuessed)
            If _strLetterGuessed <> "" Then
                ' Letter Guessed is not blank
                If _lstlettersguessed.Count > 0 Then
                    ' list of letters is not blank
                    For intLettersUsed As Integer = 0 To _lstlettersguessed.Count - 1
                        ' Loop to go through list of letters used
                        If intLettersUsed < _lstlettersguessed.Count Then
                            ' List of letters is updated in loop. This is to accomodate for letters removed.
                            If _strLetterGuessed = _lstlettersguessed(intLettersUsed) Then
                                ' Letter guessed has been used
                                MsgBox("used")
                                _lstlettersguessed.RemoveAt(intLettersUsed)
                                lstLettersUsed.Items.RemoveAt(intLettersUsed)
                                If Not _strSecretWord.Contains(_strLetterGuessed) Then
                                    ' Letter guessed has been used and if it is not in the word then do not draw hangman.
                                    _intMisses -= 1
                                End If
                            End If
                        End If
                    Next

                End If
                ' Add letters guessed to lists
                _lstlettersguessed.Add(_strLetterGuessed)
                lstLettersUsed.Items.Add(_strLetterGuessed)
                If Not _strSecretWord.Contains(_strLetterGuessed) Then
                    ' Add miss for letter guessed not being in word and start drawing hangman
                    _intMisses += 1
                    StartDrawingWhenLosing(_intMisses)
                End If
                For intindex As Integer = 0 To _strSecretWord.Length - 1
                    ' Loops through secret word to add letter guessed
                    If _strSecretWord.Substring(intindex, 1) = _strLetterGuessed Then
                        ' Add letter guessed
                        Mid(lblSecretWord.Text, intindex + 1) = _strLetterGuessed
                    End If
                Next
                If Not lblSecretWord.Text.Contains("-") Then
                    ' Word revealed
                    MsgBox("Correct!!!", , "Correct Word")
                    _strWords.RemoveAt(_intRandom)
                    lstWords.Items.RemoveAt(_intRandom)
                    ResetGame()
                End If
                ' Reset textbox
                txtInputLetter.Text = ""
            End If

        Else
            ' Reset textbox if space was entered
            txtInputLetter.Text = ""
        End If

    End Sub

    Private Sub ResetGame()
        ' Reset game, generate new word, clear lists, show letters
        Dim pnt As Graphics
        pnt = CreateGraphics()
        pnt.Clear(Color.DarkRed)
        RandomNumber()
        ShowLetters()
        lstLettersUsed.Items.Clear()
        _lstlettersguessed.Clear()
        txtInputLetter.Focus()
    End Sub

    Private Sub StartDrawingWhenLosing(ByVal trys As Integer)
        ' draw hangman
        Dim pnt As Graphics
        pnt = CreateGraphics()
        Dim pencil As New Pen(Color.Black, 2)
        If trys = 1 Then
            ' Bottom left side of base
            pnt.DrawLine(pencil, 46, 434, 115, 394)
        ElseIf trys = 2 Then
            ' Bottom right side of base
            pnt.DrawLine(pencil, 115, 394, 184, 434)
        ElseIf trys = 3 Then
            ' Hanger support
            pnt.DrawLine(pencil, 115, 394, 115, 220)
        ElseIf trys = 4 Then
            ' Hanger top
            pnt.DrawLine(pencil, 115, 220, 250, 220)
        ElseIf trys = 5 Then
            ' Hanger rope
            pnt.DrawLine(pencil, 250, 220, 250, 250)
        ElseIf trys = 6 Then
            ' Head
            pnt.DrawEllipse(pencil, 228, 250, 40, 40)
        ElseIf trys = 7 Then
            ' Body
            pnt.DrawLine(pencil, 248, 290, 248, 370)
        ElseIf trys = 8 Then
            ' Left arm
            pnt.DrawLine(pencil, 248, 315, 213, 293)
        ElseIf trys = 9 Then
            ' Right arm
            pnt.DrawLine(pencil, 248, 315, 283, 293)
        ElseIf trys = 10 Then
            ' Left leg
            pnt.DrawLine(pencil, 248, 369, 213, 391)
        ElseIf trys = 11 Then
            ' Right leg
            pnt.DrawLine(pencil, 248, 369, 283, 391)
            ' Lose and add 1 to hangs
            MsgBox("You Lose. The word is " & _strSecretWord)
            _intNumberOfHangs += 1
            ResetGame()
        End If
    End Sub

    Private Sub PopulateWords()
        ' Get list of words from database
        Dim strSql As String = "SELECT * FROM SpellingWords"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=C:\EDATimes\SkipVocabWords.accdb"
        Dim odaWords As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datWords As New DataTable
        Dim intCount As Integer

        odaWords.Fill(datWords)
        odaWords.Dispose()
        For intCount = 0 To datWords.Rows.Count - 1
            Dim strWordList As String = (datWords.Rows(intCount)(1).ToString.ToUpper)
            ' Add items from database to array and listbox
            _strWords.Add(strWordList)
            lstWords.Items.Add(strWordList)
        Next
    End Sub

    Private Sub RandomNumber()
        ' Generates random word
        Dim Generator As Random = New Random()
        _strSecretWord = ""
        lblSecretWord.Text = ""
        _strLetterGuessed = ""
        _intMisses = 0
        If _strWords.Count <> 0 Then
            _intRandom = Generator.Next(0, _strWords.Count)
            _strSecretWord = CType(_strWords(_intRandom), String).ToUpper
            For intIndex As Integer = 0 To _strSecretWord.Length - 1
                lblSecretWord.Text += "-"
            Next
        Else
            MsgBox("End of list" & vbNewLine & "You hung the man " & _intNumberOfHangs _
                   & " times.", , "No More Words")
            Close()
        End If
    End Sub

    Private Sub HideLetter(ByVal strLetter As String)
        ' Hide labels for letters used
        Select Case strLetter
            Case "A"
                lblA.Visible = False
            Case "B"
                lblB.Visible = False
            Case "C"
                lblC.Visible = False
            Case "D"
                lblD.Visible = False
            Case "E"
                lblE.Visible = False
            Case "F"
                lblF.Visible = False
            Case "G"
                lblG.Visible = False
            Case "H"
                lblH.Visible = False
            Case "I"
                lblI.Visible = False
            Case "J"
                lblj.Visible = False
            Case "K"
                lblK.Visible = False
            Case "L"
                lblL.Visible = False
            Case "M"
                lblM.Visible = False
            Case "N"
                lblN.Visible = False
            Case "O"
                lblO.Visible = False
            Case "P"
                lblP.Visible = False
            Case "Q"
                lblQ.Visible = False
            Case "R"
                lblR.Visible = False
            Case "S"
                lblS.Visible = False
            Case "T"
                lblT.Visible = False
            Case "U"
                lblU.Visible = False
            Case "V"
                lblV.Visible = False
            Case "W"
                lblW.Visible = False
            Case "X"
                lblX.Visible = False
            Case "Y"
                lblY.Visible = False
            Case "Z"
                lblZ.Visible = False
        End Select
    End Sub

    Private Sub ShowLetters()
        ' displays all letter labels
        txtInputLetter.Text = ""
        lblA.Visible = True
        lblB.Visible = True
        lblC.Visible = True
        lblD.Visible = True
        lblE.Visible = True
        lblF.Visible = True
        lblG.Visible = True
        lblH.Visible = True
        lblI.Visible = True
        lblj.Visible = True
        lblK.Visible = True
        lblL.Visible = True
        lblM.Visible = True
        lblN.Visible = True
        lblO.Visible = True
        lblP.Visible = True
        lblQ.Visible = True
        lblR.Visible = True
        lblS.Visible = True
        lblT.Visible = True
        lblU.Visible = True
        lblV.Visible = True
        lblW.Visible = True
        lblX.Visible = True
        lblY.Visible = True
        lblZ.Visible = True
    End Sub

    Private Sub frmHangman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Gets words and starts game
        PopulateWords()
        ResetGame()

    End Sub
End Class

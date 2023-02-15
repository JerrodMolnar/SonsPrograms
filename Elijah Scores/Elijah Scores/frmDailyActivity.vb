' Program Name: Elijah's Scores
' Author:       Jerrod Molnar
' Date:         October 3, 2016
' Purpose:      Record scores for online educational activities

Option Strict On

Public Class frmDailyActivity
    ' Class Declarations
    Public Shared _intTimes As Integer
    Public Shared _intCounter As Integer
    Public Shared _blnSpellingAndVocabNumberOfTimes As Boolean
    Public Shared _blnVocabDone As Boolean = False
    Public Shared _blnSpellingDone As Boolean = False
    Public Shared _blnMultiplication As Boolean = False
    Dim _intMath As Integer
    Dim _intEnglish As Integer
    Dim _intScience As Integer
    Dim _intMyOn As Integer
    Const _cintStudyIslandMax As Integer = 80
    Const _cintMyOnMax As Integer = 5
    Const _cintStudyIslandPercentMax As Integer = 100
    Const _cintMyOnMaxPossiblePoints As Integer = 5

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

        ' Data Validation
        _intMath = Validation(txtMath.Text)
        _intEnglish = Validation(txtEnglish.Text)
        _intScience = Validation(txtScience.Text)
        _intMyOn = Validation(txtMyOn.Text)

        If _intMath >= _cintStudyIslandMax And _intEnglish >= _cintStudyIslandMax And
                _intScience >= _cintStudyIslandMax And _intMyOn >= _cintMyOnMax And radHomeworkYes.Checked Then
            ' Scores entered are above set standard
            If _intMath <= _cintStudyIslandPercentMax And _intEnglish <= _cintStudyIslandPercentMax And
                _intScience <= _cintStudyIslandPercentMax And _intMyOn <= _cintMyOnMaxPossiblePoints Then
                ' Scores entered do not exceed max values
                WriteData() ' Record scores to text file and listbox
                If _blnMultiplication Then
                    If _blnVocabDone Then
                        'Vocab done
                        If _blnSpellingDone Then
                            ' Spelling done
                            lstScores.Visible = True
                            If _intCounter >= _intTimes Then
                                ' Done with activities
                                MsgBox("Ask a parent if there is anything else you need to do", MsgBoxStyle.Exclamation _
                                   Or MsgBoxStyle.OkOnly, "ALL DONE!!!!!")
                                btnAccept.Visible = False
                                btnExit.Visible = True
                            Else
                                If _blnSpellingAndVocabNumberOfTimes Then
                                    ' Hide Accept button til vocab and spelling done.
                                    btnAccept.Visible = F alse
                                    btnVocab.Visible = True
                                    btnHangman.Visible = True
                                    btnMultiplicationForm.Visible = True
                                End If
                                ' Scores good but have to repeat to = times
                                MsgBox("Keep Going", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Not Done Yet")
                                ClearTextBoxes()
                            End If
                        Else
                            ' Hangman not done
                            MsgBox("Do Spelling Please", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Spelling Needs Done!!!!")
                            btnHangman.Visible = True
                            btnAccept.Visible = False
                        End If
                    Else
                        'Vocab not done
                        MsgBox("Do Vocab Please", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Vocab Needs Done!!!!")
                        btnVocab.Visible = True
                        btnAccept.Visible = False
                    End If
                Else
                    'Multiplication not done
                    MsgBox("Do Multiplication Facts", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Multiplication Needs Done!!!!")
                    btnMultiplicationForm.Visible = True
                    btnAccept.Visible = False
                End If
            Else
                    ' Scores above maximum value
                    MsgBox("Scores exceed maximum possible value", MsgBoxStyle.Critical Or
                           MsgBoxStyle.OkOnly, "Score Too High")
                End If

            Else
            ' Scores lower than what I want
            MsgBox("Check Your Scores And Try Again", MsgBoxStyle.Critical Or
                   MsgBoxStyle.OkOnly, "Input Error")
        End If
        txtMath.Focus()

        ' Change heading for number of times
        lblHeading.Text = "Enter Your Scores And " & vbNewLine & "I Want Them Done " & _intTimes -
            _intCounter & " More Time(s)"

        'Reset variables
        _intMath = 0
        _intEnglish = 0
        _intScience = 0
        _intMyOn = 0
    End Sub


    Private Sub WriteData()
        ' Delarations
        Dim strFilePath As String = IO.Path.Combine("c:\EDATimes\SkipScores.txt")
        Dim objWriter As New IO.StreamWriter(strFilePath, True)
        Dim strDate As Date = CDate(DateString & " " & TimeOfDay)

        ' Write to file and listbox
        If _intCounter = 0 Then
            ' Write date in file only on first time through
            If IO.File.Exists(strFilePath) Then
                ' Scores file exists
                objWriter.WriteLine(strDate)
            Else
                ' Create score file
                IO.File.Create(strFilePath)
                objWriter.WriteLine(strDate)
            End If
        End If

        _intCounter += 1

        If _intCounter <= _intTimes Then
            ' Add a separator to tell me each count of scores
            objWriter.WriteLine(_intCounter & " out of " & _intTimes & " times")
            lstScores.Items.Add(_intCounter & " out of " & _intTimes & " times")
        End If

        ' Write science scores
        objWriter.WriteLine("Science " & _intScience)
        lstScores.Items.Add("Science " & _intScience)

        ' Write english scores
        objWriter.WriteLine("English " & _intEnglish)
        lstScores.Items.Add("English " & _intEnglish)

        ' Write math scores
        objWriter.WriteLine("Math " & _intMath)
        lstScores.Items.Add("Math " & _intMath)

        ' Write MyOn scores
        objWriter.WriteLine("MyOn " & _intMyOn)
        lstScores.Items.Add("MyOn " & _intMyOn)

        'Write whether or not vocab is done
        objWriter.WriteLine("Vocab Done " & _blnVocabDone)
        lstScores.Items.Add("Vocab Done " & _blnVocabDone)

        'Write whether or not Spelling is done
        objWriter.WriteLine("Hangman Done " & _blnSpellingDone)
        lstScores.Items.Add("Hangman Done " & _blnSpellingDone)

        'Write whether or not Multiplication is done
        objWriter.WriteLine("Multiplication Done " & _blnMultiplication)
        lstScores.Items.Add("Multiplication Done " & _blnMultiplication)

        ' Add separator for easy understanding
        objWriter.WriteLine("")
        lstScores.Items.Add("")

        'Close File
        objWriter.Close()

    End Sub

    Private Sub ClearTextBoxes()
        ' Clears text in textboxes
        txtMath.Text = ""
        txtEnglish.Text = ""
        txtScience.Text = ""
        txtMyOn.Text = ""
        txtMath.Focus()
    End Sub

    Private Function Validation(ByVal strScore As String) As Integer
        ' Number validation
        Dim intValidate As Integer

        Try
            ' try to convert to integer
            intValidate = Convert.ToInt32(strScore)
            If Not intValidate > 0 Then
                ' Conversion accepted but not greater than 0
                strScore = ""
            End If
        Catch ex As Exception
            ' Catch exceptions
            strScore = ""
        End Try
        Return intValidate
    End Function

    Public Shared Sub ReadFile()
        ' Reads how many times to loop button code
        Dim strFileName As String = "c:\EDATimes\Times.txt"
        Dim objReader As IO.StreamReader
        Dim strTimes As String
        Dim strSpellingAndVocabTimes As String

        If IO.File.Exists(strFileName) = True Then
            ' File exists, open and read 
            objReader = IO.File.OpenText(strFileName)
            strTimes = objReader.ReadLine()
            _intTimes = CInt(strTimes) ' set variable after reading from file
            strSpellingAndVocabTimes = objReader.ReadLine()
            _blnSpellingAndVocabNumberOfTimes = CBool(strSpellingAndVocabTimes)
            objReader.Close()
        Else
            ' File doesn't exist
            MsgBox("Times not available", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "File Error")
            _intTimes = 1
        End If
        ' Change heading after reading
        frmDailyActivity.lblHeading.Text = "Enter Your Scores And " & vbNewLine & "I Want Them Done " _
            & _intTimes & " More Times"
        ' Set counter to 0
        _intCounter = 0
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' Close program
        Close()
    End Sub

    Private Sub mnuTimes_Click(sender As Object, e As EventArgs) Handles mnuTimes.Click
        ' Show Parent Portal has password and adjust how many times to repeat tasks
        frmParent.ShowDialog()
        mnuClear_Click(sender, e)
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' Clear form and start over
        ClearTextBoxes()
        lstScores.Visible = False
        lstScores.Items.Clear()
        btnExit.Visible = False
        btnHangman.Visible = True
        btnMultiplicationForm.Visible = True
        btnVocab.Visible = True
        btnAccept.Visible = False

        _intCounter = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close Program
        mnuExit_Click(sender, e)
    End Sub

    Private Sub frmDailyActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sets times variable and clears preset text
        ReadFile()
        ClearTextBoxes()
        'Label made from variables
        lblMaxMyOn.Text = "You must have " & _cintMyOnMax & " out of " & _cintMyOnMaxPossiblePoints _
            & " points for MyOn."
        lblMaxStudyIsland.Text = "You must have " & _cintStudyIslandMax & " out of " &
            _cintStudyIslandPercentMax & " points for Study Island"
    End Sub

    Private Sub btnVocab_Click(sender As Object, e As EventArgs) Handles btnVocab.Click
        ' Shows Vocab Matching
        If _blnSpellingAndVocabNumberOfTimes Then
            ' Vocab has to be done = Number of times
            _blnVocabDone = False
        End If
        frmVocabWords.ShowDialog()
        btnVocab.Visible = False
        If _blnSpellingDone And _blnMultiplication Then
            btnAccept.Visible = True
        ElseIf Not _blnSpellingDone Then
            btnHangman.Visible = True
        ElseIf Not _blnMultiplication Then
            btnMultiplicationForm.Visible = True
        End If

    End Sub

    Private Sub btnHangman_Click(sender As Object, e As EventArgs) Handles btnHangman.Click
        ' Shows Hangman
        If _blnSpellingAndVocabNumberOfTimes Then
            ' Spelling has to be done = Number of times
            _blnSpellingDone = False
        End If
        frmHangman.ShowDialog()
        btnHangman.Visible = False
        If _blnVocabDone And _blnMultiplication Then
            btnAccept.Visible = True
        ElseIf Not _blnMultiplication Then
            btnMultiplicationForm.Visible = True
        ElseIf Not _blnVocabDone Then
            btnVocab.Visible = True
        End If
    End Sub

    Private Sub btnMultiplicationForm_Click(sender As Object, e As EventArgs) Handles btnMultiplicationForm.Click
        If _blnSpellingAndVocabNumberOfTimes Then
            _blnMultiplication = False
        End If
        frmMultiplicationPractice.ShowDialog()
        btnMultiplicationForm.Visible = False
        If _blnVocabDone And _blnSpellingDone Then
            btnAccept.Visible = True
        ElseIf Not _blnVocabDone Then
            btnVocab.Visible = True
        ElseIf Not _blnSpellingDone Then
            btnHangman.Visible = True
        End If

    End Sub
End Class

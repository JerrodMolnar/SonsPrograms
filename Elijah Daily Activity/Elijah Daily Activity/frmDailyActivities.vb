Public Class frmDailyActivities
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        ' Declarations

        Dim strMath As String = txtMath.Text
        Dim strEnglish As String = txtEnglish.Text
        Dim strScience As String = txtScience.Text
        Dim strMyOn As String = txtMyOn.Text
        Dim strFilePath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "SkipScores.txt")
        Dim objWriter As New IO.StreamWriter(strFilePath, True)
        Dim strDate As Date = DateString & " " & TimeOfDay
        Dim intMaxScore As Integer = 80
        Dim intMaxMyOne As Integer = 4


        If IO.File.Exists(strFilePath) Then
            objWriter.WriteLine(strDate)
        Else
            IO.File.Create(strFilePath)
            objWriter.WriteLine(strDate)

        End If
        If IsNumeric(strMath) Then
            objWriter.WriteLine(strMath & " Math")
            If strMath >= intMaxScore Then
                txtMath.Text = "Good Job"
            Else
                txtMath.Text = "Try Again " & strMath
            End If
        Else
            MsgBox("Please enter Math score you got from Study Island", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "No Number Entered")
        End If

        If IsNumeric(strEnglish) Then
            objWriter.WriteLine(strEnglish & " English")
            If strEnglish >= intMaxScore Then
                txtEnglish.Text = "Good Job"
            Else
                txtEnglish.Text = "Try Again " & strEnglish
            End If
        Else
            MsgBox("Please enter English score you got from Study Island", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "No Number Entered")
        End If

        If IsNumeric(strScience) Then
            objWriter.WriteLine(strScience & " Science")
            If strScience >= intMaxScore Then
                txtScience.Text = "Good Job"
            Else
                txtScience.Text = "Try Again " & strScience
            End If
        Else
            MsgBox("Please enter Science score you got from Study Island", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "No Number Entered")
        End If
        If IsNumeric(strMyOn) Then
            objWriter.WriteLine(strMyOn & " MyOn")
            objWriter.WriteLine("")

            If strMyOn >= intMaxMyOne Then
                txtMyOn.Text = "Good Job"
            Else
                txtMyOn.Text = "Try Again " & strMyOn
            End If

        Else
            MsgBox("Please enter MyOn score", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "No Number Entered")
        End If



        If radPillsYes.Checked And radSpellingYes.Checked And strMath >= intMaxScore And strEnglish >= intMaxScore And strScience >= intMaxScore And strMyOn >= intMaxMyOne Then
            If (radSchoolworkYes.Checked And radSchoolworkDoneYes.Checked) Or radSchoolworkNo.Checked Then
                MsgBox("GO PLAY XBOX!!!!!!", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "XBOX TIME!!!!!")
            End If
        Else
            MsgBox("GET BETTER SCORES OR DO WHAT YOU HAVEN'T DONE", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "GET BETTER SCORES")
        End If

        'Close File
        objWriter.Close()
        btnDone.Enabled = False
        btnDone.Visible = False
        btnRetry.Enabled = True
        btnRetry.Visible = True
    End Sub

    Private Sub frmDailyActivities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radPillsNo.Checked = True
        radPillsYes.Checked = False
        radSpellingNo.Checked = True
        radSpellingYes.Checked = False
        radSchoolworkNo.Checked = True
        radSchoolworkYes.Checked = False
        radSchoolworkDoneNo.Checked = True
        radSchoolworkDoneYes.Checked = False
        grpOtherHwDone.Visible = False
        txtEnglish.Text = ""
        txtMath.Text = ""
        txtMyOn.Text = ""
        txtScience.Text = ""
        btnRetry.Enabled = False
        btnDone.Enabled = True
        btnDone.Visible = True
        btnRetry.Visible = False

    End Sub

    Private Sub radSchoolworkYes_CheckedChanged(sender As Object, e As EventArgs) Handles radSchoolworkYes.CheckedChanged
        grpOtherHwDone.Visible = True
    End Sub

    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click
        frmDailyActivities_Load(sender, e)
    End Sub

    Private Sub radSchoolworkNo_CheckedChanged(sender As Object, e As EventArgs) Handles radSchoolworkNo.CheckedChanged
        grpOtherHwDone.Visible = False
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        frmDailyActivities_Load(sender, e)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()

    End Sub
End Class

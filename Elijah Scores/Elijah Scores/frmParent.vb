Option Strict On

Public Class frmParent



    Private Sub btnParentOk_Click(sender As Object, e As EventArgs) Handles btnParentOk.Click
        ' Declarations
        Const cstrPassword As String = "Schoolwork"
        Dim strInputPassword As String
        Dim blnTimes As String = CType(False, String)
        Const cstrFileName As String = "c:\EDATimes\Times.txt"
        Const cstrDirectory As String = "c:\EDATimes"

        strInputPassword = txtPassword.Text
        ' Validate number entered for how many times he needs to repeat
        blnTimes = CType(ValidateTimes(), String)

        If strInputPassword = cstrPassword And CBool(blnTimes) Then
            ' Password Correct and times validated
            frmDailyActivity._intTimes = CInt(txtTimes.Text) ' set number of times equal to input
            If Not IO.Directory.Exists(cstrDirectory) Then
                ' Make directory for .txt file
                IO.Directory.CreateDirectory(cstrDirectory)
            End If

            Dim objWriter As New IO.StreamWriter(cstrFileName) ' Opens file
            If IO.File.Exists(cstrFileName) Then
                ' Number of times file exists
                objWriter.WriteLine(frmDailyActivity._intTimes)
                If radParentNo.Checked Then
                    frmDailyActivity._blnSpellingAndVocabNumberOfTimes = False
                ElseIf radParentYes.Checked Then
                    frmDailyActivity._blnSpellingAndVocabNumberOfTimes = True
                End If
                objWriter.WriteLine(frmDailyActivity._blnSpellingAndVocabNumberOfTimes)
            Else
                ' Create number of times file
                IO.File.Create(cstrFileName)
                objWriter.WriteLine(frmDailyActivity._intTimes)
                If radParentNo.Checked Then
                    frmDailyActivity._blnSpellingAndVocabNumberOfTimes = False
                ElseIf radParentYes.Checked Then
                    frmDailyActivity._blnSpellingAndVocabNumberOfTimes = True
                End If
                objWriter.WriteLine(frmDailyActivity._blnSpellingAndVocabNumberOfTimes)
            End If
            objWriter.Close() ' Closes file
            MsgBox("Your input has been saved.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Input Accepted")
            Call frmDailyActivity.ReadFile()
            Close()
        Else
            ' Password Incorrect
            MsgBox("Password Incorrect", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Password Incorrect")
        End If

    End Sub

    Private Function ValidateTimes() As Boolean
        ' Declarations
        Dim blnHowManyTimes As Boolean

        Try
            ' Will data convert?
            frmDailyActivity._intTimes = Convert.ToInt32(txtTimes.Text)
            If frmDailyActivity._intTimes > 0 Then
                ' Data conversion complete and greater than 0
                blnHowManyTimes = True
            Else
                ' Data conversion complete but not greater than 0
                MsgBox("Must have at least one time.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly,
                       "How Many Times")
                txtTimes.Focus()
            End If
        Catch ex As Exception
            ' Catch exceptions
            MsgBox("Enter a numeric value.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Input Error")
            txtTimes.Focus()

        End Try
        Return blnHowManyTimes ' Returns boolean to allow or not allow further processing
    End Function

    Private Sub frmParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear preset text
        txtPassword.Text = ""
        txtTimes.Text = ""
    End Sub
End Class
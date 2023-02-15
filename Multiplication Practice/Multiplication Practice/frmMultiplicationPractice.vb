Option Strict On

Public Class frmMultiplicationPractice
    ' Class Declarations
    Const _cintHighendRandomNumber As Integer = 12
    Const _cintTotalNumberOfProblems As Integer = 100
    Dim _intAnswer As Integer
    Dim _intNumberOfProblem As Integer
    Dim _intNumberWrong As Integer = 0

    Private Function Problem() As Integer
        Dim intProblem As Integer
        Dim intMultiplicand As Integer
        Dim intMultiplier As Integer
        Dim strSpace As String = " "

        intMultiplicand = RandomMultiplicand()
        intMultiplier = RandomMultiplier()
        intProblem = intMultiplicand * intMultiplier

        _intNumberOfProblem += 1
        lblProblemNumber.Text = _intNumberOfProblem.ToString & "."

        If intMultiplier >= 10 And intMultiplicand < 10 Then
            lblMultiplicand.Text = "  " & intMultiplicand.ToString
        Else
            lblMultiplicand.Text = intMultiplicand.ToString
        End If

        If intMultiplicand > 9 Then
            For I As Integer = 1 To intMultiplicand.ToString.Length

                If intMultiplier < 10 Then
                    strSpace &= " "
                End If
                lblMultiplier.Text = "x" & strSpace & intMultiplier.ToString
            Next
        Else
            lblMultiplier.Text = "x" & strSpace & intMultiplier.ToString
        End If
        strSpace = " "
        Return intProblem

    End Function

    Private Function RandomMultiplicand() As Integer
        Dim intMultiplicand As Integer

        intMultiplicand = CInt(Int((_cintHighendRandomNumber * Rnd()) + 1))
        Return intMultiplicand
    End Function

    Private Function RandomMultiplier() As Integer
        Dim intMultiplier As Integer

        intMultiplier = CInt(Int((_cintHighendRandomNumber * Rnd())) + 1)
        Return intMultiplier
    End Function

    Private Sub ClearLabels()
        lblMultiplier.Text = ""
        lblMultiplicand.Text = ""
        txtAnswer.Clear()
        _intAnswer = 0
    End Sub

    Private Sub frmMultiplicationPractice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClearLabels()
        _intAnswer = Problem()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim intPreauth As Integer

        Try
            intPreauth = CInt(txtAnswer.Text)
            If intPreauth < 0 Then
                MsgBox("Enter Positive Number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Positive Number Needed")
            Else
                If _intAnswer = intPreauth Then
                    If _intNumberOfProblem >= _cintTotalNumberOfProblems Then
                        MsgBox("Great Job!!!", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Well Done!!!")
                        Close()

                    End If
                    MsgBox("Correct!", MsgBoxStyle.OkOnly, "Correct Answer")
                    frmMultiplicationPractice_Load(sender, e)
                Else
                    MsgBox("Incorrect, Please Try Again.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Incorrect Answer")
                    _intNumberWrong += 1
                    txtAnswer.Clear()
                    lblWrong.Text = _intNumberWrong.ToString()
                    lblWrong.Visible = True
                End If
            End If

        Catch ex As Exception
            MsgBox("Enter a Number Please", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Number Incorrect")
            txtAnswer.Clear()

        End Try


    End Sub
End Class

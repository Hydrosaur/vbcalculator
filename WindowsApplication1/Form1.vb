Public Class Form1

    Private Sub Add(ByVal decNumber As Decimal, ByVal decNumber2 As Decimal)
        Dim decAnswer As Decimal = 0
        decAnswer = decNumber + decNumber2
        lblDisplay.text = "Answer: " + decAnswer.ToString
    End Sub


    Private Sub Subtract(ByVal decNumber As Decimal, ByVal decNumber2 As Decimal)
        Dim decAnswer As Decimal = 0
        decAnswer = decNumber - decNumber2
        lblDisplay.text = "Answer: " + decAnswer.ToString

    End Sub

    Private Sub Multiply(ByVal decNumber As Decimal, ByVal decNumber2 As Decimal)
        Dim decAnswer As Decimal = 0
        decAnswer = decNumber * decNumber2
        lblDisplay.text = "Answer: " + decAnswer.ToString
    End Sub


    Private Sub Divide(ByVal decNumber As Decimal, ByVal decNumber2 As Decimal)
        Dim decAnswer As Decimal = 0
        decAnswer = decNumber / decNumber2
        lblDisplay.text = "Answer: " + decAnswer.ToString
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

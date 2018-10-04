Imports System
Imports System.Windows.Forms
Public Class MathIssues

    Public Shared Function DontDivideByZero(dFirstValue As Double, dSecondValue As Double) As Double

        If Convert.IsDBNull(dFirstValue) Then
            dFirstValue = 0
        End If

        If Convert.IsDBNull(dSecondValue) Then
            dSecondValue = 0
        End If

        If dSecondValue = 0 Then
            Return 0
        Else
            Return dFirstValue / dSecondValue
        End If

    End Function

    Public Shared Function ReturnAZeroIfNull(dValue As Double) As Double

        If Convert.IsDBNull(dValue) Then
            Return 0
        Else
            Return dValue
        End If

    End Function

End Class


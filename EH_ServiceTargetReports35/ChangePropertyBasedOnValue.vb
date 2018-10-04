Imports System
Public Class ChangePropertyBasedOnValue

    Public Overloads Shared Function ChangeColor(vValue As Double) As String


        If vValue <= 0.85 Then
            Return "red"

        ElseIf vValue > 0.85 And vValue < 1.0 Then

            Return "#A7B311"

        ElseIf vValue >= 1.0 Then
            Return "Green"

        Else
            Return "Black"

        End If

    End Function

    Public Overloads Shared Function ChangeColor(vValue As Double, sColor As String) As String


        If vValue <= 0.85 Then
            Return "red"

        ElseIf vValue > 0.85 And vValue < 1.0 Then

            Return sColor

        ElseIf vValue >= 1.0 Then
            Return "Green"

        Else
            Return "Black"

        End If

    End Function

End Class


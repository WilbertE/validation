Option Strict On
Option Explicit On

Public Class validate

    ''' <summary>
    ''' Validates if input is integer
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Function isInteger(value As String) As Boolean

        Dim test As Integer = 0
        If Integer.TryParse(value, test) Then
            Return True
        Else
            Return False
        End If

    End Function

End Class




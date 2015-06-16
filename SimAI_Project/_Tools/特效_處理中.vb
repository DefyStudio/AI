Public Class 特效_處理中
    Public Function 特效_處理中() As String
        Dim LoadingDot As Integer = Now.Second, DotResult As String = ""
        If LoadingDot > 10 Then LoadingDot = LoadingDot.ToString.Substring(1)
        While LoadingDot > 0
            DotResult += "."
            LoadingDot -= 1
        End While
        Return DotResult
    End Function
End Class

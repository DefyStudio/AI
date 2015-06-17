Public Class 格式_半形
    Public Function 格式_半形(文字 As String) As String
        Return StrConv(文字, vbNarrow)
    End Function
End Class

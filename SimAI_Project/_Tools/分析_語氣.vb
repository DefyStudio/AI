Public Class 分析_語氣
    Public Function 分析_語氣(ByVal 字 As Char) As String
        If "!！".Contains(字) Then Return "感嘆"
        If "?？".Contains(字) Then Return "疑問"
        If ",， ".Contains(字) Then Return "停頓"
        If "：：".Contains(字) Then Return "例子"
        If ".．‧".Contains(字) Then Return "完結"
        Return ""
    End Function
End Class

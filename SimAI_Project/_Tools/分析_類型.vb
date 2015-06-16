Public Class 分析_類型
    Dim 類型_ As New Type.類型
    Public Function 分析_類型(字 As Char) As String
        Select Case AscW(字)
            Case 0 To 225
                Select Case AscW(字)
                    Case 48 To 57
                        Return 類型_.數字
                    Case 65 To 90
                        Return 類型_.英文
                    Case 97 To 122
                        Return 類型_.英文
                    Case Else
                        Return 類型_.符號
                End Select
            Case 19968 To 40613
                Return 類型_.中文
            Case Else
                Return ""
        End Select
    End Function
End Class

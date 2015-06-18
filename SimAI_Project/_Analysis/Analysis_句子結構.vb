Public Class Analysis_句子結構
    Dim Tools As New Tools
    Public Function 處理_問題(ByVal 問題 As String) As String
        Dim 主語 As String = "", 謂語 As String = ""
        For Each 字 As Char In 問題
            Select Case Tools.分析_詞性(字)
                Case "代詞"
                    主語 += 字
                Case Else
                    謂語 += 字
            End Select
        Next
        Return 主語 + "," + 謂語
    End Function

End Class

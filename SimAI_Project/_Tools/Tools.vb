Public Class Tools
    Private WebClient As New System.Net.WebClient(), 類型_ As New 類型
    Private Delegate Sub 跨執行緒存取寫入_(ByVal 文字 As String, ByVal 物件 As Control)
    Public Function 回應_GET(ByVal 網址 As String) As String
        Return WebClient.DownloadString(網址)
    End Function
    Public Sub 跨執行緒存取寫入(ByVal 文字 As String, ByVal 物件 As Control)
        If UI.InvokeRequired Then
            UI.Invoke(New 跨執行緒存取寫入_(AddressOf 跨執行緒存取寫入), 文字, 物件)
        Else
            物件.Text = 文字
        End If
    End Sub
    Public Sub 物件置中(ByVal 母 As Control, ByVal 子 As Control)
        子.SetBounds((母.Width - 子.Width) / 2, (母.Height - 子.Height) / 2, 0, 0, BoundsSpecified.Location)
    End Sub
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
    Public Function 分析_詞性(字 As Char) As String
        If "我你妳您他她它伱誰".Contains(字) Then Return "代詞"
        If "的是".Contains(字) Then Return "助詞"
        Return ""
    End Function
    Public Class 類型
        Public Function 數字() As String
            Return "數字"
        End Function
        Public Function 英文() As String
            Return "英文"
        End Function
        Public Function 符號() As String
            Return "符號"
        End Function
        Public Function 中文() As String
            Return "中文"
        End Function
    End Class
End Class

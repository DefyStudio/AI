Public Class Tools
    Public Function 回應_GET(ByVal 網址 As String) As String
        Dim Handler As New 回應_GET
        Return Handler.回應_GET(網址)
    End Function
    Public Sub 跨執行緒存取寫入(ByVal 文字 As String, ByVal 物件 As Control)
        Dim Handler As New 跨執行緒存取寫入
        Handler.跨執行緒存取寫入(格式_半形(文字), 物件)
    End Sub
    Public Sub 物件置中(ByVal 母 As Control, ByVal 子 As Control)
        Dim Handler As New 物件置中
        Handler.物件置中(母, 子)
    End Sub
    Public Function 分析_類型(ByVal 字 As Char) As String
        Dim Handler As New 分析_類型
        Return Handler.分析_類型(格式_半形(字))
    End Function
    Public Function 分析_詞性(ByVal 字 As Char) As String
        Dim Handler As New 分析_詞性
        Return Handler.分析_詞性(格式_半形(字))
    End Function
    Public Function 分析_語氣(ByVal 字 As Char) As String
        Dim Handler As New 分析_語氣
        Return Handler.分析_語氣(格式_半形(字))
    End Function
    Public Function 特效_處理中() As String
        Dim Handler As New 特效_處理中
        Return Handler.特效_處理中
    End Function
    Public Sub 複製Listbox(ByVal ORGIN As ListBox, ByVal NEWS As ListBox)
        Dim Handler As New 複製Listbox
        Handler.複製Listbox(ORGIN, NEWS)
    End Sub
    Public Function 格式_半形(文字 As String) As String
        Dim Handler As New 格式_半形
        Return Handler.格式_半形(文字)
    End Function
End Class

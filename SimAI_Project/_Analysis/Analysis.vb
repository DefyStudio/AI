Public Class Analysis
    Dim Wiki As New Wiki, Google As New Google.Translate, Wiki_語言 As New Type.語言, Tools As New Tools, Tools_類型 As New Type.類型
    Public Debug_ As New ListBox
    Public Function 處理_問題(ByVal 問題 As String) As String
        Debug_.Items.Clear()
        問題 = Google.翻譯(問題, "zh-TW")
        For Each 文字 As Char In 問題
            Dim WikiResult As String = ""
            Select Case Tools.分析_類型(文字)
                Case Tools_類型.中文
                    WikiResult = Tools.分析_詞性(文字)
                    If String.IsNullOrEmpty(WikiResult) Then WikiResult = Wiki.查詢(文字, Wiki_語言.粵語)
                    If String.IsNullOrEmpty(WikiResult) Then WikiResult = Wiki.查詢(文字, Wiki_語言.繁體)
                Case Tools_類型.英文
                    WikiResult = Wiki.查詢(文字, Wiki_語言.English)
                Case Tools_類型.符號
                    WikiResult = Tools.分析_語氣(文字)
            End Select
            Debug_.Items.Add(文字 + "," + WikiResult)
        Next
        Return "我吾知你想講乜。"
    End Function
End Class

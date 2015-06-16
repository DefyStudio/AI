Public Class Analysis
    Dim Wiki As New Wiki, Wiki_語言 As New Wiki.語言, Tools As New Tools, Tools_類型 As New Tools.類型
    Public Function 處理_問題(ByVal 問題 As String) As String
        UI.ListBox1.Items.Clear()
        For Each 文字 As Char In 問題
            Dim WikiResult As String = ""
            Select Case Tools.分析_類型(文字)
                Case Tools_類型.中文
                    WikiResult = Tools.分析_詞性(文字)
                    If String.IsNullOrEmpty(WikiResult) Then WikiResult = Wiki.查詢(文字, Wiki_語言.粵語)
                    If String.IsNullOrEmpty(WikiResult) Then WikiResult = Wiki.查詢(文字, Wiki_語言.繁體)
                Case Tools_類型.英文
                    If String.IsNullOrEmpty(WikiResult) Then WikiResult = Wiki.查詢(文字, Wiki_語言.English)
            End Select
            UI.ListBox1.Items.Add(文字 + "," + WikiResult)
        Next
        Return "我吾知你想講乜。"
    End Function
End Class

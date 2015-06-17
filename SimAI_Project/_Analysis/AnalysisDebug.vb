Public Class AnalysisDebug
    Dim Wiki As New Wiki, Google As New Google.Translate, Wiki_語言 As New Type.語言, Tools As New Tools, Tools_類型 As New Type.類型, Wikia As New Wikia
    Public Debug_ As New ListBox
    Public Function 處理_問題(ByVal 問題 As String) As String
        Dim Reply As String = "我吾知你想講乜。"
        Debug_.Items.Clear()
        Debug_.Items.Add(問題)
        問題 = Google.翻譯(問題, "en", "zh-TW")
        Reply = 問題
        'Dim WikiResult As String = ""
        ' If String.IsNullOrEmpty(WikiResult) Then WikiResult = Wiki.查詢(問題, Wiki_語言.粵語)
        ' If String.IsNullOrEmpty(WikiResult) Then WikiResult = Wiki.查詢(問題, Wiki_語言.繁體)
        ' If String.IsNullOrEmpty(WikiResult) Then WikiResult = Wikia.查詢(問題, "evchk")
        '  Debug_.Items.Add(問題 + " , " + WikiResult)
        Return Reply
    End Function
End Class

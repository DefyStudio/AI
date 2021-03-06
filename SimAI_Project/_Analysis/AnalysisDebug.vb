﻿Public Class AnalysisDebug
    Dim Wiki As New Wiki, Google As New Google.Translate, Wiki_語言 As New Type.語言, Tools As New Tools, Tools_類型 As New Type.類型, Wikia As New Wikia, Analysis_句子結構 As New Analysis_句子結構
    Dim 回答方式 As String = ""
    Public Debug_ As New ListBox
    Public Function 處理_問題(ByVal 問題 As String) As String
        Dim Reply As String = "我吾知你想講乜。"
        回答方式 = ""
        Debug_.Items.Clear()
        Debug_.Items.Add(問題)
        For i As Integer = 0 To 問題.Length - 1
            If Tools.分析_類型(問題.Chars(i)) = Tools_類型.符號 Then 問題.Replace(問題.Chars(i), " ")
        Next
        Debug_.Items.Add(AnalysisInWeb(問題))
        If Not String.IsNullOrEmpty(Tools.分析_語氣(問題.Last)) Then
            問題 = 問題.Substring(0, 問題.Length - 1)
        End If
        問題 = Google.翻譯(問題, "zh-TW")
        Debug_.Items.Add(AnalysisInWeb(問題))
        Debug_.Items.Add(Analysis_句子結構.處理_問題(問題))
        Reply = 問題
        If 回答方式 = "問候" Then Reply = "你好。"
        Return Reply
    End Function
    Private Function AnalysisInWeb(ByVal 問題 As String) As String
        Dim WikiResult As String = ""
        If String.IsNullOrEmpty(WikiResult) Then WikiResult = Wiki.查詢(問題, Wiki_語言.粵語)
        If String.IsNullOrEmpty(WikiResult) Then WikiResult = Wiki.查詢(問題, Wiki_語言.繁體)
        If String.IsNullOrEmpty(WikiResult) Then WikiResult = Wiki.查詢(問題, Wiki_語言.English)
        If String.IsNullOrEmpty(WikiResult) Then WikiResult = Wikia.查詢(問題, "evchk")
        If WikiResult.Contains("問候") Then 回答方式 = "問候"
        Return WikiResult
    End Function
End Class

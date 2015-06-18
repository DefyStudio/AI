﻿Public Class Wikia
    Dim Tools As New Tools
    Public Function 查詢(ByVal 字眼 As String, ByVal 伺服器 As String) As String
        ' MsgBox("http://" + 伺服器 + ".wikia.com/api/v1/Articles/Details?titles=" + 字眼 + "&redirects")
        Dim JObject As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.Linq.JObject.Parse(Tools.回應_GET("http://" + 伺服器 + ".wikia.com/api/v1/Articles/Details?titles=" + 字眼 + "&redirects"))
        Try
            Return Tools.格式_半形(JObject.SelectToken(JObject.SelectToken("items").Last.Path).Item("abstract").ToString)
        Catch ex As Exception
            Return ""
        End Try
    End Function
End Class

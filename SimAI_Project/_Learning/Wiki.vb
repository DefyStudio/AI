Public Class Wiki
    Dim Tools As New Tools
    Public Function 查詢(ByVal 字眼 As String, ByVal 語言_ As String) As String
        Dim JObject As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.Linq.JObject.Parse(Tools.回應_GET("https://" + 語言_ + ".wikipedia.org/w/api.php?format=json&action=query&prop=extracts&exintro=&redirects&explaintext=&titles=" + 字眼))
        Try
            Return JObject.SelectToken(JObject.SelectToken("query.pages").Last.Path).Item("extract").ToString
        Catch ex As Exception
            Return ""
        End Try
    End Function
End Class

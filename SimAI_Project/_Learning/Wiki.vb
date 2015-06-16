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
    Public Class 語言
        Public Function 粵語() As String
            Return "zh-yue"
        End Function
        Public Function 繁體() As String
            Return "zh"
        End Function
        Public Function العربية() As String
            Return "ar"
        End Function
        Public Function Български() As String
            Return "bg"
        End Function
        Public Function বাংলা() As String
            Return "bn"
        End Function
        Public Function Bosanski() As String
            Return "bs"
        End Function
        Public Function বিষ্ণুপ্রিয়ামণিপুরী() As String
            Return "bpy"
        End Function
        Public Function Brezhoneg() As String
            Return "br"
        End Function
        Public Function Català() As String
            Return "ca"
        End Function
        Public Function Čeština() As String
            Return "cs"
        End Function
        Public Function Dansk() As String
            Return "da"
        End Function
        Public Function Deutsch() As String
            Return "de"
        End Function
        Public Function Ελληνικά() As String
            Return "el"
        End Function
        Public Function English() As String
            Return "en"
        End Function
        Public Function Español() As String
            Return "es"
        End Function
    End Class
End Class

Public Class Google
    Dim Tools As New Tools
    Public Class Translate
        Dim Tools As New Tools
        Public Function 翻譯(ByVal 文字 As String, ByVal 目標語言 As String, Optional ByVal 原本語言 As String = "auto")
            Try
                'MsgBox("https://translate.google.com.hk/translate_a/single?client=t&sl=auto&tl=" + 目標語言 + "&dt=t&q=" + System.Web.HttpUtility.UrlEncode(文字, System.Text.Encoding.ASCII))
                Dim Result = Tools.回應_GET("https://translate.googleapis.com/translate_a/single?client=t&sl=" + 原本語言 + "&tl=" + 目標語言 + "&dt=t&q=" + System.Web.HttpUtility.UrlEncode(文字, System.Text.Encoding.ASCII))
                MsgBox(Result)
                Result = Result.Substring(4, Result.Length - 4).Split(ControlChars.Quote).First
                Return Tools.格式_半形(Result)
            Catch ex As Exception
                Return 文字
            End Try
        End Function
        Public Function 翻譯_語言偵測(ByVal 文字 As String)
            Dim Result = ""
            Try
                MsgBox(Tools.回應_GET("https://translate.googleapis.com/translate_a/single?client=gtx&sl=auto&tl=en&dt=t&q=" + System.Net.WebUtility.UrlEncode(文字)))
                Result = Tools.回應_GET("https://translate.googleapis.com/translate_a/single?client=gtx&sl=auto&tl=en&dt=t&q=" + System.Net.WebUtility.UrlEncode(文字)).Split(ControlChars.Quote)(5)
            Catch ex As Exception
            End Try
            Return Result
        End Function
    End Class
End Class

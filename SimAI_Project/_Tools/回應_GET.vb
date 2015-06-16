Public Class 回應_GET
    Public Function 回應_GET(ByVal 網址 As String) As String
        Dim WebClient As New System.Net.WebClient()
        WebClient.Encoding = System.Text.Encoding.UTF8
        Return WebClient.DownloadString(網址)
    End Function
End Class

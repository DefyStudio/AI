Public Class 跨執行緒存取寫入
    Private Delegate Sub 跨執行緒存取寫入_(ByVal 文字 As String, ByVal 物件 As Control)
    Public Sub 跨執行緒存取寫入(ByVal 文字 As String, ByVal 物件 As Control)
        If UI.InvokeRequired Then
            UI.Invoke(New 跨執行緒存取寫入_(AddressOf 跨執行緒存取寫入), 文字, 物件)
        Else
            If TypeOf 物件 Is ListBox Then
                CType(物件, ListBox).Items.Add(文字)
            ElseIf TypeOf 物件 Is Label Or TypeOf 物件 Is TextBox Then
                物件.Text = 文字
            End If
        End If
    End Sub
End Class

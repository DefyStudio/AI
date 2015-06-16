Public Class UI
    Dim Tools As New Tools, Analysis As New Analysis
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Tools.物件置中(Panel2, Label1)
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Label1.Text = "您好！我有乜野可以幫到你？"
    End Sub
    Private Sub TextBox1_PlaceHolderEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "你的問題.." Then
            TextBox1.ForeColor = Color.Black
            TextBox1.Text = ""
        End If
    End Sub
    Private Sub TextBox1_PlaceHolderOrgin(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.ForeColor = Color.FromArgb(136, 136, 136)
            TextBox1.Text = "你的問題.."
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            Label1.Font = New Font(Label1.Font.FontFamily, 14)
            Label1.Text = Analysis.處理_問題(TextBox1.Text)
        End If
    End Sub
End Class

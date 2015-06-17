Public Class UI
    Dim Tools As New Tools, Analysis As New Analysis, AnalysisDebug As New AnalysisDebug, 處理結果 As String = ""
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Tools.物件置中(Panel2, Label1)
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Label1.Text = "您好！我有乜野可以幫到你？"
    End Sub
    Private Sub TextBox1_PlaceHolderEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        If TextBox1.ForeColor = Color.FromArgb(136, 136, 136) Then
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
        If TextBox1.ForeColor = Color.Black And Not 處理_結果.IsBusy Then
            TextBox1.Enabled = False
            處理_結果.RunWorkerAsync()
            Label1.Text = ""
            Label1.Font = New Font(Label1.Font.FontFamily, 45)
            While 處理_結果.IsBusy
                Label1.Text = Tools.特效_處理中
                Tools.物件置中(Panel2, Label1)
                Application.DoEvents()
            End While
            Label1.Font = New Font(Label1.Font.FontFamily, 14)
            Label1.Text = 處理結果
            Tools.物件置中(Panel2, Label1)
            TextBox1.ForeColor = Color.FromArgb(136, 136, 136)
            TextBox1.Enabled = True
            Tools.複製Listbox(Analysis.Debug_, ListBox1)
        End If
    End Sub
    Private Sub 處理_結果_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles 處理_結果.DoWork
        處理結果 = Analysis.處理_問題(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.ForeColor = Color.Black And Not 處理_結果_Debug.IsBusy Then
            TextBox1.Enabled = False
            處理_結果_Debug.RunWorkerAsync()
            Label1.Text = ""
            Label1.Font = New Font(Label1.Font.FontFamily, 45)
            While 處理_結果_Debug.IsBusy
                Label1.Text = Tools.特效_處理中
                Tools.物件置中(Panel2, Label1)
                Application.DoEvents()
            End While
            Label1.Font = New Font(Label1.Font.FontFamily, 14)
            Label1.Text = 處理結果
            Tools.物件置中(Panel2, Label1)
            TextBox1.ForeColor = Color.FromArgb(136, 136, 136)
            TextBox1.Enabled = True
            Tools.複製Listbox(AnalysisDebug.Debug_, ListBox1)
        End If
    End Sub
    Private Sub 處理_結果_Debug_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles 處理_結果_Debug.DoWork
        處理結果 = AnalysisDebug.處理_問題(TextBox1.Text)
    End Sub
End Class

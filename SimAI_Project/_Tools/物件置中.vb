Public Class 物件置中
    Public Sub 物件置中(ByVal 母 As Control, ByVal 子 As Control)
        子.SetBounds((母.Width - 子.Width) / 2, (母.Height - 子.Height) / 2, 0, 0, BoundsSpecified.Location)
    End Sub
End Class

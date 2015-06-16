Public Class 複製Listbox
    Public Sub 複製Listbox(ORGIN As ListBox, NEWS As ListBox)
        Dim objCollection As Object() = New Object(ORGIN.Items.Count - 1) {}
        ORGIN.Items.CopyTo(objCollection, 0)
        NEWS.Items.Clear()
        NEWS.Items.AddRange(objCollection)
    End Sub
End Class

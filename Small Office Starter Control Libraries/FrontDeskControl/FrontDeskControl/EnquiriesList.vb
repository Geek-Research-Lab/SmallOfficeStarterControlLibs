'
' enquiries list
'
Public Class EnquiriesList
    Public mqq, qqm0, qqm1, qqm2, qqm3, qqm4, qqm5, qqm6, qqm7 As String
    Public xyz As String
    ' close
    Private Sub EnquiriesList_Close_Click(sender As Object, e As EventArgs) Handles EnquiriesList_Close.Click
        Close()
    End Sub
    ' init load
    Dim doc_loc As XDocument = XDocument.Load("Resources/location.xml")
    Private Sub EnquiriesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim location As IEnumerable(Of XElement) = doc_loc.Descendants("location")
        For Each locations In location
            xyz = locations.Element("path").Value
        Next
        EnquiriesList_Body.Navigate(xyz)
        MsgBox("Loaded")
        EnquiriesList_Body.ShowPrintPreviewDialog()
    End Sub
End Class
'
' ashumeow
'

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim numVisitors As Long = 0

        ' Check if Application variable exists
        If Not Application("Visitors") Is Nothing Then
            numVisitors = Long.Parse(Application("Visitors").ToString())
        End If

        VisitorLiteral.Text = "Number of visitors: " & numVisitors.ToString()
    End Sub
End Class

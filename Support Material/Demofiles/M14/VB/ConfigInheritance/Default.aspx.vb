
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Get counter from configuration file
        Dim counter As Integer = Integer.Parse( _
            System.Web.Configuration.WebConfigurationManager.AppSettings("Counter"))

        Response.Write("Counter value retrieved from web.config = " & counter.ToString())
    End Sub
End Class
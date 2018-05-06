
Partial Class About
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Show about box
        AboutModalPopupExtender.Show()
    End Sub

    Protected Sub CloseButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        ' Close about box
        AboutModalPopupExtender.Hide()
    End Sub

End Class

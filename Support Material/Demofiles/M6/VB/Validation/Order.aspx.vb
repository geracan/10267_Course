
Partial Class Order
    Inherits System.Web.UI.Page

    Protected Sub OrderSaveButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderSaveButton.Click

    End Sub

    Protected Sub OrderCancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderCancelButton.Click

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        OrderDateTextBox.Text = DateTime.Now.ToShortDateString()
    End Sub
End Class

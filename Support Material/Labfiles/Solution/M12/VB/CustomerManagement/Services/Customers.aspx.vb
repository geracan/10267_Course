Imports CustomersService

Partial Class Services_Customers
    Inherits System.Web.UI.Page

    Protected Sub GetCountriesButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GetCountriesButton.Click
        Dim customersService As New CustomersClient()
        CustomersGridView.DataSource = customersService.GetCountries(StartingLettersTextBox.Text)
        CustomersGridView.DataBind()
    End Sub
End Class

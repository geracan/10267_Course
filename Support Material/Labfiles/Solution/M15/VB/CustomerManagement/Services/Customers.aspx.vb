Imports CustomersService

Partial Class Services_Customers
    Inherits System.Web.UI.Page

    Private countryDataTable As System.Data.DataTable = Nothing

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Retrieve DataTable from cache
        countryDataTable =
            CType(Cache("Countries"), System.Data.DataTable)
    End Sub

    Protected Sub GetCountriesButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GetCountriesButton.Click
        ' Does cached item exist?
        If countryDataTable Is Nothing Then
            Dim customersService As New CustomersClient()
            ' Retrieve DataTable from WCF Service
            countryDataTable = customersService.GetCountries(StartingLettersTextBox.Text)
            ' Save DataTable to cache
            Cache("Countries") = countryDataTable

        End If

        ' Set GridView DataSource
        CustomersGridView.DataSource = countryDataTable
        CustomersGridView.DataBind()
    End Sub
End Class

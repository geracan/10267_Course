using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomersService;

public partial class Services_Customers : System.Web.UI.Page
{
    private System.Data.DataTable countryDataTable = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Retrieve DataTable from cache
        countryDataTable =
            (System.Data.DataTable) Cache["Countries"];
    }

    protected void GetCountriesButton_Click(object sender, EventArgs e)
    {
        // Does cached item exist?
        if (countryDataTable == null)
        {
            CustomersClient customersService = new CustomersClient();
            // Retrieve DataTable from WCF Service
            countryDataTable = customersService.GetCountries(StartingLettersTextBox.Text);
            // Save DataTable to cache
            Cache["Countries"] = countryDataTable;
        }

        // Set GridView DataSource
        CustomersGridView.DataSource = countryDataTable;

        CustomersGridView.DataBind();
    }
}
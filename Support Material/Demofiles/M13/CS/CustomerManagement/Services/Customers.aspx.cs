using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomersService;

public partial class Services_Customers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void GetCountriesButton_Click(object sender, EventArgs e)
    {
        CustomersClient customersService = new CustomersClient();
        CustomersGridView.DataSource = customersService.GetCountries(StartingLettersTextBox.Text);
        CustomersGridView.DataBind();
    }
}
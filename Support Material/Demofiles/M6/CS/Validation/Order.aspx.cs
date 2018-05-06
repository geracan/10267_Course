using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderDateTextBox.Text = DateTime.Now.ToShortDateString();
    }
    protected void OrderSaveButton_Click(object sender, EventArgs e)
    {

    }
    protected void OrderCancelButton_Click(object sender, EventArgs e)
    {

    }
}
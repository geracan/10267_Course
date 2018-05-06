using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InsertCustomer : System.Web.UI.Page
{
    private CustomerManagementEntities.Customer currentCustomer = null;

    /// <summary>
    /// Instantiates Customer object
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        // Instantiate Customer
        instantiateCustomerObject();
    }

    /// <summary>
    /// Instantiates and populates the Customer member object
    /// </summary>
    private void instantiateCustomerObject()
    {
        // First time loading page?
        if (!this.IsPostBack)
            // Instantiate new Customer object
            currentCustomer = new CustomerManagementEntities.Customer();
        else
            // Instantiate new Customer object with user input
            currentCustomer = new CustomerManagementEntities.Customer(
                null, CustomerNameTextBox.Text, CustomerAddressTextBox.Text,
                CustomerPhoneTextBox.Text, CustomerZipCodeTextBox.Text,
                CustomerCityTextBox.Text, CustomerStateTextBox.Text,
                null, CustomerEmailAddressTextBox.Text, -1, DateTime.Now,
                "", null, "");
    }

    /// <summary>
    /// Populates UI controls
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        // Populate the UI controls
        populateUI();
    }

    /// <summary>
    /// Populates the UI controls with the values in the
    /// current Customer object
    /// </summary>
    private void populateUI()
    {
        CustomerNameTextBox.Text = currentCustomer.Name;
        CustomerAddressTextBox.Text = currentCustomer.Address;
        CustomerPhoneTextBox.Text = currentCustomer.Phone;
        CustomerZipCodeTextBox.Text = currentCustomer.ZipCode;
        CustomerCityTextBox.Text = currentCustomer.City;
        CustomerStateTextBox.Text = currentCustomer.State;
        CustomerEmailAddressTextBox.Text = currentCustomer.EmailAddress;
    }

    /// <summary>
    /// Destroys objects
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Unload(object sender, EventArgs e)
    {
        // Destroy Customer object
        currentCustomer = null;
    }

    /// <summary>
    /// Saves the current customer information and adds default values
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void CustomerInsertButton_Click(object sender, EventArgs e)
    {
        // Add the current user name
        currentCustomer.CreatedBy = Context.User.Identity.Name;
        // Add the user credit limit
        currentCustomer.CreditLimit = 50000;
    }

    /// <summary>
    /// Redirects to home page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void CustomerCancelButton_Click(object sender, EventArgs e)
    {
        // Redirect to home page
        Response.Redirect("~/Default.aspx");
    }
}

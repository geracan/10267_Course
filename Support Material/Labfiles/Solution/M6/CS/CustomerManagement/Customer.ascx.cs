using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customer : System.Web.UI.UserControl
{
    private CustomerManagementEntities.Customer currentCustomer = null;

    /// <summary>
    /// Instantiates Customer object
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            // Validate Page
            Page.Validate();

            // Did page validation succeed?
            if (!Page.IsValid)
                return;
        }

        // Instantiate Customer
        instantiateCustomerObject();
        // Populate the UI controls
        populateUI();
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
        // Did page validation succeed?
        if (!Page.IsValid)
            return;

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
                null, CustomerFirstNameTextBox.Text, CustomerLastNameTextBox.Text,
                CustomerAddressTextBox.Text, CustomerZipCodeTextBox.Text,
                CustomerCityTextBox.Text, CustomerStateTextBox.Text,
                null, CustomerPhoneTextBox.Text, CustomerEmailAddressTextBox.Text,
                CustomerWebAddressTextBox.Text, -1, CustomerNewsSubscriberCheckBox.Checked,
                DateTime.Now, "", null, "");
    }

    /// <summary>
    /// Populates the UI controls with the values in the
    /// current Customer object
    /// </summary>
    private void populateUI()
    {
        CustomerFirstNameTextBox.Text = currentCustomer.FirstName;
        CustomerLastNameTextBox.Text = currentCustomer.LastName;
        CustomerAddressTextBox.Text = currentCustomer.Address;
        CustomerZipCodeTextBox.Text = currentCustomer.ZipCode;
        CustomerCityTextBox.Text = currentCustomer.City;
        CustomerStateTextBox.Text = currentCustomer.State;

        if (currentCustomer.CountryID.HasValue)
            CustomerCountryDropDownList.SelectedValue = currentCustomer.CountryID.Value.ToString();
        else
            CustomerCountryDropDownList.SelectedIndex = -1;

        CustomerPhoneTextBox.Text = currentCustomer.Phone;
        CustomerEmailAddressTextBox.Text = currentCustomer.EmailAddress;
        CustomerWebAddressTextBox.Text = currentCustomer.WebAddress;
        CustomerCreditLimitTextBox.Text = currentCustomer.CreditLimit.ToString();
        CustomerNewsSubscriberCheckBox.Checked = currentCustomer.NewsSubscriber;
    }

}
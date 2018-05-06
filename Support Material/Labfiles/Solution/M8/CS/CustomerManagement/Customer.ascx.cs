using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

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

        // Create and instantiate connection
        using (SqlConnection customerManagementConnection = new SqlConnection())
        {
            // Initialize connection string from web.config
            customerManagementConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["CustomerManagementConnectionString"].ConnectionString;

            // Open connection
            customerManagementConnection.Open();
            // Declare and instantiate data adapter
            SqlDataAdapter customerManagementDataAdapter = new SqlDataAdapter();

            // Declare and instantiate command objects
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Customers",
                customerManagementConnection);
            SqlCommand insertCommand = new SqlCommand(
                "INSERT INTO Customers (FirstName, LastName, Address, ZipCode, City, State, CountryID, Phone, EmailAddress, " +
                "Url, CreditLimit, NewsSubscriber, CreatedDate, CreatedBy) VALUES(@FirstName, @LastName, @Address, @ZipCode, @City, @State, " +
                "@CountryID, @Phone, @EmailAddress, @EmailAddress, @CreditLimit, @NewsSubscriber, @CreatedDate, @CreatedBy)", 
                customerManagementConnection);

            // Assign command objects
            customerManagementDataAdapter.SelectCommand = selectCommand;
            customerManagementDataAdapter.InsertCommand = insertCommand;

            // Declare and instantiate parameter objects
            SqlParameter insertFirstNameParameter = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50, "FirstName");
            SqlParameter insertLastNameParameter = new SqlParameter("@LastName", SqlDbType.NVarChar, 30, "LastName");
            SqlParameter insertAddressParameter = new SqlParameter("@Address", SqlDbType.NVarChar, 50, "Address");
            SqlParameter insertZipCodeParameter = new SqlParameter("@ZipCode", SqlDbType.NVarChar, 10, "ZipCode");
            SqlParameter insertCityParameter = new SqlParameter("@City", SqlDbType.NVarChar, 30, "City");
            SqlParameter insertStateParameter = new SqlParameter("@State", SqlDbType.NVarChar, 30, "State");
            SqlParameter insertCountryIDParameter = new SqlParameter("@CountryID", SqlDbType.UniqueIdentifier, 0, "CountryID");
            SqlParameter insertPhoneParameter = new SqlParameter("@Phone", SqlDbType.VarChar, 30, "Phone");
            SqlParameter insertEmailAddressParameter = new SqlParameter("@EmailAddress", SqlDbType.NVarChar, 50, "EmailAddress");
            SqlParameter insertWebAddressParameter = new SqlParameter("@WebAddress", SqlDbType.NVarChar, 80, "Url");
            SqlParameter insertCreditLimitParameter = new SqlParameter("@CreditLimit", SqlDbType.Int, 0, "CreditLimit");
            SqlParameter insertNewsSubscriberParameter = new SqlParameter("@NewsSubscriber", SqlDbType.Bit, 0, "NewsSubscriber");
            SqlParameter insertCreatedDateParameter = new SqlParameter("@CreatedDate", SqlDbType.SmallDateTime, 0, "CreatedDate");
            SqlParameter insertCreatedByParameter = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 15, "CreatedBy");


            // Assign parameters to command object
            insertCommand.Parameters.Add(insertFirstNameParameter);
            insertCommand.Parameters.Add(insertLastNameParameter);
            insertCommand.Parameters.Add(insertAddressParameter);
            insertCommand.Parameters.Add(insertZipCodeParameter);
            insertCommand.Parameters.Add(insertCityParameter);
            insertCommand.Parameters.Add(insertStateParameter);
            insertCommand.Parameters.Add(insertCountryIDParameter);
            insertCommand.Parameters.Add(insertPhoneParameter);
            insertCommand.Parameters.Add(insertEmailAddressParameter);
            insertCommand.Parameters.Add(insertWebAddressParameter);
            insertCommand.Parameters.Add(insertCreditLimitParameter);
            insertCommand.Parameters.Add(insertNewsSubscriberParameter);
            insertCommand.Parameters.Add(insertCreatedDateParameter);
            insertCommand.Parameters.Add(insertCreatedByParameter);

            // Declare and instantiate dataset
            DataSet customerManagementDataSet = new DataSet("CustomerManagementDataSet");
            // Apply the full schema from the data source
            customerManagementDataAdapter.FillSchema(customerManagementDataSet, SchemaType.Source, "Customers");
            customerManagementDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            customerManagementDataAdapter.MissingMappingAction = MissingMappingAction.Passthrough;
            // Populate Customers DataTable
            customerManagementDataAdapter.Fill(customerManagementDataSet, "Customers");

            // Create new row locally
            DataRow newCustomerDataRow = customerManagementDataSet.Tables["Customers"].NewRow();
            newCustomerDataRow["ID"] = Guid.NewGuid();
            newCustomerDataRow["FirstName"] = currentCustomer.FirstName;
            newCustomerDataRow["LastName"] = currentCustomer.LastName;
            newCustomerDataRow["Address"] = currentCustomer.Address;
            newCustomerDataRow["ZipCode"] = currentCustomer.ZipCode;
            newCustomerDataRow["City"] = currentCustomer.City;
            newCustomerDataRow["State"] = currentCustomer.State;
            newCustomerDataRow["CountryID"] = currentCustomer.CountryID;
            newCustomerDataRow["Phone"] = currentCustomer.Phone;
            newCustomerDataRow["EmailAddress"] = currentCustomer.EmailAddress;
            newCustomerDataRow["Url"] = currentCustomer.EmailAddress;
            newCustomerDataRow["CreditLimit"] = currentCustomer.CreditLimit;
            newCustomerDataRow["NewsSubscriber"] = currentCustomer.NewsSubscriber;
            newCustomerDataRow["CreatedDate"] = currentCustomer.CreatedDate;
            newCustomerDataRow["CreatedBy"] = currentCustomer.CreatedBy;

            // Insert new row locally
            customerManagementDataSet.Tables["Customers"].Rows.Add(newCustomerDataRow);

            // Update data source
            if (customerManagementDataAdapter.Update(customerManagementDataSet, "Customers") == 1)
            {
                // Instantiate new Customer object
                currentCustomer = new CustomerManagementEntities.Customer();
                // Reload page to refresh with "blank" input controls
                Response.Redirect("~/InsertCustomer.aspx");
            }
        }
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
                new Guid(CustomerCountryDropDownList.SelectedValue), CustomerPhoneTextBox.Text,
                CustomerEmailAddressTextBox.Text, CustomerWebAddressTextBox.Text,
                int.Parse(CustomerCreditLimitTextBox.Text), CustomerNewsSubscriberCheckBox.Checked, 
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
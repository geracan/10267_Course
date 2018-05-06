Imports System.Diagnostics
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration

Partial Class Customer
    Inherits System.Web.UI.UserControl

    Private currentCustomer As CustomerManagementEntities.Customer = Nothing

    ''' <summary>
    ''' Instantiates Customer object
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack Then
            ' Validate Page
            Page.Validate()

            ' Did page validation succeed?
            If Not Page.IsValid Then
                Return
            End If
        End If

        ' Instantiate Customer
        instantiateCustomerObject()
        ' Populate the UI controls
        populateUI()
    End Sub

    ''' <summary>
    ''' Populates the UI controls with the values in the
    ''' current Customer object
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub populateUI()
        CustomerFirstNameTextBox.Text = currentCustomer.FirstName
        CustomerLastNameTextBox.Text = currentCustomer.LastName
        CustomerAddressTextBox.Text = currentCustomer.Address
        CustomerZipCodeTextBox.Text = currentCustomer.ZipCode
        CustomerCityTextBox.Text = currentCustomer.City
        CustomerStateTextBox.Text = currentCustomer.State

        If currentCustomer.CountryID.HasValue Then
            CustomerCountryDropDownList.SelectedValue = currentCustomer.CountryID.Value.ToString()
        Else
            CustomerCountryDropDownList.SelectedIndex = -1
        End If

        CustomerPhoneTextBox.Text = currentCustomer.Phone
        CustomerEmailAddressTextBox.Text = currentCustomer.EmailAddress
        CustomerWebAddressTextBox.Text = currentCustomer.WebAddress
        CustomerCreditLimitTextBox.Text = currentCustomer.CreditLimit.ToString()
        CustomerNewsSubscriberCheckBox.Checked = currentCustomer.NewsSubscriber
    End Sub

    ''' <summary>
    ''' Destroys objects
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        ' Destroy Customer object
        currentCustomer = Nothing
    End Sub

    ''' <summary>
    ''' Saves the current customer information and adds default values
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub CustomerInsertButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerInsertButton.Click
        ' Did page validation succeed?
        If Not Page.IsValid Then
            Return
        End If

        ' Add the current user name
        currentCustomer.CreatedBy = Context.User.Identity.Name

        ' Create and instantiate connection
        Using customerManagementConnection As New SqlConnection()
            ' Initialize connection string from web.config
            customerManagementConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings("CustomerManagementConnectionString").ConnectionString

            ' Open connection
            customerManagementConnection.Open()
            ' Declare and instantiate data adapter
            Dim customerManagementDataAdapter As New SqlDataAdapter()

            ' Declare and instantiate command objects
            Dim selectCommand As New SqlCommand("SELECT * FROM Customers",
                customerManagementConnection)
            Dim insertCommand As New SqlCommand(
                "INSERT INTO Customers (FirstName, LastName, Address, ZipCode, City, State, CountryID, Phone, EmailAddress, " &
                "Url, CreditLimit, NewsSubscriber, CreatedDate, CreatedBy) VALUES(@FirstName, @LastName, @Address, @ZipCode, @City, @State, " &
                "@CountryID, @Phone, @EmailAddress, @EmailAddress, @CreditLimit, @NewsSubscriber, @CreatedDate, @CreatedBy)", customerManagementConnection)

            ' Assign command objects
            customerManagementDataAdapter.SelectCommand = selectCommand
            customerManagementDataAdapter.InsertCommand = insertCommand

            ' Declare and instantiate parameter objects
            Dim insertFirstNameParameter As New SqlParameter("@FirstName", SqlDbType.NVarChar, 50, "FirstName")
            Dim insertLastNameParameter As New SqlParameter("@LastName", SqlDbType.NVarChar, 30, "LastName")
            Dim insertAddressParameter As New SqlParameter("@Address", SqlDbType.NVarChar, 50, "Address")
            Dim insertZipCodeParameter As New SqlParameter("@ZipCode", SqlDbType.NVarChar, 10, "ZipCode")
            Dim insertCityParameter As New SqlParameter("@City", SqlDbType.NVarChar, 30, "City")
            Dim insertStateParameter As New SqlParameter("@State", SqlDbType.NVarChar, 30, "State")
            Dim insertCountryIDParameter As New SqlParameter("@CountryID", SqlDbType.UniqueIdentifier, 0, "CountryID")
            Dim insertPhoneParameter As New SqlParameter("@Phone", SqlDbType.VarChar, 30, "Phone")
            Dim insertEmailAddressParameter As New SqlParameter("@EmailAddress", SqlDbType.NVarChar, 50, "EmailAddress")
            Dim insertWebAddressParameter As New SqlParameter("@WebAddress", SqlDbType.NVarChar, 80, "Url")
            Dim insertCreditLimitParameter As New SqlParameter("@CreditLimit", SqlDbType.Int, 0, "CreditLimit")
            Dim insertNewsSubscriberParameter As New SqlParameter("@NewsSubscriber", SqlDbType.Bit, 0, "NewsSubscriber")
            Dim insertCreatedDateParameter As New SqlParameter("@CreatedDate", SqlDbType.SmallDateTime, 0, "CreatedDate")
            Dim insertCreatedByParameter As New SqlParameter("@CreatedBy", SqlDbType.VarChar, 15, "CreatedBy")

            ' Assign parameters to command object
            insertCommand.Parameters.Add(insertFirstNameParameter)
            insertCommand.Parameters.Add(insertLastNameParameter)
            insertCommand.Parameters.Add(insertAddressParameter)
            insertCommand.Parameters.Add(insertZipCodeParameter)
            insertCommand.Parameters.Add(insertCityParameter)
            insertCommand.Parameters.Add(insertStateParameter)
            insertCommand.Parameters.Add(insertCountryIDParameter)
            insertCommand.Parameters.Add(insertPhoneParameter)
            insertCommand.Parameters.Add(insertEmailAddressParameter)
            insertCommand.Parameters.Add(insertWebAddressParameter)
            insertCommand.Parameters.Add(insertCreditLimitParameter)
            insertCommand.Parameters.Add(insertNewsSubscriberParameter)
            insertCommand.Parameters.Add(insertCreatedDateParameter)
            insertCommand.Parameters.Add(insertCreatedByParameter)

            ' Declare and instantiate dataset
            Dim customerManagementDataSet As New DataSet("CustomerManagementDataSet")
            ' Apply the full schema from the data source
            customerManagementDataAdapter.FillSchema(customerManagementDataSet, SchemaType.Source, "Customers")
            customerManagementDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
            customerManagementDataAdapter.MissingMappingAction = MissingMappingAction.Passthrough
            ' Populate Customers DataTable
            customerManagementDataAdapter.Fill(customerManagementDataSet, "Customers")

            ' Create new row locally
            Dim newCustomerDataRow As DataRow = customerManagementDataSet.Tables("Customers").NewRow()
            newCustomerDataRow("ID") = Guid.NewGuid()
            newCustomerDataRow("FirstName") = currentCustomer.FirstName
            newCustomerDataRow("LastName") = currentCustomer.LastName
            newCustomerDataRow("Address") = currentCustomer.Address
            newCustomerDataRow("ZipCode") = currentCustomer.ZipCode
            newCustomerDataRow("City") = currentCustomer.City
            newCustomerDataRow("State") = currentCustomer.State
            newCustomerDataRow("CountryID") = currentCustomer.CountryID
            newCustomerDataRow("Phone") = currentCustomer.Phone
            newCustomerDataRow("EmailAddress") = currentCustomer.EmailAddress
            newCustomerDataRow("Url") = currentCustomer.EmailAddress
            newCustomerDataRow("CreditLimit") = currentCustomer.CreditLimit
            newCustomerDataRow("NewsSubscriber") = currentCustomer.NewsSubscriber
            newCustomerDataRow("CreatedDate") = currentCustomer.CreatedDate
            newCustomerDataRow("CreatedBy") = currentCustomer.CreatedBy

            ' Insert new row locally
            customerManagementDataSet.Tables("Customers").Rows.Add(newCustomerDataRow)

            ' Update data source
            If customerManagementDataAdapter.Update(customerManagementDataSet, "Customers") = 1 Then
                ' Instantiate new Customer object
                currentCustomer = New CustomerManagementEntities.Customer()
                ' Reload page to refresh with "blank" input controls
                Response.Redirect("~/InsertCustomer.aspx")
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Redirects to home page
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub CustomerCancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerCancelButton.Click
        ' Redirect to home page
        Response.Redirect("~/Default.aspx")
    End Sub


    ''' <summary>
    ''' Instantiates and populates the Customer member object
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub instantiateCustomerObject()
        ' First time loading page?
        If Not Me.IsPostBack Then
            ' Instantiate new Customer object
            currentCustomer = New CustomerManagementEntities.Customer()
        Else
            ' Instantiate new Customer object with user input
            currentCustomer = New CustomerManagementEntities.Customer(
                Nothing, CustomerFirstNameTextBox.Text, CustomerLastNameTextBox.Text,
                CustomerAddressTextBox.Text, CustomerZipCodeTextBox.Text, CustomerCityTextBox.Text,
                CustomerStateTextBox.Text, New Guid(CustomerCountryDropDownList.SelectedValue), CustomerPhoneTextBox.Text,
                CustomerEmailAddressTextBox.Text, CustomerWebAddressTextBox.Text, CustomerNewsSubscriberCheckBox.Checked,
                Integer.Parse(CustomerCreditLimitTextBox.Text), DateTime.Now, "", Nothing, "")
        End If
    End Sub
End Class
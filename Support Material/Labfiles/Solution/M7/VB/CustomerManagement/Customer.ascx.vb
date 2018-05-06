Imports System.Diagnostics

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
            Debug.WriteLine("Page Postback detected in Page_Load")

            ' Validate Page
            Page.Validate()

            ' Did page validation succeed?
            If Not Page.IsValid Then
                Return
            End If
        End If

        Debug.WriteLineIf(Not Page.IsPostBack, "No Page Postback detected in Page_Load")

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

        Debug.WriteLine("UI controls have been populated")
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

        Debug.WriteLine("Page has been unloaded")
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
        ' Add the user credit limit
        currentCustomer.CreditLimit = 50000

        Debug.WriteLine("Customer has been inserted in CustomerInsertButton_Click")
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
                CustomerStateTextBox.Text, Nothing, CustomerPhoneTextBox.Text,
                CustomerEmailAddressTextBox.Text, CustomerWebAddressTextBox.Text,
                Integer.Parse(CustomerCreditLimitTextBox.Text), CustomerNewsSubscriberCheckBox.Checked,
                DateTime.Now, "", Nothing, "")
        End If

        Debug.WriteLine("Customer object has been instantiated")
    End Sub
End Class
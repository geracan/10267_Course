
Partial Class InsertCustomer
    Inherits System.Web.UI.Page

    Private currentCustomer As CustomerManagementEntities.Customer = Nothing

    ''' <summary>
    ''' Saves the current customer information and adds default values
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub customerInsertButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerInsertButton.Click
        ' Add the current user name
        currentCustomer.CreatedBy = Context.User.Identity.Name
        ' Add the user credit limit
        currentCustomer.CreditLimit = 50000
    End Sub

    ''' <summary>
    ''' Redirects to home page
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub customerCancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerCancelButton.Click
        ' Redirect to home page
        Response.Redirect("~/Default.aspx")
    End Sub


    ''' <summary>
    ''' Instantiates Customer object
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Instantiate Customer
        instantiateCustomerObject()
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
            currentCustomer = New CustomerManagementEntities.Customer( _
                Nothing, CustomerNameTextBox.Text, CustomerAddressTextBox.Text, _
                CustomerPhoneTextBox.Text, CustomerZipCodeTextBox.Text, _
                CustomerCityTextBox.Text, CustomerStateTextBox.Text, _
                Nothing, CustomerEmailAddressTextBox.Text, -1, DateTime.Now, _
                "", Nothing, "")
        End If
    End Sub

    ''' <summary>
    ''' Populates UI controls
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete
        ' Populate the UI controls
        populateUI()
    End Sub

    ''' <summary>
    ''' Populates the UI controls with the values in the
    ''' current Customer object
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub populateUI()
        CustomerNameTextBox.Text = currentCustomer.Name
        CustomerAddressTextBox.Text = currentCustomer.Address
        CustomerPhoneTextBox.Text = currentCustomer.Phone
        CustomerZipCodeTextBox.Text = currentCustomer.ZipCode
        CustomerCityTextBox.Text = currentCustomer.City
        CustomerStateTextBox.Text = currentCustomer.State
        CustomerEmailAddressTextBox.Text = currentCustomer.EmailAddress
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
End Class

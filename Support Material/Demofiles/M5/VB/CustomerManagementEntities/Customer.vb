Public Class Customer
    Private customerID As Guid?
    Private customerName As String = Nothing
    Private customerAddress As String = Nothing
    Private customerPhone As String = Nothing
    Private customerZipCode As String = Nothing
    Private customerCity As String = Nothing
    Private customerState As String = Nothing
    Private customerCountryID? As Guid = Nothing
    Private customerEmailAddress As String = Nothing
    Private customerCreditLimit As Integer = 0
    Private customerCreatedDate? As DateTime = Nothing
    Private customerCreatedBy As String = Nothing
    Private customerModifiedDate? As DateTime = Nothing
    Private customerModifiedBy As String = Nothing

    ''' <summary>
    ''' The unique customer ID
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ID() As Guid?
        Get
            Return Me.customerID
        End Get
        Private Set(ByVal value As Guid?)
            Me.customerID = value
        End Set
    End Property

    ''' <summary>
    ''' The full customer name
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Name() As String
        Get
            Return Me.customerName
        End Get
        Set(ByVal value As String)
            ' Null value?
            If value Is Nothing Then
                Me.customerName = ""
            Else
                ' Only get the first 50 characters
                If (value.Length > 50) Then
                    Me.customerName = value.Substring(0, 50)
                Else
                    Me.customerName = value
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' The customer address, including street name, house number and floor
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Address() As String
        Get
            Return Me.customerAddress
        End Get
        Set(ByVal value As String)
            ' Null value?
            If value Is Nothing Then
                Me.customerAddress = ""
            Else
                ' Only get the first 50 characters
                If (value.Length > 50) Then
                    Me.customerAddress = value.Substring(0, 50)
                Else
                    Me.customerAddress = value
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' The customer phone number
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Phone() As String
        Get
            Return Me.customerPhone
        End Get
        Set(ByVal value As String)
            ' Null value?
            If value Is Nothing Then
                Me.customerPhone = ""
            Else
                ' Only get the first 30 characters
                If (value.Length > 30) Then
                    Me.customerPhone = value.Substring(0, 30)
                Else
                    Me.customerPhone = value
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' The customer zip code or postal code
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ZipCode() As String
        Get
            Return Me.customerZipCode
        End Get
        Set(ByVal value As String)
            ' Null value?
            If value Is Nothing Then
                Me.customerZipCode = ""
            Else
                ' Only get the first 10 characters
                If (value.Length > 10) Then
                    Me.customerZipCode = value.Substring(0, 10)
                Else
                    Me.customerZipCode = value
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' The name of the city in which the customer lives
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property City() As String
        Get
            Return Me.customerCity
        End Get
        Set(ByVal value As String)
            ' Null value?
            If value Is Nothing Then
                Me.customerCity = ""
            Else
                ' Only get the first 30 characters
                If (value.Length > 30) Then
                    Me.customerCity = value.Substring(0, 30)
                Else
                    Me.customerCity = value
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' The name of the state or region in which the customer lives
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property State() As String
        Get
            Return Me.customerState
        End Get
        Set(ByVal value As String)
            ' Null value?
            If value Is Nothing Then
                Me.customerState = ""
            Else
                ' Only get the first 30 characters
                If (value.Length > 30) Then
                    Me.customerState = value.Substring(0, 30)
                Else
                    Me.customerState = value
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' The ID of the country in which the customer lives
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CountryID() As Guid?
        Get
            Return Me.customerCountryID
        End Get
        Set(ByVal value As Guid?)
            Me.customerCountryID = value
        End Set
    End Property

    ''' <summary>
    ''' The customer e-mail address
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property EmailAddress() As String
        Get
            Return Me.customerEmailAddress
        End Get
        Set(ByVal value As String)
            If (value Is Nothing) Then
                Me.customerEmailAddress = ""
            Else
                ' Only get the first 40 characters
                If (value.Length > 40) Then
                    Me.customerEmailAddress = value.Substring(0, 40)
                Else
                    Me.customerEmailAddress = value
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' The current credit limit of the customer
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CreditLimit() As Integer
        Get
            Return Me.customerCreditLimit
        End Get
        Set(ByVal value As Integer)
            ' Negative value?
            If value < 0 Then
                Me.customerCreditLimit = 0
            Else
                Me.customerCreditLimit = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The date the customer was created in the system
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CreatedDate() As DateTime?
        Get
            Return Me.customerCreatedDate
        End Get
        Private Set(ByVal value As DateTime?)
            ' Date in the past?
            If (value < DateTime.Now) Then
                Me.customerCreatedDate = DateTime.Now
            Else
                Me.customerCreatedDate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The name of the user creating the customer
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CreatedBy() As String
        Get
            Return Me.customerCreatedBy
        End Get
        Set(ByVal value As String)
            ' Null value?
            If value Is Nothing Then
                Me.customerCreatedBy = ""
            Else
                ' Only get the first 15 characters
                If (value.Length > 15) Then
                    Me.customerCreatedBy = value.Substring(0, 15)
                Else
                    Me.customerCreatedBy = value
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' The date the customer was last modified in the system
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ModifiedDate() As DateTime?
        Get
            Return Me.customerModifiedDate
        End Get
        Set(ByVal value As DateTime?)
            ' Date in the past?
            If value < DateTime.Now Then
                Me.customerModifiedDate = DateTime.Now
            Else
                Me.customerModifiedDate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The name of the user who last modified the customer
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ModifiedBy() As String
        Get
            Return Me.customerModifiedBy
        End Get
        Set(ByVal value As String)
            ' Null value?
            If value Is Nothing Then
                Me.customerModifiedBy = ""
            Else
                ' Only get the first 15 characters
                If (value.Length > 15) Then
                    Me.customerModifiedBy = value.Substring(0, 15)
                Else
                    Me.customerModifiedBy = value
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' Default parameterless constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        ' Initialize member backing fields with default values
        Me.ID = Guid.NewGuid()
        Me.CreatedDate = DateTime.Now
    End Sub

    Public Sub New(ByVal id As Guid?)
        ' Initialize member backing fields with 
        ' passed and default values
        Me.ID = id
        Me.CreatedDate = DateTime.Now
    End Sub

    ''' <summary>
    ''' Initializes with a value for all backing fields 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="name"></param>
    ''' <param name="address"></param>
    ''' <param name="phone"></param>
    ''' <param name="zipCode"></param>
    ''' <param name="city"></param>
    ''' <param name="state"></param>
    ''' <param name="countryID"></param>
    ''' <param name="emailAddress"></param>
    ''' <param name="creditLimit"></param>
    ''' <param name="createdDate"></param>
    ''' <param name="createdBy"></param>
    ''' <param name="modifiedDate"></param>
    ''' <param name="modifiedBy"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal id As Guid?, ByVal name As String, ByVal address As String, _
        ByVal phone As String, ByVal zipCode As String, ByVal city As String, _
        ByVal state As String, ByVal countryID As Guid?, ByVal emailAddress As String, _
        ByVal creditLimit As Integer, ByVal createdDate As DateTime?, _
        ByVal createdBy As String, ByVal modifiedDate As DateTime?, ByVal modifiedBy As String)

        ' Initialize member backing fields with passed values
        Me.ID = id
        Me.CreatedDate = createdDate
        Me.Name = name
        Me.Address = address
        Me.Phone = phone
        Me.ZipCode = zipCode
        Me.City = city
        Me.State = state
        Me.CountryID = countryID
        Me.EmailAddress = emailAddress
        Me.CreditLimit = creditLimit
        Me.CreatedDate = createdDate
        Me.CreatedBy = createdBy
        Me.ModifiedDate = modifiedDate
        Me.ModifiedBy = modifiedBy
    End Sub
End Class
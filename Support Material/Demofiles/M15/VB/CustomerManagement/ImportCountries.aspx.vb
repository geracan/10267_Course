Imports System.Xml.Linq

Partial Class ImportCountries
    Inherits System.Web.UI.Page

    Private Shared countriesWithPhNoFormat As IEnumerable(Of XElement) = Nothing

    Protected Sub FilterButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FilterButton.Click
        Dim countries As XElement = loadCountries("Countries.xml")
        countriesWithPhNoFormat = filterCountries(countries)
        String.Join("", countriesWithPhNoFormat.Select(Function(x) x.ToString()).ToArray())
        CountriesXmlDataSource.Data = buildXmlString(countriesWithPhNoFormat)
        CountriesXmlDataSource.DataFile = ""
    End Sub

    Private Function loadCountries(ByVal fileName As String) As XElement
        Return XElement.Load(Server.MapPath(fileName))
    End Function

    Private Function filterCountries(ByVal countries As XElement) As IEnumerable(Of XElement)
        Return _
            From c In countries.Elements()
            Where Not String.IsNullOrEmpty(c.Attribute("PhoneNoFormat"))
            Select c
    End Function

    Private Function buildXmlString(ByVal countriesWithPhNoFormat As IEnumerable(Of XElement)) As String
        Return "<Countries>" & String.Join("", countriesWithPhNoFormat.Select(Function(x) x.ToString()).ToArray()) & "</Countries>"
    End Function

    Protected Sub SaveButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        saveCountries(countriesWithPhNoFormat)
    End Sub

    Private Sub saveCountries(ByVal countriesWithPhNoFormat As IEnumerable(Of XElement))
        Dim cmObjectContext As New CustomerManagementModel.Entities(
            System.Web.Configuration.WebConfigurationManager.
            ConnectionStrings("Entities").ConnectionString)

        ' Loop through the filtered countries
        For Each country As XElement In countriesWithPhNoFormat
            ' Add the new country to the Countries collection
            cmObjectContext.Countries.AddObject(New CustomerManagementModel.Country With
            {
                .ID = New Guid(country.Attribute("ID").Value),
                .Name = country.Attribute("Name").Value,
                .PhoneNoFormat = country.Attribute("PhoneNoFormat").Value,
                .DialingCountryCode = country.Attribute("DialingCountryCode").Value,
                .InternationalDialingCode = country.Attribute("InternationalDialingCode").Value,
                .InternetTLD = country.Attribute("InternetTLD").Value
            })
        Next

        ' Save to database
        Try
            cmObjectContext.SaveChanges()

            ' Display success message
            ImportResultLabel.Text = "Rows successfully exported to SQL Server table."
        Catch ex As System.Data.UpdateException
            ' Display error
            ImportResultLabel.Text = "An error occurred exporting to SQL Server.<br/>One or more of the rows already exist in the table.<br/><br/>"
            ImportResultLabel.ForeColor = System.Drawing.Color.Red
        Catch ex As Exception
            ' Display error
            ImportResultLabel.Text = "An error occurred exporting to SQL Server.<br/>" & ex.Message & "<br/><br/>"
            ImportResultLabel.ForeColor = System.Drawing.Color.Red
        Finally
            cmObjectContext.Dispose()
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Check if key exists in web.config
        If Not System.Web.Configuration.WebConfigurationManager.AppSettings("EnableSaveImportedCountries") Is Nothing Then
            ' Get enable save countries value from configuration file
            Dim enableSaveCountries As Boolean = CType(
                System.Web.Configuration.WebConfigurationManager.AppSettings("EnableSaveImportedCountries").ToLower() = "true", Boolean)
            ' Enable/disable SaveButton
            SaveButton.Enabled = enableSaveCountries
        End If
    End Sub
End Class
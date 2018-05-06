using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ImportCountries : System.Web.UI.Page
{
    static private IEnumerable<XElement> countriesWithPhNoFormat = null;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void FilterButton_Click(object sender, EventArgs e)
    {
        XElement countries = loadCountries("Countries.xml");
        countriesWithPhNoFormat = filterCountries(countries);
        CountriesXmlDataSource.Data = buildXmlString(countriesWithPhNoFormat);
        CountriesXmlDataSource.DataFile = "";
    }

    private XElement loadCountries(string fileName)
    {
        return XElement.Load(Server.MapPath(fileName));
    }

    private IEnumerable<XElement> filterCountries(XElement countries)
    {
        return
            from c in countries.Elements()
            where c.Attribute("PhoneNoFormat") != null &&
            (string)c.Attribute("PhoneNoFormat").Value != ""
            select c;

    }

    private string buildXmlString(IEnumerable<XElement> countriesWithPhNoFormat)
    {
        return "<Countries>" + string.Join("", countriesWithPhNoFormat.Select(x => x.ToString()).ToArray()) + "</Countries>";
    }

    protected void SaveButton_Click(object sender, EventArgs e)
    {
        saveCountries(countriesWithPhNoFormat);
    }

    private void saveCountries(IEnumerable<XElement> countriesWithPhNoFormat)
    {
        CustomerManagementModel.Entities cmObjectContext = new CustomerManagementModel.Entities(
            System.Web.Configuration.WebConfigurationManager.
            ConnectionStrings["Entities"].ConnectionString);

        // Loop through the filtered countries
        foreach (XElement country in countriesWithPhNoFormat)
        {
            // Add the new country to the Countries collection
            cmObjectContext.Countries.AddObject(new CustomerManagementModel.Country
            {
                ID = new Guid(country.Attribute("ID").Value),
                Name = country.Attribute("Name").Value,
                PhoneNoFormat = country.Attribute("PhoneNoFormat").Value,
                DialingCountryCode = country.Attribute("DialingCountryCode").Value,
                InternationalDialingCode = country.Attribute("InternationalDialingCode").Value,
                InternetTLD = country.Attribute("InternetTLD").Value
            });
        }

        // Save to database
        try
        {
            cmObjectContext.SaveChanges();
            // Display success message
            ImportResultLabel.Text = "Rows successfully exported to SQL Server table.";
        }
        catch (System.Data.UpdateException)
        {
            // Display error
            ImportResultLabel.Text = "An error occurred exporting to SQL Server.<br/>One or more of the rows already exist in the table.<br/><br/>";
            ImportResultLabel.ForeColor = System.Drawing.Color.Red;
        }
        catch (Exception ex)
        {
            // Display error
            ImportResultLabel.Text = "An error occurred exporting to SQL Server.<br/>" + ex.Message + "<br/><br/>";
            ImportResultLabel.ForeColor = System.Drawing.Color.Red;
        }
        finally
        {
            cmObjectContext.Dispose();
        }

    }

}
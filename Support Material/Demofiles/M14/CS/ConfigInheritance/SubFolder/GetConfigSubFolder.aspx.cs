using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SubFolder_GetConfigSubFolder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get counter from configuration file
        int counter = int.Parse(
            System.Web.Configuration.WebConfigurationManager.AppSettings["Counter"]);

        Response.Write("Counter value retrieved from web.config = " + counter.ToString());

    }
}
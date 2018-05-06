using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        long numVisitors = 0;

        // Check if Application variable exists
        if (Application["Visitors"] != null)
        {
            numVisitors = long.Parse(Application["Visitors"].ToString());
        }

        visitorLiteral.Text = "Number of visitors: " + numVisitors.ToString();
    }
}

<%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>

<script RunAt="server">
    private static MetaModel defaultModel = new MetaModel();

    public static MetaModel DefaultMetaModel
    {
        get
        {
            return defaultModel;
        }
    }

    public static void Register(RouteCollection routes)
    {
        DefaultMetaModel.RegisterContext(typeof(CustomerManagementModel.Entities), new ContextConfiguration()
        {
            ScaffoldAllTables = false
        });

        routes.Add(new DynamicDataRoute("{table}/{action}.aspx")
        {
            Constraints = new RouteValueDictionary(new
            {
                action = "List|Details|Edit|Insert"
            }),
            Model = DefaultMetaModel
        });
    }

    void Application_Start(object sender, EventArgs e)
    {
        Register(RouteTable.Routes);
        long numVisitors = 0;

        // Check if key exists in web.config
        if (System.Web.Configuration.WebConfigurationManager.AppSettings["VisitorCounter"] != null)
        {
            // Get visitor counter from configuration file
            numVisitors = long.Parse(
                System.Web.Configuration.WebConfigurationManager.AppSettings["VisitorCounter"]);
        }

        // Save application variable
        Application["Visitors"] = numVisitors;
    }

    void Application_End(object sender, EventArgs e)
    {
        // Get configuration instance
        System.Configuration.Configuration mainConfiguration =
            System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~/");

        // Check if key exists in web.config
        if (System.Web.Configuration.WebConfigurationManager.AppSettings["VisitorCounter"] == null)
        {
            // Save new key and value
            mainConfiguration.AppSettings.Settings.Add(new KeyValueConfigurationElement("VisitorCounter",
                Application["Visitors"] == null ? "0" : Application["Visitors"].ToString()));
        }
        else
        {
            // Save new value
            mainConfiguration.AppSettings.Settings["VisitorCounter"].Value =
                Application["Visitors"] == null ? "0" : Application["Visitors"].ToString();
        }

        // Save to file
        mainConfiguration.Save();
    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Increment Visitors counter
        Application["Visitors"] =
            long.Parse(Application["Visitors"].ToString()) + 1;
    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>

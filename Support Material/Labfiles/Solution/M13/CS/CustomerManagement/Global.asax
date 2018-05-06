<%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

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
            ScaffoldAllTables = true
        });

        routes.Add(new DynamicDataRoute("{table}/{action}.aspx")
        {
            Constraints = new RouteValueDictionary(new { action = "List|Details|Edit|Insert" }),
            Model = DefaultMetaModel
        });

    }

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        Register(RouteTable.Routes);
        // Save application variable
        Application["Visitors"] = 0;

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started
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

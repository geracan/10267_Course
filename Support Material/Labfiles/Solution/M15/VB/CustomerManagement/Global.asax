<%@ Application Language="VB" %>
<%@ Import Namespace="System.Web.Routing" %>
<script RunAt="server">
    Private Shared defaultModel As New MetaModel()
    
    Public Shared ReadOnly Property DefaultMetaModel As MetaModel
        Get
            Return defaultModel
        End Get
    End Property

    Public Shared Sub Register(ByVal routes As RouteCollection)
        DefaultMetaModel.RegisterContext(GetType(CustomerManagementModel.Entities), New ContextConfiguration() With {
                .ScaffoldAllTables = True
        })
        
        routes.Add(New DynamicDataRoute("{table}/{action}.aspx") With {
            .Constraints = New RouteValueDictionary(New With {.Action = "List|Details|Edit|Insert"}),
            .Model = DefaultMetaModel
        })
    End Sub

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application startup
        Register(RouteTable.Routes)

        Dim numVisitors As Long = 0

        ' Check if key exists in web.config
        If Not System.Web.Configuration.WebConfigurationManager.AppSettings("VisitorCounter") Is Nothing Then
            ' Get visitor counter from configuration file
            numVisitors = Long.Parse(
                System.Web.Configuration.WebConfigurationManager.AppSettings("VisitorCounter"))
        End If

        ' Save application variable
        Application("Visitors") = numVisitors
    End Sub
    
    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application shutdown
        ' Get configuration instance
        Dim mainConfiguration As System.Configuration.Configuration =
            System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~/")

        ' Check if key exists in web.config
        If System.Web.Configuration.WebConfigurationManager.AppSettings("VisitorCounter") Is Nothing Then
            ' Save new key and value
            mainConfiguration.AppSettings.Settings.Add(New KeyValueConfigurationElement("VisitorCounter", _
                IIf(Application("Visitors") Is Nothing, "0", Application("Visitors").ToString())))
        Else
            ' Save new value
            mainConfiguration.AppSettings.Settings("VisitorCounter").Value = _
                IIf(Application("Visitors") Is Nothing, "0", Application("Visitors").ToString())
        End If

        ' Save to file
        mainConfiguration.Save()
    End Sub
        
    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when an unhandled error occurs
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a new session is started
        ' Increment Visitors counter
        Application("Visitors") =
            Long.Parse(Application("Visitors").ToString()) + 1

    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a session ends. 
        ' Note: The Session_End event is raised only when the sessionstate mode
        ' is set to InProc in the Web.config file. If session mode is set to StateServer 
        ' or SQLServer, the event is not raised.
    End Sub
       
</script>

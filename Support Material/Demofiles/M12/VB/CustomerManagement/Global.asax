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
            .ScaffoldAllTables = False
        })

        routes.Add(New DynamicDataRoute("{table}/{action}.aspx") With {
            .Constraints = New RouteValueDictionary(New With {.Action = "List|Details|Edit|Insert"}),
            .Model = DefaultMetaModel
        })
    End Sub

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        Register(RouteTable.Routes)
    End Sub
    
    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application shutdown
    End Sub
        
    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when an unhandled error occurs
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a new session is started
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a session ends. 
        ' Note: The Session_End event is raised only when the sessionstate mode
        ' is set to InProc in the Web.config file. If session mode is set to StateServer 
        ' or SQLServer, the event is not raised.
    End Sub
       
</script>

Imports System.Data.Services
Imports System.Data.Services.Common
Imports System.Linq
Imports System.ServiceModel.Web

Public Class CustomersWcfDS
    Inherits DataService(Of CustomerManagementModel.Entities)

    ' This method is called only once to initialize service-wide policies.
    Public Shared Sub InitializeService(ByVal config As DataServiceConfiguration)
        config.SetEntitySetAccessRule("Countries", EntitySetRights.AllRead)
        config.SetEntitySetAccessRule("Customers", EntitySetRights.AllRead)
        config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2
    End Sub

End Class

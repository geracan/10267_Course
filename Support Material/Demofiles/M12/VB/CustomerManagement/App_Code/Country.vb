Imports Microsoft.VisualBasic
Imports System.ComponentModel.DataAnnotations

Namespace CustomerManagementModel
    <ScaffoldTable(True)>
    Public Class CountryMetadata
        <ScaffoldColumn(False)>
        Public Property ID As Object
    End Class

    <MetadataType(GetType(CountryMetadata))>
    Partial Public Class Country

    End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System.ComponentModel.DataAnnotations

Namespace CustomerManagementModel
    <ScaffoldTable(True)>
    Public Class CustomerMetadata
        <ScaffoldColumn(False)>
        Public Property ID As Object
        <ScaffoldColumn(False)>
        Public Property CreatedDate As Object
        <ScaffoldColumn(False)>
        Public Property CreatedBy As Object
        <ScaffoldColumn(False)>
        Public Property ModifiedDate As Object
        <ScaffoldColumn(False)>
        Public Property ModifiedBy As Object
    End Class

    <MetadataType(GetType(CustomerMetadata))>
    Partial Public Class Customer

    End Class
End Namespace
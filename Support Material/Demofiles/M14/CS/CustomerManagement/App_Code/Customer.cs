using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManagementModel
{
    [ScaffoldTable(true)]
    public class CustomerMetadata
    {
        [ScaffoldColumn(false)]
        public object ID;
        [ScaffoldColumn(false)]
        public object CreatedDate;
        [ScaffoldColumn(false)]
        public object CreatedBy;
        [ScaffoldColumn(false)]
        public object ModifiedDate;
        [ScaffoldColumn(false)]
        public object ModifiedBy;
    }

    /// <summary>
    /// Summary description for Customer
    /// </summary>
    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customer
    {

    }
}
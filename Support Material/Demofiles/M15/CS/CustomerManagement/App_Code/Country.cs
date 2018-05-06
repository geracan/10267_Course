using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManagementModel
{
    [ScaffoldTable(true)]
    public class CountryMetadata
    {
        [ScaffoldColumn(false)]
        public object ID;
    }

    /// <summary>
    /// Summary description for Country
    /// </summary>
    [MetadataType(typeof(CountryMetadata))]
    public partial class Country
    {
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Arcgis.Directions.Orm
{
    using System.Collections.Generic;

    public partial class FM_IMAGES
    {
        public FM_IMAGES()
        {
            this.FM_CUST_GRP = new HashSet<FM_CUST_GRP>();
        }
    
        public int IMAGE_ID { get; set; }
        public byte[] GRP_IMAGE { get; set; }
        public string IMAGE_DESC { get; set; }
    
        public virtual ICollection<FM_CUST_GRP> FM_CUST_GRP { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LvType
    {
        public LvType()
        {
            this.LvApplications = new HashSet<LvApplication>();
            this.LvDatas = new HashSet<LvData>();
        }
    
        public string LvType1 { get; set; }
        public string LvDesc { get; set; }
        public string FldName { get; set; }
        public bool HalfLeave { get; set; }
        public string HalfLvCode { get; set; }
        public string HalfAbCode { get; set; }
        public byte MaxDays { get; set; }
        public bool UpdateBalance { get; set; }
        public Nullable<bool> Enable { get; set; }
        public Nullable<bool> CarryForward { get; set; }
        public Nullable<bool> CountVacDays { get; set; }
    
        public virtual ICollection<LvApplication> LvApplications { get; set; }
        public virtual ICollection<LvData> LvDatas { get; set; }
    }
}

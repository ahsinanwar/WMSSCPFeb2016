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
    
    public partial class AttProcessorScheduler
    {
        public int AttProcesserSchedulerID { get; set; }
        public System.DateTime WhenToProcess { get; set; }
        public string PeriodTag { get; set; }
        public System.DateTime DateFrom { get; set; }
        public System.DateTime DateTo { get; set; }
        public short CompanyID { get; set; }
        public short LocationID { get; set; }
        public Nullable<bool> ProcessingDone { get; set; }
        public string Criteria { get; set; }
        public Nullable<bool> ProcessCat { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> EmpID { get; set; }
        public string EmpNo { get; set; }
    
        public virtual User User { get; set; }
    }
}

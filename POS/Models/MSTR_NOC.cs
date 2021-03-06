//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MSTR_NOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTR_NOC()
        {
            this.NOC_Details = new HashSet<NOC_Details>();
        }
    
        public int NocApplicationID { get; set; }
        public string FlightType { get; set; }
        public string FlightFor { get; set; }
        public string NocName { get; set; }
        public string PostFlightReportEmails { get; set; }
        public string SMSNumbers { get; set; }
        public int AccountID { get; set; }
        public int CreateBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int CountApproved { get; set; }
        public int CountRejected { get; set; }
        public int CountNew { get; set; }
        public int CountTotal { get; set; }
        public int CountAmended { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOC_Details> NOC_Details { get; set; }
    }
}

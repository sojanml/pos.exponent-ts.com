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
    
    public partial class PayloadDataGridLines
    {
        public long ID { get; set; }
        public string FlightUniqueID { get; set; }
        public string RowOrCol { get; set; }
        public decimal SLat { get; set; }
        public decimal SLng { get; set; }
        public decimal ELat { get; set; }
        public decimal ELng { get; set; }
    }
}

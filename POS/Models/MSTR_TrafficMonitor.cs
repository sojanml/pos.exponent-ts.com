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
    
    public partial class MSTR_TrafficMonitor
    {
        public int MonitorID { get; set; }
        public string UniqueID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> FlightID { get; set; }
        public int DD { get; set; }
        public int DR { get; set; }
        public int DU { get; set; }
        public int DL { get; set; }
        public int RD { get; set; }
        public int RR { get; set; }
        public int RU { get; set; }
        public int RL { get; set; }
        public int UD { get; set; }
        public int UR { get; set; }
        public int UU { get; set; }
        public int UL { get; set; }
        public int LD { get; set; }
        public int LR { get; set; }
        public int LU { get; set; }
        public int LL { get; set; }
    }
}
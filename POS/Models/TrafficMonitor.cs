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
    
    public partial class TrafficMonitor
    {
        public int TrafficMonitorID { get; set; }
        public int DroneID { get; set; }
        public int FrameNumber { get; set; }
        public decimal FrameTime { get; set; }
        public int FrameVehicle { get; set; }
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
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public int FlightID { get; set; }
        public string UniqueID { get; set; }
    }
}

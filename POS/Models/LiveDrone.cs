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
    
    public partial class LiveDrone
    {
        public int ID { get; set; }
        public Nullable<int> DroneID { get; set; }
        public string DroneHex { get; set; }
        public Nullable<double> LastLatitude { get; set; }
        public Nullable<double> LastLongitude { get; set; }
    }
}

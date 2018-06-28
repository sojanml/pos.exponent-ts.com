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
    
    public partial class PayLoadData
    {
        public int PayLoadDataID { get; set; }
        public string FlightUniqueID { get; set; }
        public Nullable<int> DroneId { get; set; }
        public string RFID { get; set; }
        public string ProductQrCode { get; set; }
        public Nullable<int> RSSI { get; set; }
        public Nullable<System.DateTime> ReadTime { get; set; }
        public Nullable<int> ReadCount { get; set; }
        public Nullable<int> ReadFreq { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<System.DateTime> GPSTime { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<int> FlightID { get; set; }
        public Nullable<int> GPSFix { get; set; }
        public Nullable<int> YardID { get; set; }
        public Nullable<int> ProcessingModel { get; set; }
        public Nullable<bool> IsProcessed { get; set; }
        public Nullable<int> RowNumber { get; set; }
        public Nullable<int> ColumnNumber { get; set; }
        public Nullable<int> CellID { get; set; }
    }
}
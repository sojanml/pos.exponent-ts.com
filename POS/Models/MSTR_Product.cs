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
    
    public partial class MSTR_Product
    {
        public int ProductId { get; set; }
        public string RFID { get; set; }
        public string DecimalCode { get; set; }
        public string BinaryCode { get; set; }
        public Nullable<bool> IsAssigned { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> RecordType { get; set; }
        public string Product_Name { get; set; }
        public Nullable<int> SerialNo { get; set; }
        public Nullable<int> AccountId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public System.DateTime LastReadTime { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string VIN { get; set; }
        public string CarMake { get; set; }
        public string Model { get; set; }
        public Nullable<int> Year { get; set; }
        public string Color { get; set; }
        public string SlotNo { get; set; }
    }
}
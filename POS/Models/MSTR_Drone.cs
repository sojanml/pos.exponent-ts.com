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
    
    public partial class MSTR_Drone
    {
        public int DroneId { get; set; }
        public Nullable<int> AccountID { get; set; }
        public Nullable<int> ManufactureId { get; set; }
        public Nullable<int> UavTypeId { get; set; }
        public Nullable<int> PartsGroupId { get; set; }
        public string DroneName { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
        public string DroneIdBitString { get; set; }
        public Nullable<int> RecordType { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string DroneIdHexa { get; set; }
        public string DroneIdBarCode { get; set; }
        public Nullable<System.DateTime> CommissionDate { get; set; }
        public Nullable<int> DroneSerialNo { get; set; }
        public Nullable<int> DroneDefinitionID { get; set; }
        public Nullable<System.DateTime> DecommissionDate { get; set; }
        public Nullable<int> DecommissionBy { get; set; }
        public string DecommissionNote { get; set; }
        public Nullable<System.DateTime> ReAssignDate { get; set; }
        public Nullable<int> ReAssignBy { get; set; }
        public string ReAssignNote { get; set; }
        public Nullable<int> ReAssignTo { get; set; }
        public Nullable<int> ReAssignFrom { get; set; }
        public string CommissionReportNote { get; set; }
        public string UATReportNote { get; set; }
        public string IncidentReportNote { get; set; }
        public string ModelName { get; set; }
        public Nullable<int> IsLiveVideo { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<System.DateTime> FlightTime { get; set; }
        public Nullable<int> LastFlightID { get; set; }
        public string RpasSerialNo { get; set; }
        public Nullable<int> BlackBoxID { get; set; }
        public string RefName { get; set; }
        public string Type { get; set; }
        public string MaxAllupWeight { get; set; }
        public string color { get; set; }
        public Nullable<int> IsCamara { get; set; }
        public Nullable<int> MakeID { get; set; }
        public string MakeOther { get; set; }
        public Nullable<int> ModelID { get; set; }
        public string ManufactureOther { get; set; }
        public string CameraDetails { get; set; }
        public string RegistrationDocument { get; set; }
        public string RegistrationAuthority { get; set; }
        public Nullable<System.DateTime> LastVideoDate { get; set; }
        public string InsuranceCompany { get; set; }
        public string InsuranceInsure { get; set; }
        public Nullable<System.DateTime> InsuranceValidityFrom { get; set; }
        public string InsuranceCertificateID { get; set; }
        public Nullable<System.DateTime> InsuranceValidityTo { get; set; }
    }
}

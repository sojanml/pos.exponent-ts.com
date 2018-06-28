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
    
    public partial class ApproalDetail
    {
        public int ID { get; set; }
        public Nullable<int> ApprovalID { get; set; }
        public string Authority { get; set; }
        public Nullable<int> SerialNo { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Fax { get; set; }
        public string Telephone { get; set; }
        public string POC { get; set; }
        public string TypeOfAreal { get; set; }
        public string AircraftType { get; set; }
        public string AircraftTailNo { get; set; }
        public string Registration { get; set; }
        public string CallSign { get; set; }
        public string DepartureAerodrome { get; set; }
        public string DestinationAerodrome { get; set; }
        public string AuthorityPOC { get; set; }
        public string AuthorityTitle { get; set; }
        public string AuthorityPhone { get; set; }
        public string AuthorityEmail { get; set; }
        public string AuthorityTelephoneNo { get; set; }
        public string AuthorityFaxNo { get; set; }
        public string TypeOfOperation { get; set; }
        public string DescOfAreaLocation { get; set; }
        public string PurposeOfOperation { get; set; }
        public bool IsCamara { get; set; }
        public string IsCamaraDesc { get; set; }
        public bool IsStakeholderConsultation { get; set; }
        public string IsStakeholderConsultationDesc { get; set; }
        public string AirtraficImpact { get; set; }
        public string Comments { get; set; }
    }
}

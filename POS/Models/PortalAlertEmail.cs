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
    
    public partial class PortalAlertEmail
    {
        public int EmailID { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public int UserID { get; set; }
        public string EmailSubject { get; set; }
        public string Body { get; set; }
        public string EmailURL { get; set; }
        public string Attachments { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<byte> IsSend { get; set; }
        public string SendStatus { get; set; }
        public Nullable<System.DateTime> SendOn { get; set; }
        public string SendType { get; set; }
    }
}

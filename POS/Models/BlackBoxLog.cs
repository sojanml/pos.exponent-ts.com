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
    
    public partial class BlackBoxLog
    {
        public int LogId { get; set; }
        public string FileName { get; set; }
        public Nullable<bool> IsProcessed { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}

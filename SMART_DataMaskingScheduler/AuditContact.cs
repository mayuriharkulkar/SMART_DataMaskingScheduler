//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMART_DataMaskingScheduler
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuditContact
    {
        public System.Guid Id { get; set; }
        public int RowId { get; set; }
        public System.Guid AuditId { get; set; }
        public string ContactType { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string ContactInfo { get; set; }
        public int RecordStatus { get; set; }
        public System.Guid LastUpdateUser { get; set; }
        public System.DateTime LastUpdateTime { get; set; }
        public string ContactTitle { get; set; }
    
        public virtual Audit Audit { get; set; }
    }
}
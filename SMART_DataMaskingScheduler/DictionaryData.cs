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
    
    public partial class DictionaryData
    {
        public System.Guid Id { get; set; }
        public int RowId { get; set; }
        public string Language { get; set; }
        public System.Guid DictionaryTypeId { get; set; }
        public Nullable<System.Guid> ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> Sort { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual DictionaryType DictionaryType { get; set; }
    }
}

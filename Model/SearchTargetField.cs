//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SearchTargetField
    {
        public int ID { get; set; }
        public int SearchTargetID { get; set; }
        public int SearchFieldID { get; set; }
        public Nullable<bool> Mandatory { get; set; }
        public int Status { get; set; }
    
        public virtual SearchField SearchField { get; set; }
        public virtual SearchField SearchField1 { get; set; }
        public virtual SearchTarget SearchTarget { get; set; }
        public virtual SearchTarget SearchTarget1 { get; set; }
    }
}

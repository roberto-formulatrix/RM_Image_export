//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RockMakerModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class FilterValue
    {
        public long ID { get; set; }
        public long FilterID { get; set; }
        public string FilterValue1 { get; set; }
        public short FilterValueType { get; set; }
    
        public virtual Filter Filter { get; set; }
    }
}
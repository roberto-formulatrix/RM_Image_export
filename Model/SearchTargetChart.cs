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
    
    public partial class SearchTargetChart
    {
        public int ID { get; set; }
        public int SearchTargetID { get; set; }
        public int ChartID { get; set; }
    
        public virtual Chart Chart { get; set; }
        public virtual SearchTarget SearchTarget { get; set; }
    }
}

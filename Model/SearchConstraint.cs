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
    
    public partial class SearchConstraint
    {
        public int ID { get; set; }
        public int SearchConstraintTreeNodeID { get; set; }
        public int SearchFieldID { get; set; }
        public string SearchOperator { get; set; }
        public string SearchValue { get; set; }
    
        public virtual SearchConstraintTreeNode SearchConstraintTreeNode { get; set; }
        public virtual SearchField SearchField { get; set; }
    }
}

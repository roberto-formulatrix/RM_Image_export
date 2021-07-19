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
    
    public partial class SearchConstraintTreeNode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SearchConstraintTreeNode()
        {
            this.ImageManagementActions = new HashSet<ImageManagementAction>();
            this.Searches = new HashSet<Search>();
            this.SearchConstraints = new HashSet<SearchConstraint>();
            this.SearchConstraintTreeNode1 = new HashSet<SearchConstraintTreeNode>();
            this.SearchConstraintTreeNode11 = new HashSet<SearchConstraintTreeNode>();
        }
    
        public int ID { get; set; }
        public Nullable<int> RootID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public int NodeType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageManagementAction> ImageManagementActions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Search> Searches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchConstraint> SearchConstraints { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchConstraintTreeNode> SearchConstraintTreeNode1 { get; set; }
        public virtual SearchConstraintTreeNode SearchConstraintTreeNode2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchConstraintTreeNode> SearchConstraintTreeNode11 { get; set; }
        public virtual SearchConstraintTreeNode SearchConstraintTreeNode3 { get; set; }
    }
}

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
    
    public partial class Search
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Search()
        {
            this.Filters = new HashSet<Filter>();
            this.SearchPaths = new HashSet<SearchPath>();
            this.SearchPaths1 = new HashSet<SearchPath>();
            this.SearchResultFields = new HashSet<SearchResultField>();
            this.SearchResultFields1 = new HashSet<SearchResultField>();
            this.SearchCharts = new HashSet<SearchChart>();
            this.SearchDisplayFields = new HashSet<SearchDisplayField>();
        }
    
        public int ID { get; set; }
        public int TreeNodeID { get; set; }
        public int SearchTargetID { get; set; }
        public Nullable<int> FlattenTargetID { get; set; }
        public Nullable<int> RootTreeNodeID { get; set; }
        public int RootSearchConstraintTreeNodeID { get; set; }
        public bool SelectDistinct { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Filter> Filters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchPath> SearchPaths { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchPath> SearchPaths1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchResultField> SearchResultFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchResultField> SearchResultFields1 { get; set; }
        public virtual SearchTarget SearchTarget { get; set; }
        public virtual SearchConstraintTreeNode SearchConstraintTreeNode { get; set; }
        public virtual SearchTarget SearchTarget1 { get; set; }
        public virtual TreeNode TreeNode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchChart> SearchCharts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchDisplayField> SearchDisplayFields { get; set; }
    }
}

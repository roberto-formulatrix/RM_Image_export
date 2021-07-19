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
    
    public partial class SearchField
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SearchField()
        {
            this.ChartRequiredFields = new HashSet<ChartRequiredField>();
            this.Filters = new HashSet<Filter>();
            this.SearchConstraints = new HashSet<SearchConstraint>();
            this.SearchDisplayFields = new HashSet<SearchDisplayField>();
            this.SearchResultFields = new HashSet<SearchResultField>();
            this.SearchResultFields1 = new HashSet<SearchResultField>();
            this.SearchTargetFields = new HashSet<SearchTargetField>();
            this.SearchTargetFields1 = new HashSet<SearchTargetField>();
        }
    
        public int ID { get; set; }
        public int SearchTargetID { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string DisplayName { get; set; }
        public string FieldClass { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChartRequiredField> ChartRequiredFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Filter> Filters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchConstraint> SearchConstraints { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchDisplayField> SearchDisplayFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchResultField> SearchResultFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchResultField> SearchResultFields1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchTargetField> SearchTargetFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchTargetField> SearchTargetFields1 { get; set; }
        public virtual SearchTarget SearchTarget { get; set; }
    }
}
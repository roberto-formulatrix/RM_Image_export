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
    
    public partial class RegionAnnotationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegionAnnotationType()
        {
            this.RegionAnnotations = new HashSet<RegionAnnotation>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int TextARGB { get; set; }
        public int BackgroundARGB { get; set; }
        public string Icon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegionAnnotation> RegionAnnotations { get; set; }
    }
}
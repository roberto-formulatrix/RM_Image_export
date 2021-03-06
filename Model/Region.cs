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
    
    public partial class Region
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Region()
        {
            this.CaptureResults = new HashSet<CaptureResult>();
            this.ImageBatchWellDropScores = new HashSet<ImageBatchWellDropScore>();
            this.Region1 = new HashSet<Region>();
            this.RegionAnnotations = new HashSet<RegionAnnotation>();
            this.RegionCaptureProfiles = new HashSet<RegionCaptureProfile>();
            this.RegionProperties = new HashSet<RegionProperty>();
            this.RegionRulers = new HashSet<RegionRuler>();
            this.RegionScribbles = new HashSet<RegionScribble>();
        }
    
        public long ID { get; set; }
        public long WellDropID { get; set; }
        public int RegionTypeID { get; set; }
        public Nullable<long> ParentRegionID { get; set; }
        public string RegionName { get; set; }
        public bool ImagingEnabled { get; set; }
        public Nullable<double> XCenterOffset { get; set; }
        public Nullable<double> YCenterOffset { get; set; }
        public Nullable<double> ZHeight { get; set; }
        public Nullable<double> XWidth { get; set; }
        public Nullable<double> YHeight { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaptureResult> CaptureResults { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageBatchWellDropScore> ImageBatchWellDropScores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Region> Region1 { get; set; }
        public virtual Region Region2 { get; set; }
        public virtual RegionType RegionType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegionAnnotation> RegionAnnotations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegionCaptureProfile> RegionCaptureProfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegionProperty> RegionProperties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegionRuler> RegionRulers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegionScribble> RegionScribbles { get; set; }
    }
}

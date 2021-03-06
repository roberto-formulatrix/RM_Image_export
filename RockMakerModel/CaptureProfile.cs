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
    
    public partial class CaptureProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaptureProfile()
        {
            this.CaptureProfileTuningValues = new HashSet<CaptureProfileTuningValue>();
            this.CaptureProfileVersions = new HashSet<CaptureProfileVersion>();
            this.ExperimentCaptureProfileTuningValues = new HashSet<ExperimentCaptureProfileTuningValue>();
            this.ImageBatchWellDropScores = new HashSet<ImageBatchWellDropScore>();
            this.ImagingScheduleEntryCaptureProfiles = new HashSet<ImagingScheduleEntryCaptureProfile>();
            this.ImagingTaskCaptureProfiles = new HashSet<ImagingTaskCaptureProfile>();
            this.RegionCaptureProfiles = new HashSet<RegionCaptureProfile>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<long> ExperimentPlateID { get; set; }
        public Nullable<int> CurrentCaptureProfileVersionID { get; set; }
        public bool Enabled { get; set; }
        public int Status { get; set; }
        public Nullable<int> ParentID { get; set; }
        public bool ImportFL { get; set; }
    
        public virtual ExperimentPlate ExperimentPlate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaptureProfileTuningValue> CaptureProfileTuningValues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaptureProfileVersion> CaptureProfileVersions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExperimentCaptureProfileTuningValue> ExperimentCaptureProfileTuningValues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageBatchWellDropScore> ImageBatchWellDropScores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagingScheduleEntryCaptureProfile> ImagingScheduleEntryCaptureProfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagingTaskCaptureProfile> ImagingTaskCaptureProfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegionCaptureProfile> RegionCaptureProfiles { get; set; }
    }
}

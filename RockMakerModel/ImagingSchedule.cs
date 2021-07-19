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
    
    public partial class ImagingSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImagingSchedule()
        {
            this.Experiments = new HashSet<Experiment>();
            this.ImagingScheduleEntries = new HashSet<ImagingScheduleEntry>();
            this.Projects = new HashSet<Project>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ExperimentID { get; set; }
        public string Name { get; set; }
        public bool Enable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Experiment> Experiments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagingScheduleEntry> ImagingScheduleEntries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Projects { get; set; }
    }
}

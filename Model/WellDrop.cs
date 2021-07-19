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
    
    public partial class WellDrop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WellDrop()
        {
            this.ImagingTaskWellDrops = new HashSet<ImagingTaskWellDrop>();
            this.WellDropLayers = new HashSet<WellDropLayer>();
        }
    
        public long ID { get; set; }
        public long WellID { get; set; }
        public int DropNumber { get; set; }
        public Nullable<int> ProteinFormulationID { get; set; }
        public double DropWellVolume { get; set; }
        public double DropProteinVolume { get; set; }
        public Nullable<double> Volume { get; set; }
        public Nullable<double> WaterVolume { get; set; }
        public Nullable<bool> ImportFL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagingTaskWellDrop> ImagingTaskWellDrops { get; set; }
        public virtual ProteinFormulation ProteinFormulation { get; set; }
        public virtual Well Well { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WellDropLayer> WellDropLayers { get; set; }
    }
}

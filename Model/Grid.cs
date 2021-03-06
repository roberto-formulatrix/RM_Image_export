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
    
    public partial class Grid
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grid()
        {
            this.GridIngredients = new HashSet<GridIngredient>();
            this.GridLayers = new HashSet<GridLayer>();
        }
    
        public int ID { get; set; }
        public int ExperimentID { get; set; }
        public double StartWellVolume { get; set; }
        public double StopWellVolume { get; set; }
        public int WellVolumeVaryAlong { get; set; }
    
        public virtual Experiment Experiment { get; set; }
        public virtual GridVaryAlong GridVaryAlong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GridIngredient> GridIngredients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GridLayer> GridLayers { get; set; }
    }
}

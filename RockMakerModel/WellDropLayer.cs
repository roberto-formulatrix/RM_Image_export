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
    
    public partial class WellDropLayer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WellDropLayer()
        {
            this.WellDropLayerIngredients = new HashSet<WellDropLayerIngredient>();
        }
    
        public long ID { get; set; }
        public long WellDropID { get; set; }
        public long LayerID { get; set; }
        public double Volume { get; set; }
        public double WaterVolume { get; set; }
        public Nullable<long> SourceWellID { get; set; }
        public string WaterSource { get; set; }
    
        public virtual Layer Layer { get; set; }
        public virtual WellDrop WellDrop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WellDropLayerIngredient> WellDropLayerIngredients { get; set; }
    }
}

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
    
    public partial class Condition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Condition()
        {
            this.ConditionIngredients = new HashSet<ConditionIngredient>();
        }
    
        public int ID { get; set; }
        public int ConditionListLayerID { get; set; }
        public int ConditionNumber { get; set; }
    
        public virtual ConditionListLayer ConditionListLayer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConditionIngredient> ConditionIngredients { get; set; }
    }
}

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
    
    public partial class IngredientType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IngredientType()
        {
            this.IngredientIngredientTypes = new HashSet<IngredientIngredientType>();
        }
    
        public int ID { get; set; }
        public bool IsBuffer { get; set; }
        public string Name { get; set; }
        public Nullable<int> IngredientTypeColorID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngredientIngredientType> IngredientIngredientTypes { get; set; }
        public virtual IngredientTypeColor IngredientTypeColor { get; set; }
    }
}

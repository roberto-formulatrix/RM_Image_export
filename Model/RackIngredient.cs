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
    
    public partial class RackIngredient
    {
        public int ID { get; set; }
        public int RackID { get; set; }
        public int IngredientStockID { get; set; }
        public int RackPosition { get; set; }
        public Nullable<double> Volume { get; set; }
        public string Barcode { get; set; }
    
        public virtual IngredientStock IngredientStock { get; set; }
        public virtual Rack Rack { get; set; }
    }
}
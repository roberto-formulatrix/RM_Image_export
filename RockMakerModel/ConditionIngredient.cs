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
    
    public partial class ConditionIngredient
    {
        public int ID { get; set; }
        public int ConditionID { get; set; }
        public int IngredientIngredientTypeID { get; set; }
        public int IngredientStockID { get; set; }
        public Nullable<int> HighPHIngredientStockID { get; set; }
        public double Concentration { get; set; }
        public Nullable<double> pH { get; set; }
    
        public virtual Condition Condition { get; set; }
        public virtual IngredientIngredientType IngredientIngredientType { get; set; }
        public virtual IngredientStock IngredientStock { get; set; }
        public virtual IngredientStock IngredientStock1 { get; set; }
    }
}

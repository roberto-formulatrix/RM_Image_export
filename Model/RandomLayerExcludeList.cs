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
    
    public partial class RandomLayerExcludeList
    {
        public int ID { get; set; }
        public int RandomLayerID { get; set; }
        public int Ingredient1ID { get; set; }
        public int Ingredient2ID { get; set; }
    
        public virtual Ingredient Ingredient { get; set; }
        public virtual Ingredient Ingredient1 { get; set; }
        public virtual RandomLayer RandomLayer { get; set; }
    }
}
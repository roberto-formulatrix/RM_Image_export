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
    
    public partial class ProteinFormulationIngredient
    {
        public int ID { get; set; }
        public int ProteinFormulationID { get; set; }
        public int ProteinFormulationIngredientTypeID { get; set; }
        public string Name { get; set; }
        public string UserID { get; set; }
        public string Lot { get; set; }
        public Nullable<double> MolecularWeight { get; set; }
        public Nullable<double> ConcentrationmgmL { get; set; }
        public Nullable<double> ConcentrationmM { get; set; }
    
        public virtual ProteinFormulation ProteinFormulation { get; set; }
        public virtual ProteinFormulationIngredientType ProteinFormulationIngredientType { get; set; }
    }
}
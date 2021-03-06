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
    
    public partial class ScreenLayer
    {
        public int ID { get; set; }
        public long LayerID { get; set; }
        public int ExperimentID { get; set; }
        public int ScreenLotID { get; set; }
        public double Volume { get; set; }
        public Nullable<int> StartingWellNumber { get; set; }
    
        public virtual Experiment Experiment { get; set; }
        public virtual Layer Layer { get; set; }
        public virtual ScreenLot ScreenLot { get; set; }
    }
}

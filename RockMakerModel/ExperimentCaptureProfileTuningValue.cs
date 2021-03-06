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
    
    public partial class ExperimentCaptureProfileTuningValue
    {
        public int ID { get; set; }
        public int ExperimentID { get; set; }
        public int CaptureProfileID { get; set; }
        public bool AutoLevelingOn { get; set; }
        public decimal AutoLevelingLowThreshold { get; set; }
        public decimal AutoLevelingHighThreshold { get; set; }
        public int LowerLevelLimit { get; set; }
        public int UpperLevelLimit { get; set; }
        public int Brightness { get; set; }
        public int Contrast { get; set; }
        public int Gamma { get; set; }
        public int AutoLevelingMode { get; set; }
    
        public virtual CaptureProfile CaptureProfile { get; set; }
        public virtual Experiment Experiment { get; set; }
    }
}

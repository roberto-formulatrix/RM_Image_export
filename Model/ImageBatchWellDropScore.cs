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
    
    public partial class ImageBatchWellDropScore
    {
        public int ID { get; set; }
        public long WellDropID { get; set; }
        public int ImageBatchID { get; set; }
        public int WellDropScoreID { get; set; }
        public Nullable<double> AutoScoreValue { get; set; }
        public int ScoreType { get; set; }
        public Nullable<int> CaptureProfileID { get; set; }
        public Nullable<long> SourceRegionID { get; set; }
    
        public virtual CaptureProfile CaptureProfile { get; set; }
        public virtual ImageBatch ImageBatch { get; set; }
        public virtual Region Region { get; set; }
        public virtual WellDropScore WellDropScore { get; set; }
    }
}

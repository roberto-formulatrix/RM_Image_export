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
    
    public partial class FocalPoint
    {
        public long ID { get; set; }
        public long CaptureResultID { get; set; }
        public double Z { get; set; }
        public double Focus { get; set; }
    
        public virtual CaptureResult CaptureResult { get; set; }
    }
}

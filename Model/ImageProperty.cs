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
    
    public partial class ImageProperty
    {
        public long ID { get; set; }
        public long ImageID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    
        public virtual Image Image { get; set; }
    }
}

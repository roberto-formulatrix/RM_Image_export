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
    
    public partial class Project
    {
        public int ID { get; set; }
        public int TreeNodeID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int OwnerUserID { get; set; }
        public int DefaultImagingScheduleID { get; set; }
        public string Notes { get; set; }
    
        public virtual ImagingSchedule ImagingSchedule { get; set; }
        public virtual TreeNode TreeNode { get; set; }
        public virtual User User { get; set; }
    }
}

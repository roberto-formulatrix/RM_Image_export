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
    
    public partial class ImageManagementAction
    {
        public int ID { get; set; }
        public int ImageManagementID { get; set; }
        public int RootSearchConstraintTreeNodeID { get; set; }
        public int ActionType { get; set; }
        public int SourceImageStoreID { get; set; }
        public Nullable<int> TargetImageStoreID { get; set; }
        public bool Verify { get; set; }
        public bool ExcludeFirstInspection { get; set; }
        public bool ExcludeLastInspection { get; set; }
    
        public virtual ImageManagement ImageManagement { get; set; }
        public virtual SearchConstraintTreeNode SearchConstraintTreeNode { get; set; }
        public virtual ImageStore ImageStore { get; set; }
        public virtual ImageStore ImageStore1 { get; set; }
    }
}

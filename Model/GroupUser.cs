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
    
    public partial class GroupUser
    {
        public int ID { get; set; }
        public int GroupID { get; set; }
        public int UserID { get; set; }
        public Nullable<bool> PrimaryGroup { get; set; }
        public Nullable<bool> GroupAdmin { get; set; }
        public Nullable<bool> PreferenceGroup { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual User User { get; set; }
    }
}
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
    
    public partial class Deck
    {
        public int ID { get; set; }
        public Nullable<int> RackID { get; set; }
        public string SiteName { get; set; }
        public string LidSiteName { get; set; }
        public Nullable<int> LidStorageID { get; set; }
        public int DispensingRobotID { get; set; }
    
        public virtual DispensingRobot DispensingRobot { get; set; }
        public virtual LidStorage LidStorage { get; set; }
        public virtual Rack Rack { get; set; }
    }
}

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
    
    public partial class RackType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RackType()
        {
            this.Racks = new HashSet<Rack>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumCols { get; set; }
        public int NumRows { get; set; }
        public int TipAccess { get; set; }
        public double Volume { get; set; }
        public double DeadVolume { get; set; }
        public int DispensingRobotID { get; set; }
    
        public virtual DispensingRobot DispensingRobot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rack> Racks { get; set; }
    }
}

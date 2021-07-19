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
    
    public partial class LidStorageType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LidStorageType()
        {
            this.LidStorages = new HashSet<LidStorage>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumCols { get; set; }
        public int NumRows { get; set; }
        public int NumStack { get; set; }
        public int DispensingRobotID { get; set; }
    
        public virtual DispensingRobot DispensingRobot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LidStorage> LidStorages { get; set; }
    }
}

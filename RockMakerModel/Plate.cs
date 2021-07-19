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
    
    public partial class Plate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plate()
        {
            this.DispenseQueues = new HashSet<DispenseQueue>();
            this.ExperimentPlates = new HashSet<ExperimentPlate>();
            this.PlateEvents = new HashSet<PlateEvent>();
            this.ScreenLotPlates = new HashSet<ScreenLotPlate>();
            this.Wells = new HashSet<Well>();
        }
    
        public long ID { get; set; }
        public int PlateNumber { get; set; }
        public int ExperimentID { get; set; }
        public string Barcode { get; set; }
        public int TreeNodeID { get; set; }
        public int State { get; set; }
        public bool IsQueued { get; set; }
        public Nullable<System.DateTime> DateDispensed { get; set; }
        public Nullable<int> DispensingRobotID { get; set; }
        public int CanvasRowPosition { get; set; }
        public int CanvasColumnPosition { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DispenseQueue> DispenseQueues { get; set; }
        public virtual DispensingRobot DispensingRobot { get; set; }
        public virtual Experiment Experiment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExperimentPlate> ExperimentPlates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlateEvent> PlateEvents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScreenLotPlate> ScreenLotPlates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Well> Wells { get; set; }
    }
}
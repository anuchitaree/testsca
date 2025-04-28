using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class AssyPcvTightening
    {
        public double Id { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Time { get; set; }
        public double? Pallet { get; set; }
        public double? Model { get; set; }
        public string? CylinderSerialNo { get; set; }
        public double? BodyPcvTigheningTorque { get; set; }
        public double? BodyPcvTighteningAngle { get; set; }
        public double? NutTighteningTorque { get; set; }
        public double? NutTighteningAngle { get; set; }
        public double? LoadOring { get; set; }
        public double? LoadEndStopper { get; set; }
        public double? DistanceIai { get; set; }
        public string? Judgement { get; set; }
        public string? Partnumber { get; set; }
        public double? SnugBody { get; set; }
        public double? SnugNut { get; set; }
    }
}

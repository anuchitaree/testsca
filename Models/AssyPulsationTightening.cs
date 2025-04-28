using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class AssyPulsationTightening
    {
        public double Id { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Time { get; set; }
        public double? Pallet { get; set; }
        public double? Model { get; set; }
        public string? CylinderSerialNo { get; set; }
        public string? PulsationSerial1 { get; set; }
        public double? PulsationSerial2 { get; set; }
        public double? PuldanTightening { get; set; }
        public double? PuldanTighteningAngle { get; set; }
        public double? UnionTightening { get; set; }
        public double? UnionTighteningAngle { get; set; }
        public string? Judgement { get; set; }
        public string? Partnumber { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class ElementMatching
    {
        public double Id { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string QrPlunger { get; set; } = null!;
        public string QrCylinder { get; set; } = null!;
        public double CylinderA { get; set; }
        public double CylinderB { get; set; }
        public double CylinderC { get; set; }
        public double PlungerA { get; set; }
        public double PlungerB { get; set; }
        public double PlungerC { get; set; }
        public double ClearanceC1 { get; set; }
        public double ClearanceC2 { get; set; }
        public double ClearanceC3 { get; set; }
        public double Model { get; set; }
        public double PlungerMarkingDate { get; set; }
        public string PlungerSn { get; set; } = null!;
        public double CylinderMarkingDate { get; set; }
        public string CylinderSn { get; set; } = null!;
        public string? F21 { get; set; }
        public string? F22 { get; set; }
    }
}

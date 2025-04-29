using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class CylinderGrinding
    {
        public double Id { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public DateTime PlcDate { get; set; }
        public DateTime PlcTime { get; set; }
        public string PartNo { get; set; } = null!;
        public double PercentQrread { get; set; }
        public double Model { get; set; }
        public double ProdDate { get; set; }
        public string SerialNo { get; set; } = null!;
        public string? F12 { get; set; }
        public string? F13 { get; set; }
    }
}

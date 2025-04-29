using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class Ed005pr
    {
        public double Id { get; set; }
        public double Trkno { get; set; }
        public double Cusno { get; set; }
        public double Shpno { get; set; }
        public string Prtno { get; set; } = null!;
        public double Duedt { get; set; }
        public string Corno { get; set; } = null!;
        public string Cprtn { get; set; } = null!;
        public double Shpqy { get; set; }
        public double Shdqy { get; set; }
        public string Sorno { get; set; } = null!;
        public double Qtunt { get; set; }
        public string Unmsr { get; set; } = null!;
        public string Unmdc { get; set; } = null!;
        public string Cpdsc { get; set; } = null!;
        public string Itcls { get; set; } = null!;
        public string House { get; set; } = null!;
        public string Whslc { get; set; } = null!;
    }
}

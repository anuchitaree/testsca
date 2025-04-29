using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class FinalInspectionMatchSerial
    {
        public double Id { get; set; }
        public DateTime Ymd { get; set; }
        public DateTime Times { get; set; }
        public double DensoPartNoPumpPartNumber { get; set; }
        public string CustomerPartNo { get; set; } = null!;
        public double Month { get; set; }
        public string Year { get; set; } = null!;
        public double Serial { get; set; }
        public string DataQrCode1PumpStickerOrPumpNamePlateOrPumpSerialNu { get; set; } = null!;
        public string DataQrCode2ReadFromCycliderLaserMark { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string DataSn1CutFromI { get; set; } = null!;
        public string CylinderSerialCutFromJ { get; set; } = null!;
        public DateTime Datetime { get; set; }
    }
}

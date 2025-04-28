using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class FinalInspectionMatchSerial
    {
        public double Id { get; set; }
        public DateTime? Ymd { get; set; }
        public DateTime? Times { get; set; }
        public double? DensoPartNoPumpPartNumber { get; set; }
        public string? CustomerPartNo { get; set; }
        public double? Month { get; set; }
        public string? Year { get; set; }
        public double? Serial { get; set; }
        public string? DataQrCode1PumpStickerOrPumpNamePlateOrPumpSerialNu { get; set; }
        public string? DataQrCode2ReadFromCycliderLaserMark { get; set; }
        public string? Status { get; set; }
        public string? DataSn1CutFromI { get; set; }
        public string? CylinderSerialCutFromJ { get; set; }
        public DateTime? Datetime { get; set; }
    }
}

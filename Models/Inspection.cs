using System;
using System.Collections.Generic;

namespace testsca.Models
{
    public partial class Inspection
    {
        public double Id { get; set; }
        public string? Status { get; set; }
        public DateTime? DeviceTimestamp { get; set; }
        public double? Model { get; set; }
        public string? SerialNo { get; set; }
        public double? StationNo { get; set; }
        public double? OverallJudge { get; set; }
        public double? SpeedTime { get; set; }
        public double? PalletNo { get; set; }
        public double? DriveMotorTorqueMax { get; set; }
        public string? DeviceMode { get; set; }
        public double? InsCode { get; set; }
        public double? Judge { get; set; }
        public double? Speed { get; set; }
        public double? TfOut { get; set; }
        public double? CrPressure { get; set; }
        public double? Q { get; set; }
        public double? QKisa { get; set; }
        public double? DOne { get; set; }
        public double? SettingTime { get; set; }
        public double? InspecTime { get; set; }
        public double? Ovf { get; set; }
        public double? OvfKisa { get; set; }
        public double? X1 { get; set; }
        public double? X2 { get; set; }
        public double? PcvMin { get; set; }
        public double? PcvMax { get; set; }
        public double? OvfTmep { get; set; }
        public double? DriveMotorTorque { get; set; }
        public double? DriveMotorTorquePeak { get; set; }
        public string? FileName { get; set; }
        public DateTime? ImportTime { get; set; }
    }
}

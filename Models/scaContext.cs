using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace testsca.Models
{
    public partial class scaContext : DbContext
    {
        public scaContext()
        {
        }

        public scaContext(DbContextOptions<scaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AssyAirLeakTest> AssyAirLeakTests { get; set; } = null!;
        public virtual DbSet<AssyLoadSeatAssembly> AssyLoadSeatAssemblies { get; set; } = null!;
        public virtual DbSet<AssyOilSealPressFitting> AssyOilSealPressFittings { get; set; } = null!;
        public virtual DbSet<AssyPcvTightening> AssyPcvTightenings { get; set; } = null!;
        public virtual DbSet<AssyPulsationTightening> AssyPulsationTightenings { get; set; } = null!;
        public virtual DbSet<AssySealStopper> AssySealStoppers { get; set; } = null!;
        public virtual DbSet<AssyStopperValveStation1> AssyStopperValveStation1s { get; set; } = null!;
        public virtual DbSet<AssyStopperValveStation2> AssyStopperValveStation2s { get; set; } = null!;
        public virtual DbSet<CylinderGrinding> CylinderGrindings { get; set; } = null!;
        public virtual DbSet<Ed000pr> Ed000prs { get; set; } = null!;
        public virtual DbSet<Ed004pr> Ed004prs { get; set; } = null!;
        public virtual DbSet<Ed005pr> Ed005prs { get; set; } = null!;
        public virtual DbSet<Edt01pr> Edt01prs { get; set; } = null!;
        public virtual DbSet<Edt31pr> Edt31prs { get; set; } = null!;
        public virtual DbSet<ElementMatching> ElementMatchings { get; set; } = null!;
        public virtual DbSet<FinalInspectionMatchSerial> FinalInspectionMatchSerials { get; set; } = null!;
        public virtual DbSet<Inspection> Inspections { get; set; } = null!;
        public virtual DbSet<Pdi> Pdis { get; set; } = null!;
        public virtual DbSet<Qrshippinglog> Qrshippinglogs { get; set; } = null!;
        public virtual DbSet<Ud24pr> Ud24prs { get; set; } = null!;
        public virtual DbSet<Ud25pr> Ud25prs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=sca;user=Admin;password=Admin;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssyAirLeakTest>(entity =>
            {
                entity.ToTable("assy_air_leak_test");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AirSupplyPressureHigh).HasColumnName("Air supply pressure high");

                entity.Property(e => e.AirSupplyPressureLow).HasColumnName("Air supply pressure low");

                entity.Property(e => e.CylinderSerialNo).HasColumnName("Cylinder_Serial No#");

                entity.Property(e => e.CylinderSerialNoNew)
                    .HasMaxLength(255)
                    .HasColumnName("cylinder_serial_no_new");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.F14).HasMaxLength(255);

                entity.Property(e => e.F15).HasMaxLength(255);

                entity.Property(e => e.F16).HasMaxLength(255);

                entity.Property(e => e.Judgement).HasMaxLength(255);

                entity.Property(e => e.LeakAtHighPressure).HasColumnName("Leak at high pressure");

                entity.Property(e => e.LeakAtLowPressure).HasColumnName("Leak at low pressure");

                entity.Property(e => e.Partnumber)
                    .HasMaxLength(255)
                    .HasColumnName("partnumber");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<AssyLoadSeatAssembly>(entity =>
            {
                entity.ToTable("assy_load_seat_assembly");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CylinderSerialNo)
                    .HasMaxLength(255)
                    .HasColumnName("Cylinder_Serial No#");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Judgement).HasMaxLength(255);

                entity.Property(e => e.Partnumber)
                    .HasMaxLength(255)
                    .HasColumnName("partnumber");

                entity.Property(e => e.SpringLoadTest).HasColumnName("Spring load test");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<AssyOilSealPressFitting>(entity =>
            {
                entity.ToTable("assy_oil_seal_press_fitting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CylinderSerialNo)
                    .HasMaxLength(255)
                    .HasColumnName("Cylinder_Serial No#");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Judgement).HasMaxLength(255);

                entity.Property(e => e.OilSeal)
                    .HasMaxLength(255)
                    .HasColumnName("Oil Seal");

                entity.Property(e => e.Partnumber)
                    .HasMaxLength(255)
                    .HasColumnName("partnumber");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<AssyPcvTightening>(entity =>
            {
                entity.ToTable("assy_pcv_tightening");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BodyPcvTigheningTorque).HasColumnName("Body PCV tighening torque");

                entity.Property(e => e.BodyPcvTighteningAngle).HasColumnName("Body PCV tightening angle");

                entity.Property(e => e.CylinderSerialNo)
                    .HasMaxLength(255)
                    .HasColumnName("Cylinder_Serial No#");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.DistanceIai).HasColumnName("Distance IAI");

                entity.Property(e => e.Judgement).HasMaxLength(255);

                entity.Property(e => e.LoadEndStopper).HasColumnName("Load end Stopper");

                entity.Property(e => e.LoadOring).HasColumnName("Load-Oring");

                entity.Property(e => e.NutTighteningAngle).HasColumnName("Nut tightening angle");

                entity.Property(e => e.NutTighteningTorque).HasColumnName("Nut tightening torque");

                entity.Property(e => e.Partnumber)
                    .HasMaxLength(255)
                    .HasColumnName("partnumber");

                entity.Property(e => e.SnugBody).HasColumnName("Snug Body");

                entity.Property(e => e.SnugNut).HasColumnName("Snug Nut");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<AssyPulsationTightening>(entity =>
            {
                entity.ToTable("assy_pulsation_tightening");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CylinderSerialNo)
                    .HasMaxLength(255)
                    .HasColumnName("Cylinder_Serial No#");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Judgement).HasMaxLength(255);

                entity.Property(e => e.Partnumber)
                    .HasMaxLength(255)
                    .HasColumnName("partnumber");

                entity.Property(e => e.PuldanTightening).HasColumnName("Puldan tightening");

                entity.Property(e => e.PuldanTighteningAngle).HasColumnName("Puldan tightening angle");

                entity.Property(e => e.PulsationSerial1)
                    .HasMaxLength(255)
                    .HasColumnName("Pulsation Serial1");

                entity.Property(e => e.PulsationSerial2).HasColumnName("Pulsation Serial2");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.UnionTightening).HasColumnName("Union tightening");

                entity.Property(e => e.UnionTighteningAngle).HasColumnName("Union tightening angle");
            });

            modelBuilder.Entity<AssySealStopper>(entity =>
            {
                entity.ToTable("assy_seal_stopper");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CylinderSerialNo)
                    .HasMaxLength(255)
                    .HasColumnName("Cylinder_Serial No#");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Judgement).HasMaxLength(255);

                entity.Property(e => e.Partnumber)
                    .HasMaxLength(255)
                    .HasColumnName("partnumber");

                entity.Property(e => e.PlungerInsertLoad).HasColumnName("Plunger insert load");

                entity.Property(e => e.SealStopperPressDimension).HasColumnName("Seal stopper press dimension");

                entity.Property(e => e.SealStopperPressLoad).HasColumnName("Seal stopper press load");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<AssyStopperValveStation1>(entity =>
            {
                entity.ToTable("assy_stopper_valve station_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CylinderSerialNo)
                    .HasMaxLength(255)
                    .HasColumnName("Cylinder_Serial No#");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.DimensionBallSpringCheck).HasColumnName("Dimension ball spring check");

                entity.Property(e => e.F14).HasMaxLength(255);

                entity.Property(e => e.F15).HasMaxLength(255);

                entity.Property(e => e.F16).HasMaxLength(255);

                entity.Property(e => e.HSerialNo)
                    .HasMaxLength(255)
                    .HasColumnName("H_Serial No#");

                entity.Property(e => e.Judgement).HasMaxLength(255);

                entity.Property(e => e.Partnumber)
                    .HasMaxLength(255)
                    .HasColumnName("partnumber");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.YearChar).HasMaxLength(255);
            });

            modelBuilder.Entity<AssyStopperValveStation2>(entity =>
            {
                entity.ToTable("assy_stopper_valve station_2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CylinderSerialNo)
                    .HasMaxLength(255)
                    .HasColumnName("Cylinder_Serial No#");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.DimensionCheckAfterPressFit).HasColumnName("Dimension Check after press fit");

                entity.Property(e => e.Judgement).HasMaxLength(255);

                entity.Property(e => e.Partnumber)
                    .HasMaxLength(255)
                    .HasColumnName("partnumber");

                entity.Property(e => e.StopperValvePress).HasColumnName("Stopper Valve press");

                entity.Property(e => e.StopperValveServoPress).HasColumnName("Stopper Valve Servo press");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<CylinderGrinding>(entity =>
            {
                entity.ToTable("cylinder_grinding");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.F12).HasMaxLength(255);

                entity.Property(e => e.F13).HasMaxLength(255);

                entity.Property(e => e.Model).HasColumnName("model");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(255)
                    .HasColumnName("part_no");

                entity.Property(e => e.PercentQrread).HasColumnName("percent_qrread");

                entity.Property(e => e.PlcDate)
                    .HasColumnType("datetime")
                    .HasColumnName("plc_date");

                entity.Property(e => e.PlcTime)
                    .HasColumnType("datetime")
                    .HasColumnName("plc_time");

                entity.Property(e => e.ProdDate).HasColumnName("prod_date");

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(255)
                    .HasColumnName("serial_no ");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ed000pr>(entity =>
            {
                entity.ToTable("ED000PR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alqty).HasColumnName("ALQTY");

                entity.Property(e => e.Corno)
                    .HasMaxLength(255)
                    .HasColumnName("CORNO");

                entity.Property(e => e.Cprtn)
                    .HasMaxLength(255)
                    .HasColumnName("CPRTN");

                entity.Property(e => e.Cusno).HasColumnName("CUSNO");

                entity.Property(e => e.Cuspo)
                    .HasMaxLength(255)
                    .HasColumnName("CUSPO");

                entity.Property(e => e.Duedt).HasColumnName("DUEDT");

                entity.Property(e => e.Kbflg).HasColumnName("KBFLG");

                entity.Property(e => e.Lmndt).HasColumnName("LMNDT");

                entity.Property(e => e.Lotno)
                    .HasMaxLength(255)
                    .HasColumnName("LOTNO");

                entity.Property(e => e.Model)
                    .HasMaxLength(255)
                    .HasColumnName("MODEL");

                entity.Property(e => e.Noshp).HasColumnName("NOSHP");

                entity.Property(e => e.Odrfl).HasColumnName("ODRFL");

                entity.Property(e => e.Ogqty).HasColumnName("OGQTY");

                entity.Property(e => e.Orqty).HasColumnName("ORQTY");

                entity.Property(e => e.Prtno)
                    .HasMaxLength(255)
                    .HasColumnName("PRTNO");

                entity.Property(e => e.Shdqy).HasColumnName("SHDQY");

                entity.Property(e => e.Shpdt).HasColumnName("SHPDT");

                entity.Property(e => e.Shpno).HasColumnName("SHPNO");

                entity.Property(e => e.Sorno)
                    .HasMaxLength(255)
                    .HasColumnName("SORNO");

                entity.Property(e => e.Spodf)
                    .HasMaxLength(255)
                    .HasColumnName("SPODF");
            });

            modelBuilder.Entity<Ed004pr>(entity =>
            {
                entity.ToTable("ED004PR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acta1)
                    .HasMaxLength(255)
                    .HasColumnName("ACTA1");

                entity.Property(e => e.Acta2)
                    .HasMaxLength(255)
                    .HasColumnName("ACTA2");

                entity.Property(e => e.Acta3)
                    .HasMaxLength(255)
                    .HasColumnName("ACTA3");

                entity.Property(e => e.Actaa)
                    .HasMaxLength(255)
                    .HasColumnName("ACTAA");

                entity.Property(e => e.Actct)
                    .HasMaxLength(255)
                    .HasColumnName("ACTCT");

                entity.Property(e => e.Actnm)
                    .HasMaxLength(255)
                    .HasColumnName("ACTNM");

                entity.Property(e => e.Actno).HasColumnName("ACTNO");

                entity.Property(e => e.Bila1)
                    .HasMaxLength(255)
                    .HasColumnName("BILA1");

                entity.Property(e => e.Bila2)
                    .HasMaxLength(255)
                    .HasColumnName("BILA2");

                entity.Property(e => e.Bila3)
                    .HasMaxLength(255)
                    .HasColumnName("BILA3");

                entity.Property(e => e.Bilaa)
                    .HasMaxLength(255)
                    .HasColumnName("BILAA");

                entity.Property(e => e.Bilct)
                    .HasMaxLength(255)
                    .HasColumnName("BILCT");

                entity.Property(e => e.Bildp)
                    .HasMaxLength(255)
                    .HasColumnName("BILDP");

                entity.Property(e => e.Bilfx)
                    .HasMaxLength(255)
                    .HasColumnName("BILFX");

                entity.Property(e => e.Bilnc)
                    .HasMaxLength(255)
                    .HasColumnName("BILNC");

                entity.Property(e => e.Bilnm)
                    .HasMaxLength(255)
                    .HasColumnName("BILNM");

                entity.Property(e => e.Bilno).HasColumnName("BILNO");

                entity.Property(e => e.Biltl)
                    .HasMaxLength(255)
                    .HasColumnName("BILTL");

                entity.Property(e => e.Bnka1)
                    .HasMaxLength(255)
                    .HasColumnName("BNKA1");

                entity.Property(e => e.Bnka2)
                    .HasMaxLength(255)
                    .HasColumnName("BNKA2");

                entity.Property(e => e.Bnka3)
                    .HasMaxLength(255)
                    .HasColumnName("BNKA3");

                entity.Property(e => e.Bnknm)
                    .HasMaxLength(255)
                    .HasColumnName("BNKNM");

                entity.Property(e => e.Bnkno)
                    .HasMaxLength(255)
                    .HasColumnName("BNKNO");

                entity.Property(e => e.Cara1)
                    .HasMaxLength(255)
                    .HasColumnName("CARA1");

                entity.Property(e => e.Cara2)
                    .HasMaxLength(255)
                    .HasColumnName("CARA2");

                entity.Property(e => e.Cara3)
                    .HasMaxLength(255)
                    .HasColumnName("CARA3");

                entity.Property(e => e.Carnm)
                    .HasMaxLength(255)
                    .HasColumnName("CARNM");

                entity.Property(e => e.Carqy).HasColumnName("CARQY");

                entity.Property(e => e.Cmrfl).HasColumnName("CMRFL");

                entity.Property(e => e.Curcd)
                    .HasMaxLength(255)
                    .HasColumnName("CURCD");

                entity.Property(e => e.Curdc)
                    .HasMaxLength(255)
                    .HasColumnName("CURDC");

                entity.Property(e => e.Cusno).HasColumnName("CUSNO");

                entity.Property(e => e.Daflg).HasColumnName("DAFLG");

                entity.Property(e => e.Ddflg).HasColumnName("DDFLG");

                entity.Property(e => e.Ddnbr).HasColumnName("DDNBR");

                entity.Property(e => e.Delpt)
                    .HasMaxLength(255)
                    .HasColumnName("DELPT");

                entity.Property(e => e.Estda).HasColumnName("ESTDA");

                entity.Property(e => e.Estta).HasColumnName("ESTTA");

                entity.Property(e => e.Frght).HasColumnName("FRGHT");

                entity.Property(e => e.Frtst).HasColumnName("FRTST");

                entity.Property(e => e.Gwght).HasColumnName("GWGHT");

                entity.Property(e => e.Insam).HasColumnName("INSAM");

                entity.Property(e => e.Invam).HasColumnName("INVAM");

                entity.Property(e => e.Invfl).HasColumnName("INVFL");

                entity.Property(e => e.Invnc)
                    .HasMaxLength(255)
                    .HasColumnName("INVNC");

                entity.Property(e => e.Invno).HasColumnName("INVNO");

                entity.Property(e => e.Invpt)
                    .HasMaxLength(255)
                    .HasColumnName("INVPT");

                entity.Property(e => e.Invrf).HasColumnName("INVRF");

                entity.Property(e => e.Issdt).HasColumnName("ISSDT");

                entity.Property(e => e.Ncinv).HasColumnName("NCINV");

                entity.Property(e => e.Nwght).HasColumnName("NWGHT");

                entity.Property(e => e.Packg)
                    .HasMaxLength(255)
                    .HasColumnName("PACKG");

                entity.Property(e => e.Palqy).HasColumnName("PALQY");

                entity.Property(e => e.Prflg).HasColumnName("PRFLG");

                entity.Property(e => e.Prtrm)
                    .HasMaxLength(255)
                    .HasColumnName("PRTRM");

                entity.Property(e => e.Pytrm)
                    .HasMaxLength(255)
                    .HasColumnName("PYTRM");

                entity.Property(e => e.Saca1)
                    .HasMaxLength(255)
                    .HasColumnName("SACA1");

                entity.Property(e => e.Saca2)
                    .HasMaxLength(255)
                    .HasColumnName("SACA2");

                entity.Property(e => e.Saca3)
                    .HasMaxLength(255)
                    .HasColumnName("SACA3");

                entity.Property(e => e.Sacaa)
                    .HasMaxLength(255)
                    .HasColumnName("SACAA");

                entity.Property(e => e.Sacct)
                    .HasMaxLength(255)
                    .HasColumnName("SACCT");

                entity.Property(e => e.Sacnm)
                    .HasMaxLength(255)
                    .HasColumnName("SACNM");

                entity.Property(e => e.Sacno).HasColumnName("SACNO");

                entity.Property(e => e.Sbka1)
                    .HasMaxLength(255)
                    .HasColumnName("SBKA1");

                entity.Property(e => e.Sbka2)
                    .HasMaxLength(255)
                    .HasColumnName("SBKA2");

                entity.Property(e => e.Sbka3)
                    .HasMaxLength(255)
                    .HasColumnName("SBKA3");

                entity.Property(e => e.Sbknm)
                    .HasMaxLength(255)
                    .HasColumnName("SBKNM");

                entity.Property(e => e.Sbkno)
                    .HasMaxLength(255)
                    .HasColumnName("SBKNO");

                entity.Property(e => e.Sbla1)
                    .HasMaxLength(255)
                    .HasColumnName("SBLA1");

                entity.Property(e => e.Sbla2)
                    .HasMaxLength(255)
                    .HasColumnName("SBLA2");

                entity.Property(e => e.Sbla3)
                    .HasMaxLength(255)
                    .HasColumnName("SBLA3");

                entity.Property(e => e.Sblaa)
                    .HasMaxLength(255)
                    .HasColumnName("SBLAA");

                entity.Property(e => e.Sblct)
                    .HasMaxLength(255)
                    .HasColumnName("SBLCT");

                entity.Property(e => e.Sbldp)
                    .HasMaxLength(255)
                    .HasColumnName("SBLDP");

                entity.Property(e => e.Sblfx)
                    .HasMaxLength(255)
                    .HasColumnName("SBLFX");

                entity.Property(e => e.Sblnc)
                    .HasMaxLength(255)
                    .HasColumnName("SBLNC");

                entity.Property(e => e.Sblnm)
                    .HasMaxLength(255)
                    .HasColumnName("SBLNM");

                entity.Property(e => e.Sblno).HasColumnName("SBLNO");

                entity.Property(e => e.Sbltl)
                    .HasMaxLength(255)
                    .HasColumnName("SBLTL");

                entity.Property(e => e.Scrcd)
                    .HasMaxLength(255)
                    .HasColumnName("SCRCD");

                entity.Property(e => e.Scrdc)
                    .HasMaxLength(255)
                    .HasColumnName("SCRDC");

                entity.Property(e => e.Sddfl).HasColumnName("SDDFL");

                entity.Property(e => e.Sdlpt)
                    .HasMaxLength(255)
                    .HasColumnName("SDLPT");

                entity.Property(e => e.Sfrgt).HasColumnName("SFRGT");

                entity.Property(e => e.Sfrst).HasColumnName("SFRST");

                entity.Property(e => e.Shddt).HasColumnName("SHDDT");

                entity.Property(e => e.Shpa1)
                    .HasMaxLength(255)
                    .HasColumnName("SHPA1");

                entity.Property(e => e.Shpa2)
                    .HasMaxLength(255)
                    .HasColumnName("SHPA2");

                entity.Property(e => e.Shpa3)
                    .HasMaxLength(255)
                    .HasColumnName("SHPA3");

                entity.Property(e => e.Shpaa)
                    .HasMaxLength(255)
                    .HasColumnName("SHPAA");

                entity.Property(e => e.Shpct)
                    .HasMaxLength(255)
                    .HasColumnName("SHPCT");

                entity.Property(e => e.Shpdt).HasColumnName("SHPDT");

                entity.Property(e => e.Shpmk)
                    .HasMaxLength(255)
                    .HasColumnName("SHPMK");

                entity.Property(e => e.Shpnm)
                    .HasMaxLength(255)
                    .HasColumnName("SHPNM");

                entity.Property(e => e.Shpno).HasColumnName("SHPNO");

                entity.Property(e => e.Shptp)
                    .HasMaxLength(255)
                    .HasColumnName("SHPTP");

                entity.Property(e => e.Sinam).HasColumnName("SINAM");

                entity.Property(e => e.Sinfo)
                    .HasMaxLength(255)
                    .HasColumnName("SINFO");

                entity.Property(e => e.Sinvc)
                    .HasMaxLength(255)
                    .HasColumnName("SINVC");

                entity.Property(e => e.Sivam).HasColumnName("SIVAM");

                entity.Property(e => e.Sivfl).HasColumnName("SIVFL");

                entity.Property(e => e.Sivpt)
                    .HasMaxLength(255)
                    .HasColumnName("SIVPT");

                entity.Property(e => e.Snda1)
                    .HasMaxLength(255)
                    .HasColumnName("SNDA1");

                entity.Property(e => e.Snda2)
                    .HasMaxLength(255)
                    .HasColumnName("SNDA2");

                entity.Property(e => e.Snda3)
                    .HasMaxLength(255)
                    .HasColumnName("SNDA3");

                entity.Property(e => e.Sndaa)
                    .HasMaxLength(255)
                    .HasColumnName("SNDAA");

                entity.Property(e => e.Sndct)
                    .HasMaxLength(255)
                    .HasColumnName("SNDCT");

                entity.Property(e => e.Sndnm)
                    .HasMaxLength(255)
                    .HasColumnName("SNDNM");

                entity.Property(e => e.Sprtm)
                    .HasMaxLength(255)
                    .HasColumnName("SPRTM");

                entity.Property(e => e.Spytm)
                    .HasMaxLength(255)
                    .HasColumnName("SPYTM");

                entity.Property(e => e.Sspcd)
                    .HasMaxLength(255)
                    .HasColumnName("SSPCD");

                entity.Property(e => e.Strtm)
                    .HasMaxLength(255)
                    .HasColumnName("STRTM");

                entity.Property(e => e.Stxam).HasColumnName("STXAM");

                entity.Property(e => e.Stxpc).HasColumnName("STXPC");

                entity.Property(e => e.Supcd)
                    .HasMaxLength(255)
                    .HasColumnName("SUPCD");

                entity.Property(e => e.Taxam).HasColumnName("TAXAM");

                entity.Property(e => e.Taxpc).HasColumnName("TAXPC");

                entity.Property(e => e.Trkno).HasColumnName("TRKNO");

                entity.Property(e => e.Trtrm)
                    .HasMaxLength(255)
                    .HasColumnName("TRTRM");

                entity.Property(e => e.Unloc)
                    .HasMaxLength(255)
                    .HasColumnName("UNLOC");

                entity.Property(e => e.Volum).HasColumnName("VOLUM");

                entity.Property(e => e.Wgtdc)
                    .HasMaxLength(255)
                    .HasColumnName("WGTDC");

                entity.Property(e => e.Wgtum)
                    .HasMaxLength(255)
                    .HasColumnName("WGTUM");
            });

            modelBuilder.Entity<Ed005pr>(entity =>
            {
                entity.ToTable("ED005PR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Corno)
                    .HasMaxLength(255)
                    .HasColumnName("CORNO");

                entity.Property(e => e.Cpdsc)
                    .HasMaxLength(255)
                    .HasColumnName("CPDSC");

                entity.Property(e => e.Cprtn)
                    .HasMaxLength(255)
                    .HasColumnName("CPRTN");

                entity.Property(e => e.Cusno).HasColumnName("CUSNO");

                entity.Property(e => e.Duedt).HasColumnName("DUEDT");

                entity.Property(e => e.House)
                    .HasMaxLength(255)
                    .HasColumnName("HOUSE");

                entity.Property(e => e.Itcls)
                    .HasMaxLength(255)
                    .HasColumnName("ITCLS");

                entity.Property(e => e.Prtno)
                    .HasMaxLength(255)
                    .HasColumnName("PRTNO");

                entity.Property(e => e.Qtunt).HasColumnName("QTUNT");

                entity.Property(e => e.Shdqy).HasColumnName("SHDQY");

                entity.Property(e => e.Shpno).HasColumnName("SHPNO");

                entity.Property(e => e.Shpqy).HasColumnName("SHPQY");

                entity.Property(e => e.Sorno)
                    .HasMaxLength(255)
                    .HasColumnName("SORNO");

                entity.Property(e => e.Trkno).HasColumnName("TRKNO");

                entity.Property(e => e.Unmdc)
                    .HasMaxLength(255)
                    .HasColumnName("UNMDC");

                entity.Property(e => e.Unmsr)
                    .HasMaxLength(255)
                    .HasColumnName("UNMSR");

                entity.Property(e => e.Whslc)
                    .HasMaxLength(255)
                    .HasColumnName("WHSLC");
            });

            modelBuilder.Entity<Edt01pr>(entity =>
            {
                entity.ToTable("EDT01PR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cfmno)
                    .HasMaxLength(255)
                    .HasColumnName("CFMNO");

                entity.Property(e => e.Corno)
                    .HasMaxLength(255)
                    .HasColumnName("CORNO");

                entity.Property(e => e.Cusno).HasColumnName("CUSNO");

                entity.Property(e => e.Cuspo)
                    .HasMaxLength(255)
                    .HasColumnName("CUSPO");

                entity.Property(e => e.Duedt).HasColumnName("DUEDT");

                entity.Property(e => e.Lotno)
                    .HasMaxLength(255)
                    .HasColumnName("LOTNO");

                entity.Property(e => e.Model)
                    .HasMaxLength(255)
                    .HasColumnName("MODEL");

                entity.Property(e => e.Mpflg)
                    .HasMaxLength(255)
                    .HasColumnName("MPFLG");

                entity.Property(e => e.Oqflg)
                    .HasMaxLength(255)
                    .HasColumnName("OQFLG");

                entity.Property(e => e.Orqty).HasColumnName("ORQTY");

                entity.Property(e => e.Shpno).HasColumnName("SHPNO");
            });

            modelBuilder.Entity<Edt31pr>(entity =>
            {
                entity.ToTable("EDT31PR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Boxtp)
                    .HasMaxLength(255)
                    .HasColumnName("BOXTP");

                entity.Property(e => e.Color)
                    .HasMaxLength(255)
                    .HasColumnName("COLOR");

                entity.Property(e => e.Cpdsc)
                    .HasMaxLength(255)
                    .HasColumnName("CPDSC");

                entity.Property(e => e.Cprtn)
                    .HasMaxLength(255)
                    .HasColumnName("CPRTN");

                entity.Property(e => e.Cptyp)
                    .HasMaxLength(255)
                    .HasColumnName("CPTYP");

                entity.Property(e => e.Cusno).HasColumnName("CUSNO");

                entity.Property(e => e.Cuspo)
                    .HasMaxLength(255)
                    .HasColumnName("CUSPO");

                entity.Property(e => e.Duedt).HasColumnName("DUEDT");

                entity.Property(e => e.Duetm).HasColumnName("DUETM");

                entity.Property(e => e.Ecnno)
                    .HasMaxLength(255)
                    .HasColumnName("ECNNO");

                entity.Property(e => e.Ecntg)
                    .HasMaxLength(255)
                    .HasColumnName("ECNTG");

                entity.Property(e => e.Fllr1)
                    .HasMaxLength(255)
                    .HasColumnName("FLLR1");

                entity.Property(e => e.Gate)
                    .HasMaxLength(255)
                    .HasColumnName("GATE");

                entity.Property(e => e.Lotno)
                    .HasMaxLength(255)
                    .HasColumnName("LOTNO");

                entity.Property(e => e.Lotsz).HasColumnName("LOTSZ");

                entity.Property(e => e.Model)
                    .HasMaxLength(255)
                    .HasColumnName("MODEL");

                entity.Property(e => e.Nobox).HasColumnName("NOBOX");

                entity.Property(e => e.Odued).HasColumnName("ODUED");

                entity.Property(e => e.Oduet).HasColumnName("ODUET");

                entity.Property(e => e.Olotn)
                    .HasMaxLength(255)
                    .HasColumnName("OLOTN");

                entity.Property(e => e.Oshft)
                    .HasMaxLength(255)
                    .HasColumnName("OSHFT");

                entity.Property(e => e.Pilot)
                    .HasMaxLength(255)
                    .HasColumnName("PILOT");

                entity.Property(e => e.Piltg)
                    .HasMaxLength(255)
                    .HasColumnName("PILTG");

                entity.Property(e => e.Prcdt).HasColumnName("PRCDT");

                entity.Property(e => e.Procs)
                    .HasMaxLength(255)
                    .HasColumnName("PROCS");

                entity.Property(e => e.Rcloc)
                    .HasMaxLength(255)
                    .HasColumnName("RCLOC");

                entity.Property(e => e.Revid)
                    .HasMaxLength(255)
                    .HasColumnName("REVID");

                entity.Property(e => e.Rsvf0)
                    .HasMaxLength(255)
                    .HasColumnName("RSVF0");

                entity.Property(e => e.Rsvf1)
                    .HasMaxLength(255)
                    .HasColumnName("RSVF1");

                entity.Property(e => e.Rsvf10)
                    .HasMaxLength(255)
                    .HasColumnName("RSVF10");

                entity.Property(e => e.Rsvf2)
                    .HasMaxLength(255)
                    .HasColumnName("RSVF2");

                entity.Property(e => e.Rsvf3)
                    .HasMaxLength(255)
                    .HasColumnName("RSVF3");

                entity.Property(e => e.Rsvf4)
                    .HasMaxLength(255)
                    .HasColumnName("RSVF4");

                entity.Property(e => e.Rsvf5)
                    .HasMaxLength(255)
                    .HasColumnName("RSVF5");

                entity.Property(e => e.Rsvf6)
                    .HasMaxLength(255)
                    .HasColumnName("RSVF6");

                entity.Property(e => e.Rsvf7)
                    .HasMaxLength(255)
                    .HasColumnName("RSVF7");

                entity.Property(e => e.Rsvf8)
                    .HasMaxLength(255)
                    .HasColumnName("RSVF8");

                entity.Property(e => e.Rsvf9)
                    .HasMaxLength(255)
                    .HasColumnName("RSVF9");

                entity.Property(e => e.Sbprt)
                    .HasMaxLength(255)
                    .HasColumnName("SBPRT");

                entity.Property(e => e.Sbsup)
                    .HasMaxLength(255)
                    .HasColumnName("SBSUP");

                entity.Property(e => e.Shift)
                    .HasMaxLength(255)
                    .HasColumnName("SHIFT");

                entity.Property(e => e.Shpno).HasColumnName("SHPNO");

                entity.Property(e => e.Shqty).HasColumnName("SHQTY");

                entity.Property(e => e.Strsq).HasColumnName("STRSQ");

                entity.Property(e => e.Supcd)
                    .HasMaxLength(255)
                    .HasColumnName("SUPCD");

                entity.Property(e => e.Supnm)
                    .HasMaxLength(255)
                    .HasColumnName("SUPNM");

                entity.Property(e => e.Whloc)
                    .HasMaxLength(255)
                    .HasColumnName("WHLOC");
            });

            modelBuilder.Entity<ElementMatching>(entity =>
            {
                entity.ToTable("element_matching");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClearanceC1).HasColumnName("clearance_c1");

                entity.Property(e => e.ClearanceC2).HasColumnName("clearance_c2");

                entity.Property(e => e.ClearanceC3).HasColumnName("clearance_c3");

                entity.Property(e => e.CylinderA).HasColumnName("cylinder_a");

                entity.Property(e => e.CylinderB).HasColumnName("cylinder_b");

                entity.Property(e => e.CylinderC).HasColumnName("cylinder_c");

                entity.Property(e => e.CylinderMarkingDate).HasColumnName("cylinder_marking_date");

                entity.Property(e => e.CylinderSn)
                    .HasMaxLength(255)
                    .HasColumnName("cylinder_sn");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.PlungerA).HasColumnName("plunger_a");

                entity.Property(e => e.PlungerB).HasColumnName("plunger_b");

                entity.Property(e => e.PlungerC).HasColumnName("plunger_c");

                entity.Property(e => e.PlungerMarkingDate).HasColumnName("plunger_marking_date");

                entity.Property(e => e.PlungerSn)
                    .HasMaxLength(255)
                    .HasColumnName("plunger_sn");

                entity.Property(e => e.QrCylinder)
                    .HasMaxLength(255)
                    .HasColumnName("qr_cylinder");

                entity.Property(e => e.QrPlunger)
                    .HasMaxLength(255)
                    .HasColumnName("qr_plunger");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<FinalInspectionMatchSerial>(entity =>
            {
                entity.ToTable("final_inspection_match_serial");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerPartNo)
                    .HasMaxLength(255)
                    .HasColumnName("customer_part_no");

                entity.Property(e => e.CylinderSerialCutFromJ)
                    .HasMaxLength(255)
                    .HasColumnName("cylinder_serial(cut from J)");

                entity.Property(e => e.DataQrCode1PumpStickerOrPumpNamePlateOrPumpSerialNu)
                    .HasMaxLength(255)
                    .HasColumnName("data_qr_code_1(Pump sticker OR pump name plate OR pump serial nu");

                entity.Property(e => e.DataQrCode2ReadFromCycliderLaserMark)
                    .HasMaxLength(255)
                    .HasColumnName("data_qr_code_2(read from cyclider laser mark)");

                entity.Property(e => e.DataSn1CutFromI)
                    .HasMaxLength(255)
                    .HasColumnName("data_sn_1(cut from I)");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.DensoPartNoPumpPartNumber).HasColumnName("denso_part_no(pump part number)");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Serial).HasColumnName("serial");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.Times)
                    .HasColumnType("datetime")
                    .HasColumnName("times");

                entity.Property(e => e.Year)
                    .HasMaxLength(255)
                    .HasColumnName("year");

                entity.Property(e => e.Ymd)
                    .HasColumnType("datetime")
                    .HasColumnName("ymd");
            });

            modelBuilder.Entity<Inspection>(entity =>
            {
                entity.ToTable("inspection");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CrPressure).HasColumnName("cr_pressure");

                entity.Property(e => e.DOne).HasColumnName("d_one");

                entity.Property(e => e.DeviceMode)
                    .HasMaxLength(255)
                    .HasColumnName("device_mode");

                entity.Property(e => e.DeviceTimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("device_timestamp");

                entity.Property(e => e.DriveMotorTorque).HasColumnName("drive_motor_torque");

                entity.Property(e => e.DriveMotorTorqueMax).HasColumnName("drive_motor_torque_max");

                entity.Property(e => e.DriveMotorTorquePeak).HasColumnName("drive_motor_torque_peak");

                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .HasColumnName("file_name");

                entity.Property(e => e.ImportTime)
                    .HasColumnType("datetime")
                    .HasColumnName("import_time");

                entity.Property(e => e.InsCode).HasColumnName("ins_code");

                entity.Property(e => e.InspecTime).HasColumnName("inspec_time");

                entity.Property(e => e.Judge).HasColumnName("judge");

                entity.Property(e => e.Model).HasColumnName("model");

                entity.Property(e => e.OverallJudge).HasColumnName("overall_judge");

                entity.Property(e => e.Ovf).HasColumnName("ovf");

                entity.Property(e => e.OvfKisa).HasColumnName("ovf_kisa");

                entity.Property(e => e.OvfTmep).HasColumnName("ovf_tmep");

                entity.Property(e => e.PalletNo).HasColumnName("pallet_no");

                entity.Property(e => e.PcvMax).HasColumnName("pcv_max");

                entity.Property(e => e.PcvMin).HasColumnName("pcv_min");

                entity.Property(e => e.Q).HasColumnName("q");

                entity.Property(e => e.QKisa).HasColumnName("q_kisa");

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(255)
                    .HasColumnName("serial_no");

                entity.Property(e => e.SettingTime).HasColumnName("setting_time");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.SpeedTime).HasColumnName("speed_time");

                entity.Property(e => e.StationNo).HasColumnName("station_no");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.TfOut).HasColumnName("tf_out");

                entity.Property(e => e.X1).HasColumnName("x1");

                entity.Property(e => e.X2).HasColumnName("x2");
            });

            modelBuilder.Entity<Pdi>(entity =>
            {
                entity.ToTable("pdi");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActualReadTime).HasMaxLength(255);

                entity.Property(e => e.CustomerNo).HasMaxLength(255);

                entity.Property(e => e.DeliveryDate).HasMaxLength(255);

                entity.Property(e => e.FinishTime).HasColumnType("datetime");

                entity.Property(e => e.FractionLotNo)
                    .HasMaxLength(255)
                    .HasColumnName("Fraction_Lot_No");

                entity.Property(e => e.FractionQty)
                    .HasMaxLength(255)
                    .HasColumnName("Fraction_Qty");

                entity.Property(e => e.FromProCode).HasMaxLength(255);

                entity.Property(e => e.IssueNo).HasMaxLength(255);

                entity.Property(e => e.LineCode).HasMaxLength(255);

                entity.Property(e => e.MergedText).HasColumnName("Merged Text");

                entity.Property(e => e.NextProCode).HasMaxLength(255);

                entity.Property(e => e.Nextprocessname).HasMaxLength(255);

                entity.Property(e => e.PartsName).HasMaxLength(255);

                entity.Property(e => e.PartsNo)
                    .HasMaxLength(255)
                    .HasColumnName("PartsNO");

                entity.Property(e => e.Pcnumber)
                    .HasMaxLength(255)
                    .HasColumnName("PCnumber");

                entity.Property(e => e.Prev1ProCode).HasMaxLength(255);

                entity.Property(e => e.Prev1ProLotNo).HasMaxLength(255);

                entity.Property(e => e.Prev2ProCode).HasMaxLength(255);

                entity.Property(e => e.Prev2ProLotNo).HasMaxLength(255);

                entity.Property(e => e.Prev2ProPartsNo).HasMaxLength(255);

                entity.Property(e => e.PrintQty).HasColumnName("Print_Qty");

                entity.Property(e => e.ProcessCode).HasMaxLength(255);

                entity.Property(e => e.ReissueFlg).HasColumnName("Reissue_Flg");

                entity.Property(e => e.RowInOriginalSheet).HasColumnName("Row in Original Sheet");

                entity.Property(e => e.SiftCode).HasMaxLength(255);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SupplierCode).HasMaxLength(255);

                entity.Property(e => e.SupplierLotno).HasMaxLength(255);

                entity.Property(e => e.SupplierPartsNo).HasMaxLength(255);

                entity.Property(e => e.SystemDate).HasColumnType("datetime");

                entity.Property(e => e.TraceLotNo)
                    .HasMaxLength(255)
                    .HasColumnName("traceLotNo");

                entity.Property(e => e.WorkingDate).HasColumnType("datetime");

                entity.Property(e => e._5mecode)
                    .HasMaxLength(255)
                    .HasColumnName("5MECode");
            });

            modelBuilder.Entity<Qrshippinglog>(entity =>
            {
                entity.ToTable("QRSHIPPINGLOG");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CheckType).HasColumnName("CHECK TYPE");

                entity.Property(e => e.CustNo).HasColumnName("CUST NO");

                entity.Property(e => e.CustPN)
                    .HasMaxLength(255)
                    .HasColumnName("CUST P/N");

                entity.Property(e => e.DevId).HasColumnName("DEV ID");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(255)
                    .HasColumnName("LOGIN ID");

                entity.Property(e => e.OpeSeq)
                    .HasMaxLength(255)
                    .HasColumnName("OPE SEQ #");

                entity.Property(e => e.PN)
                    .HasMaxLength(255)
                    .HasColumnName("P/N");

                entity.Property(e => e.Qty)
                    .HasMaxLength(255)
                    .HasColumnName("QTY");

                entity.Property(e => e.Result).HasColumnName("RESULT");

                entity.Property(e => e.RsnCode).HasColumnName("RSN CODE");

                entity.Property(e => e.ScanDateYmd).HasColumnName("SCAN DATE(YMD)");

                entity.Property(e => e.ScanTime).HasColumnName("SCAN TIME");

                entity.Property(e => e.Seq).HasColumnName("SEQ #");

                entity.Property(e => e.ShipNo)
                    .HasMaxLength(255)
                    .HasColumnName("SHIP NO");

                entity.Property(e => e.ShipPN)
                    .HasMaxLength(255)
                    .HasColumnName("SHIP P/N");

                entity.Property(e => e.ShipQty)
                    .HasMaxLength(255)
                    .HasColumnName("SHIP QTY");

                entity.Property(e => e.Sysflg1)
                    .HasMaxLength(255)
                    .HasColumnName("SYSFLG1");

                entity.Property(e => e.Sysflg2)
                    .HasMaxLength(255)
                    .HasColumnName("SYSFLG2");

                entity.Property(e => e.Sysflg3)
                    .HasMaxLength(255)
                    .HasColumnName("SYSFLG3");

                entity.Property(e => e.Sysflg4)
                    .HasMaxLength(255)
                    .HasColumnName("SYSFLG4");

                entity.Property(e => e.TagSeq)
                    .HasMaxLength(255)
                    .HasColumnName("TAG SEQ #");

                entity.Property(e => e.TagType)
                    .HasMaxLength(255)
                    .HasColumnName("TAG TYPE");

                entity.Property(e => e.TrDateYmd).HasColumnName("TR DATE(YMD)");

                entity.Property(e => e.TrType).HasColumnName("TR TYPE");

                entity.Property(e => e.TruckNo)
                    .HasMaxLength(255)
                    .HasColumnName("TRUCK NO");

                entity.Property(e => e.WH)
                    .HasMaxLength(255)
                    .HasColumnName("W/H #");
            });

            modelBuilder.Entity<Ud24pr>(entity =>
            {
                entity.ToTable("UD@24PR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aed424).HasColumnName("AED424");

                entity.Property(e => e.Aet424).HasColumnName("AET424");

                entity.Property(e => e.Asn424)
                    .HasMaxLength(255)
                    .HasColumnName("ASN424");

                entity.Property(e => e.Crd424).HasColumnName("CRD424");

                entity.Property(e => e.Crt424).HasColumnName("CRT424");

                entity.Property(e => e.Pea424).HasColumnName("PEA424");

                entity.Property(e => e.Pet424).HasColumnName("PET424");

                entity.Property(e => e.Pfg424)
                    .HasMaxLength(255)
                    .HasColumnName("PFG424");

                entity.Property(e => e.Plt424)
                    .HasMaxLength(255)
                    .HasColumnName("PLT424");

                entity.Property(e => e.Scn424)
                    .HasMaxLength(255)
                    .HasColumnName("SCN424");

                entity.Property(e => e.Sts424)
                    .HasMaxLength(255)
                    .HasColumnName("STS424");

                entity.Property(e => e.Sup424)
                    .HasMaxLength(255)
                    .HasColumnName("SUP424");

                entity.Property(e => e.Tnm424)
                    .HasMaxLength(255)
                    .HasColumnName("TNM424");

                entity.Property(e => e.Udp424)
                    .HasMaxLength(255)
                    .HasColumnName("UDP424");

                entity.Property(e => e.Udu424)
                    .HasMaxLength(255)
                    .HasColumnName("UDU424");

                entity.Property(e => e.Upd424).HasColumnName("UPD424");

                entity.Property(e => e.Upt424).HasColumnName("UPT424");
            });

            modelBuilder.Entity<Ud25pr>(entity =>
            {
                entity.ToTable("UD@25PR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Asn425)
                    .HasMaxLength(255)
                    .HasColumnName("ASN425");

                entity.Property(e => e.Ccd425)
                    .HasMaxLength(255)
                    .HasColumnName("CCD425");

                entity.Property(e => e.Cod425)
                    .HasMaxLength(255)
                    .HasColumnName("COD425");

                entity.Property(e => e.Crd425).HasColumnName("CRD425");

                entity.Property(e => e.Crt425).HasColumnName("CRT425");

                entity.Property(e => e.Dud425).HasColumnName("DUD425");

                entity.Property(e => e.Ins425)
                    .HasMaxLength(255)
                    .HasColumnName("INS425");

                entity.Property(e => e.Lan425)
                    .HasMaxLength(255)
                    .HasColumnName("LAN425");

                entity.Property(e => e.Pfg425)
                    .HasMaxLength(255)
                    .HasColumnName("PFG425");

                entity.Property(e => e.Plt425)
                    .HasMaxLength(255)
                    .HasColumnName("PLT425");

                entity.Property(e => e.Prn425)
                    .HasMaxLength(255)
                    .HasColumnName("PRN425");

                entity.Property(e => e.Rcd425).HasColumnName("RCD425");

                entity.Property(e => e.Rcq425).HasColumnName("RCQ425");

                entity.Property(e => e.Rmq425).HasColumnName("RMQ425");

                entity.Property(e => e.Sdo425)
                    .HasMaxLength(255)
                    .HasColumnName("SDO425");

                entity.Property(e => e.Spq425).HasColumnName("SPQ425");

                entity.Property(e => e.Sts425)
                    .HasMaxLength(255)
                    .HasColumnName("STS425");

                entity.Property(e => e.Sup425)
                    .HasMaxLength(255)
                    .HasColumnName("SUP425");

                entity.Property(e => e.Udp425)
                    .HasMaxLength(255)
                    .HasColumnName("UDP425");

                entity.Property(e => e.Udu425)
                    .HasMaxLength(255)
                    .HasColumnName("UDU425");

                entity.Property(e => e.Upd425).HasColumnName("UPD425");

                entity.Property(e => e.Upt425).HasColumnName("UPT425");

                entity.Property(e => e.Var425)
                    .HasMaxLength(255)
                    .HasColumnName("VAR425");

                entity.Property(e => e.Whc425)
                    .HasMaxLength(255)
                    .HasColumnName("WHC425");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

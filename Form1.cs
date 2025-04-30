using testsca.Classes;
using testsca.Output;

namespace testsca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SdmOut sdmOut = new SdmOut();

            var searchdata = textBox1.Text.Trim();
            if (searchdata == null || searchdata.Length == 0) { return; }


            if (textBox1.Text.Length == 7)
            {
                //(string pditag, string finishgoods) = PDI_search(searchdata);
                var pdi_data = SearchFn.PDI_search_Tag_serial(searchdata);

                var pdi_one_row = pdi_data.FirstOrDefault();
                if (pdi_one_row == null) return;
                var finshedGoods = pdi_one_row.FinishGoodsNo;
                sdmOut.ModelName = pdi_one_row.Pcnumber;
                sdmOut.SerialNo = pdi_one_row.FinishGoodsNo;
                var finalInspection = SearchFn.Final_search_finishgoods(finshedGoods);

                var finalInspection_one_row = finalInspection.FirstOrDefault();
                if (finalInspection_one_row == null) { return; }

                final_cylinder.Text = finalInspection_one_row.CylinderSerialNo;
                var pn = finalInspection_one_row.DensoPartNoPumpPartNumber.ToString();
                var len = pn.Length;
                if (len == 10)
                {
                    var pn2 = pn.Insert(10 - 4, "-");
                    final_pump_part.Text = pn2;
                    sdmOut.PartNo = pn2;
                }
                final_timet.Text = finalInspection_one_row.Datetime.ToString("yyyy-MM-dd");
                final_finish.Text = finalInspection_one_row.Datetime.ToString("HH:mm:ss");
                sdmOut.ProductionDate = final_timet.Text;
                //richTextBox1.Text = JsonConvert.SerializeObject(data, Formatting.Indented);


                var inspOut = SearchFn.Inspection_search_cylinderserialno(finalInspection_one_row.CylinderSerialNo);
                var insp_one_row = inspOut.FirstOrDefault();
                if (insp_one_row == null) return;
                textBox2.Text = $"299090-00{insp_one_row.Model.ToString()}";
                textBox5.Text = insp_one_row.SerialNo;
                textBox3.Text = insp_one_row.DeviceTimestamp.ToString("yyyy-MM-dd");
                textBox4.Text = insp_one_row.DeviceTimestamp.ToString("HH:mm:ss");


                var grindingOut = SearchFn.Grinding_search_cylinderserialno(finalInspection_one_row.CylinderSerialNo);
                var grinding_one_row = grindingOut.FirstOrDefault();
                if (grinding_one_row == null) return;
                textBox6.Text = $"299090-{grinding_one_row.Model.ToString()}";
                textBox9.Text = grinding_one_row.SerialNo;
                textBox7.Text = grinding_one_row.DateTime.ToString("yyyy-MM-dd");
                textBox8.Text = grinding_one_row.DateTime.ToString("HH:mm:ss");


                textBox26.Text = "SDM:Final Insp.";
                textBox27.Text = sdmOut.SerialNo;
                textBox28.Text = sdmOut.PartNo;
                textBox29.Text = sdmOut.PartName;
                textBox30.Text = sdmOut.ModelName;
                textBox31.Text = sdmOut.ProductionDate;

            }
            else if (textBox1.Text.Length == 8)
            {
                //Final_search(searchdata);


            }

        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            var tracefwd = new Traceforward();
            tracefwd.Show();
        }
    }
}

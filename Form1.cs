using testsca.Models;

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
            tag_serial_no.Text = "";
            trace_lot_no.Text = "";
            pdi_partnumber.Text = "";
            final_pump_part.Text = "";
            final_timet.Text = "";
            final_cylinder.Text = "";
            final_finish.Text = "";

            var searchdata = textBox1.Text.Trim();
            if (searchdata == null || searchdata.Length == 0) { return; }


            if (textBox1.Text.Length == 7)
            {
               (string pditag,string finishgoods ) =  PDI_search(searchdata);


            }
            else if (textBox1.Text.Length == 8)
            {
                Final_search(searchdata);


            }

        }



        private (string , string ) PDI_search(string searchdata)
        {
            try
            {
                using (var db = new scaContext())
                {
                    var tag = Convert.ToDouble(searchdata);
                    var tagserialno = db.Pdis.Where(x => x.TagSerialNo == tag).ToList();
                    if (tagserialno.Count > 0)
                    {
                        var pdidata = tagserialno.FirstOrDefault();

                        tag_serial_no.Text = pdidata?.TagSerialNo.ToString();
                        trace_lot_no.Text = pdidata?.TraceLotNo;
                        pdi_partnumber.Text = pdidata?.PartsNo;

                        return tag_serial_no.Text , pdidata?.TraceLotNo;
                    }
                }
            }
            catch
            {

                return ("", "");
            }

        }
        private void Final_search(string searchdata)
        {
            using (var db = new scaContext())
            {
                var data = db.FinalInspectionMatchSerials.
                    Where(x => x.DataSn1CutFromI == searchdata || x.CylinderSerialCutFromJ == searchdata).ToList();

                if (data.Count > 0)
                {
                    var finaltable = data.FirstOrDefault();

                    final_pump_part.Text = finaltable?.DensoPartNoPumpPartNumber.ToString();
                    final_timet.Text = finaltable?.Datetime.ToString();
                    final_cylinder.Text = finaltable?.CylinderSerialCutFromJ;
                    final_finish.Text = finaltable?.DataSn1CutFromI;
                }
            }
        }


    }
}

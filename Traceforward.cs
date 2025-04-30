using testsca.Classes;

namespace testsca
{
    public partial class Traceforward : Form
    {
        public Traceforward()
        {
            InitializeComponent();
        }

        private void Traceforward_Load(object sender, EventArgs e)
        {
            string[] hearder = new string[] { "Lot No", "Q'TY" };
            int[] width = new int[] { 100, 80 };

            InitDgv.Pattern_1(dataGridView1, hearder, width);
            InitDgv.Pattern_1(dataGridView2, hearder, width);
            InitDgv.Pattern_1(dataGridView3, hearder, width);
            InitDgv.Pattern_1(dataGridView4, hearder, width);
            InitDgv.Pattern_1(dataGridView5, hearder, width);
            InitDgv.Pattern_1(dataGridView6, hearder, width);
            InitDgv.Pattern_1(dataGridView7, hearder, width);
            InitDgv.Pattern_1(dataGridView8, hearder, width);
            InitDgv.Pattern_1(dataGridView9, hearder, width);
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            var input = txtSerial.Text.Trim();
            if (input == null || input.Length == 0) return;

            var fromdatetime = dateTimePicker1.Value.Date + dateTimePicker4.Value.TimeOfDay;
            var todatetime = dateTimePicker2.Value.Date + dateTimePicker5.Value.TimeOfDay;

            if (radioButton1.Checked) // Trace lot no
            { }
            else if (radioButton2.Checked) // Trace lot no + DateTime
            { }
            else if (radioButton3.Checked) // Serial no
            { }
            else if (radioButton4.Checked)  // Serial no + DateTime
            { }


        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}

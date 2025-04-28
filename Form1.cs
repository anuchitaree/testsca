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
            using (var db = new scaContext()) 
            { 
                var pdi = db.Pdis.ToList();
            }
        }
    }
}

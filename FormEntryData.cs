using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasKalkulator
{
    public partial class FormEntryData : Form
    {
        private IList<Calculator> dataCalc = new List<Calculator>();

        public FormEntryData()
        {
            InitializeComponent();
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            FormData kalkulator = new FormData();
            kalkulator.OnCreate += KalKulator_OnCreate;
            kalkulator.ShowDialog();
        }

        private void KalKulator_OnCreate(Calculator data)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            dataCalc.Add(data);
            listHasil.Items.Add(data.Hasil);
        }

        private void FormEntryData_Load(object sender, EventArgs e)
        {

        }
    }
}

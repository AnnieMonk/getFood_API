using getFood_UI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getFood_UI.Izvještaji
{
    public partial class frmUpitDatum : Form
    {
        int restoranId;
        public frmUpitDatum(int _restoranId)
        {
            InitializeComponent();
            restoranId = _restoranId;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzvještaj_Click(object sender, EventArgs e)
        {
            var _datumOd = Convert.ToDateTime(DatumOd.Value);
            var _datumDo = Convert.ToDateTime(DatumDo.Value);
            BestSoldFood bsf = new BestSoldFood(_datumOd, _datumDo, restoranId);
            bsf.Show();

            this.Close();
        }
    }
}

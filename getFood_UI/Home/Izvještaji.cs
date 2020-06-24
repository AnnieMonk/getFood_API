using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using getFood_UI.Izvještaji;
using getFood_UI.Reports;

namespace getFood_UI.Home
{
    public partial class Izvještaji : UserControl
    {
        int restoranId = Global.prijavljeniRestoran.RestoranId;
      
        public Izvještaji()
        {
            InitializeComponent();
        }

        private void btnBestFood_Click(object sender, EventArgs e)
        {
            frmUpitDatum frm = new frmUpitDatum(restoranId);
            frm.Show();
        }

        private void btnGodisnjiPromet_Click(object sender, EventArgs e)
        {
            GodisnjiPromet frm = new GodisnjiPromet(restoranId);
            frm.Show();
        }

        private void btnPrometPoDanu_Click(object sender, EventArgs e)
        {
            PrometPoDanu rpt = new PrometPoDanu(restoranId);
            rpt.Show();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            Reports.Rezervacije rpt = new Reports.Rezervacije(restoranId);
            rpt.Show();
        }

        private void btnIzdavanjeRacuna_Click(object sender, EventArgs e)
        {
            frmUpitKorisnik frm = new frmUpitKorisnik(restoranId);
            frm.Show();
        }
    }
}

using getFood_Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getFood_UI.Reports
{
    public partial class NarudzbeDetails : Form
    {
        public MNarudzba _narudzba = null;
        public NarudzbeDetails(MNarudzba narudzba)
        {
            InitializeComponent();
            _narudzba = narudzba;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("dbNarudzbeDetails", _narudzba.NarudzbaStavke);

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Kupac", _narudzba.Ime + " " + _narudzba.Prezime));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BrojNarudzbe", _narudzba.BrojNarudzbe));
            this.reportViewer1.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

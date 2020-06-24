using getFood_Model;
using getFood_Model.Requests;
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
    public partial class GodisnjiPromet : Form
    {
       
        private int _restoranId;
        private readonly APIService _serviceIzlazStavke = new APIService("IzlazStavke");
        public GodisnjiPromet( int restoranId)
        {
            InitializeComponent();
            _restoranId = restoranId;
        }

        private async void GodisnjiPromet_Load(object sender, EventArgs e)
        {
            var _godina = godina.Value.Year.ToString();
            var izlazStavke = await _serviceIzlazStavke.Get<List<MIzlazStavke>>(new IzlazStavkeSearchRequest { RestoranId = _restoranId, godina = _godina });

            ReportDataSource source = new ReportDataSource("dbGodPromet", izlazStavke);

            rptGodisnjiPromet.LocalReport.DataSources.Add(source);
            rptGodisnjiPromet.LocalReport.SetParameters(new ReportParameter("Year", _godina));
           


            this.rptGodisnjiPromet.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void godina_ValueChanged(object sender, EventArgs e)
        {
            rptGodisnjiPromet.Clear();
            GodisnjiPromet_Load(sender, e);
        }
    }
}

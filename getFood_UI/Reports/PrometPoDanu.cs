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
    public partial class PrometPoDanu : Form
    {
        int _restoranId;
        private readonly APIService _serviceIzlazStavke = new APIService("IzlazStavke");
        public PrometPoDanu(int restoranId)
        {
            InitializeComponent();
            _restoranId = restoranId;
        }
       
        private async void PrometPoDanu_Load(object sender, EventArgs e)
        {
             string _datum = datum.Value.Date.ToString("dd/MM/yyyy");
            var izlazStavke = await _serviceIzlazStavke.Get<List<MIzlazStavke>>(new IzlazStavkeSearchRequest { RestoranId=_restoranId, TacanDatum=_datum});

            ReportDataSource source = new ReportDataSource("dbPrometPoDanu", izlazStavke);

            this.reportViewer1.LocalReport.DataSources.Add(source);
            
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Datum", _datum));

            this.reportViewer1.RefreshReport();
        }

        private void datum_ValueChanged(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            PrometPoDanu_Load(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

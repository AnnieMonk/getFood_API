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
    public partial class BestSoldFood : Form
    {
        private DateTime _datumOd;
        private DateTime _datumDo;
        private int _restoranId;
        private readonly APIService _serviceIzlazStavke = new APIService("IzlazStavke");

        public BestSoldFood(DateTime datumOd, DateTime datumDo, int restoranId)
        {
            InitializeComponent();
            _datumOd = datumOd;
            _datumDo = datumDo;
            _restoranId = restoranId;
        }

        private async void BestSoldFood_Load(object sender, EventArgs e)
        {
            var izlazStavke = await _serviceIzlazStavke.Get<List<MIzlazStavke>>(new IzlazStavkeSearchRequest { Od = _datumOd, Do = _datumDo, RestoranId=_restoranId });
            //datume
            var distinct = izlazStavke.GroupBy(x => x.ProduktiId, (key, group) => new { 
                ProduktiId = key,
                BrojRacuna= group.Select(x=>x.BrojRacuna).First(),
                Naziv=group.Select(x=>x.Naziv).First(),
                Opis=group.Select(x=>x.Opis).First(),
                Datum=group.Select(x=>x.Datum).First(),
                Kolicina = group.Sum(x=>x.Kolicina)
            });

            //distinktne proizvode

            ReportDataSource rds = new ReportDataSource("dbBestSoldFood", distinct);

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumOd", _datumOd.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumDo", _datumDo.ToString()));
            this.reportViewer1.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

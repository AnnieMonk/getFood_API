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
    public partial class IzdavanjeRacuna : Form
    {
        string _brojRacuna;
        int _restoranId;
        int _korisnikId;
        private readonly APIService _serviceIzlazStavke = new APIService("IzlazStavke");
        private readonly APIService _serviceKorisnik = new APIService("Korisnik");
        public IzdavanjeRacuna(string brojRacuna, int restoranId, int korisnikId)
        {
            InitializeComponent();
            _brojRacuna = brojRacuna;
            _restoranId = restoranId;
            _korisnikId = korisnikId;
        }

        private async void IzdavanjeRacuna_Load(object sender, EventArgs e)
        {
            var korisnik = await _serviceKorisnik.GetById<MKorisnik>(_korisnikId);
            var izlazStavke = await _serviceIzlazStavke.Get<List<MIzlazStavke>>(new IzlazStavkeSearchRequest { RestoranId=_restoranId, BrojRacuna = _brojRacuna });

            ReportDataSource source = new ReportDataSource("dbIzdavanjeRacuna", izlazStavke);

            this.reportViewer1.LocalReport.DataSources.Add(source);

            var datum = izlazStavke.Select(i => i.Datum).First();
            
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BrojRacuna", _brojRacuna));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Datum", datum.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Korisnik", korisnik.Ime + " " + korisnik.Prezime));


            this.reportViewer1.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

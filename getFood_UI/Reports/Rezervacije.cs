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
    public partial class Rezervacije : Form
    {
        int _restoranid;
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");
        private readonly APIService _serviceKorisnik = new APIService("Korisnik");
       
        public Rezervacije(int restoranId)
        {
            InitializeComponent();
            _restoranid = restoranId;
          
        }

        private async Task LoadKorisnike()
        {
            var result = await _serviceKorisnik.Get<List<MKorisnik>>(null);
            result.Insert(0, new MKorisnik() { Ime="Svi korisnici"});

            cmbKorisnici.DataSource = result;
            cmbKorisnici.DisplayMember = "FullName";
            cmbKorisnici.ValueMember = "KorisnikId";
        }

        private async Task LoadRezervacije(int? _korisnikId)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();

            string korisnikstring = null;
            List<MRezervacije> rezervacije = new List<MRezervacije>();
            if (_korisnikId == null || _korisnikId == 0)
            {
                rezervacije = await _serviceRezervacije.Get<List<MRezervacije>>(new RezervacijeSearchRequest { RestoranId = _restoranid });
                korisnikstring = "Svi korisnici";
               

            }
            else if (_korisnikId != null || _korisnikId != 0)

            {

               rezervacije = await _serviceRezervacije.Get<List<MRezervacije>>(new RezervacijeSearchRequest { RestoranId = _restoranid, KorisnikId = _korisnikId });
                

                var korisnik = await _serviceKorisnik.GetById<MKorisnik>(_korisnikId);
                korisnikstring = korisnik.Ime + " " + korisnik.Prezime;

            }
            ReportDataSource source = new ReportDataSource("dbRezervacije", rezervacije);

            this.reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Korisnik", korisnikstring));

            this.reportViewer1.RefreshReport();
        }
        private async void Rezervacije_Load(object sender, EventArgs e)
        {
            await LoadKorisnike();
            await LoadRezervacije(null);
        }

        private async void cmbKorisnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbKorisnici.SelectedValue;
           
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadRezervacije(id);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

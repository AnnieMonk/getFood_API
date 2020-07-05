using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using getFood_UI.Home;


namespace getFood_UI.Rezervacije
{
    public partial class frmPregledRezervacije : Form
    {
        private readonly APIService _serviceRezervacija = new APIService("Rezervacije");
        private readonly APIService _serviceKorisnik = new APIService("Korisnik");

        private int RestoranID = Global.prijavljeniRestoran.RestoranId;
        private int? _rezervacijaId = null;

        public getFood_UI.Home.Rezervacije rezervacije;
        public frmPregledRezervacije(getFood_UI.Home.Rezervacije _rezervacije, int? rezervacijaId = null)
        {
           
            _rezervacijaId = rezervacijaId;
            rezervacije = _rezervacije;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmPregledRezervacije_Load(object sender, EventArgs e)
        {
            await LoadRezervaciju();
        }
        private async Task LoadRezervaciju()
        {
            var rezervacijaResult = await _serviceRezervacija.GetById<MRezervacije>(_rezervacijaId);
            var korisnikResult = await _serviceKorisnik.GetById<MKorisnik>(rezervacijaResult.KorisnikId);
           
            //var statusResult = await _serviceStatus.GetById<MStatus>(rezervacijaResult.StatusId);

            txtIme.Text = korisnikResult.Ime;
            txtPrezime.Text = korisnikResult.Prezime;
            txtTelefon.Text = korisnikResult.Telefon;
            dateTime.Value = rezervacijaResult.DatumVrijeme;
            numBrojljudi.Value = rezervacijaResult.BrojLjudi;
            txtNapomena.Text = rezervacijaResult.Napomena;
          
            if(rezervacijaResult.StatusId == 1)
            {
                chbPotvrdjeno.Checked = false;
                chbOtkazano.Checked = true;
            }
            else if(rezervacijaResult.StatusId == 2)
            {
                chbOtkazano.Checked = false;
                chbPotvrdjeno.Checked = true;
                
            }
            else
            {
                chbPotvrdjeno.Checked = false;
                chbOtkazano.Checked = false;
            }
        }


       
        private async void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (chbPotvrdjeno.Checked == false)
            {
                RezervacijeUpsertRequest request = new RezervacijeUpsertRequest();
                var rez = await _serviceRezervacija.GetById<MRezervacije>(_rezervacijaId);

                request.KorisnikId = rez.KorisnikId;
                request.DatumVrijeme = dateTime.Value;
                request.Napomena = rez.Napomena;
                request.BrojLjudi = Convert.ToInt32(numBrojljudi.Value);
                request.RestoranId = RestoranID;
                request.StatusId = 2;
              
                await _serviceRezervacija.Update<MRezervacije>(_rezervacijaId, request);

                await LoadRezervaciju();

                await rezervacije.LoadRezervacije();
               
            }
            else
            {
                MessageBox.Show("Rezervacija je već potvrđena!", "Greška");
            }

            
        }

        private async void btnOtkazi_Click(object sender, EventArgs e)
        {
            if (chbOtkazano.Checked == false)
            {
                RezervacijeUpsertRequest request = new RezervacijeUpsertRequest();
                var rez = await _serviceRezervacija.GetById<MRezervacije>(_rezervacijaId);

                request.KorisnikId = rez.KorisnikId;
                request.DatumVrijeme = dateTime.Value;
                request.Napomena = rez.Napomena;
                request.BrojLjudi = Convert.ToInt32(numBrojljudi.Value);
                request.RestoranId = RestoranID;
                request.StatusId = 1;

                await _serviceRezervacija.Update<MRezervacije>(_rezervacijaId, request);


                await LoadRezervaciju();
                await rezervacije.LoadRezervacije();

            }
            else
            {
                MessageBox.Show("Rezervacija je već otkazana", "Greška");
            }
            
        }
    }
}

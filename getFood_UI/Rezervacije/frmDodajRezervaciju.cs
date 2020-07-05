using getFood_Model;
using getFood_Model.Requests;
using getFood_UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getFood_UI.Rezervacije
{
    public partial class frmDodajRezervaciju : Form
    {
        private readonly APIService _serviceRezervacija = new APIService("Rezervacije");
        private readonly APIService _serviceKorisnik = new APIService("Korisnik");
        private readonly APIService _serviceStatus = new APIService("Status");

        private int RestoranID = Global.prijavljeniRestoran.RestoranId;
        RezervacijeUpsertRequest request = new RezervacijeUpsertRequest();

        private getFood_UI.Home.Rezervacije _rezervacije;
        public frmDodajRezervaciju(getFood_UI.Home.Rezervacije rezervacije)
        {
            _rezervacije = rezervacije;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                request.DatumVrijeme = dateTime.Value;
                request.BrojLjudi = Convert.ToInt32(numBrojljudi.Value);
                request.RestoranId = RestoranID;

                var resultStatus = await _serviceStatus.Get<List<MStatus>>(null);

                int statusId = 0;
                foreach (var status in resultStatus)
                {
                    if (status.Naziv == "Potvrđena")
                    {
                        statusId = status.StatusId;
                    }
                }
                request.StatusId = statusId;


                var korisnik = await _serviceKorisnik.Get<List<MKorisnik>>(new KorisnikSearchRequest { Ime = txtIme.Text, Prezime = txtPrezime.Text, KorisnickoIme = txtKorisnickoIme.Text });
                if (korisnik.Count == 0)
                {
                    MessageBox.Show("Korisnik ne postoji!", "Upozorenje");
                }
                else
                {
                    request.KorisnikId = korisnik.Select(i => i.KorisnikId).FirstOrDefault();

                    await _serviceRezervacija.Insert<MRezervacije>(request);
                    _rezervacije.Rezervacije_Load(sender, e);
                    MessageBox.Show("Uspješno dodana rezervacija!", "Uspjeh");
                    this.Close();

                }

            }

        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                e.Cancel = true;
                txtIme.Focus();
                errorProviderRezervacija.SetError(txtIme, Resources.Validation_RequiredField);
            }
            else
            {
                e.Cancel = false;
                errorProviderRezervacija.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                e.Cancel = true;
                txtPrezime.Focus();
                errorProviderRezervacija.SetError(txtPrezime, Resources.Validation_RequiredField);
            }
            else
            {
                e.Cancel = false;
                errorProviderRezervacija.SetError(txtPrezime, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                e.Cancel = true;
                txtKorisnickoIme.Focus();
                errorProviderRezervacija.SetError(txtKorisnickoIme, Resources.Validation_RequiredField);
            }
            else
            {
                e.Cancel = false;
                errorProviderRezervacija.SetError(txtKorisnickoIme, null);
            }
        }

        private void dateTime_Validating(object sender, CancelEventArgs e)
        {
            if (dateTime.Value < DateTime.Now)
            {
                e.Cancel = true;
                dateTime.Focus();
                errorProviderRezervacija.SetError(dateTime, "Datum mora biti veći od sadašnjeg");
            }
            else
            {
                e.Cancel = false;
                errorProviderRezervacija.SetError(dateTime, null);
            }
        }

        private void numBrojljudi_Validating(object sender, CancelEventArgs e)
        {
            if (numBrojljudi.Value < 1)
            {
                e.Cancel = true;
                numBrojljudi.Focus();
                errorProviderRezervacija.SetError(numBrojljudi, Resources.Validation_RequiredField);
            }
            else
            {
                e.Cancel = false;
                errorProviderRezervacija.SetError(numBrojljudi, null);
            }
        }
    }
}

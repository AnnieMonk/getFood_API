using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using getFood_Model;
using getFood_Model.Requests;
using System.Configuration;
using getFood_UI.Restoran;
using getFood_UI.Properties;
using System.Text.RegularExpressions;

namespace getFood_UI.Home
{
    public partial class Restoran : UserControl
    {

        private readonly APIService _serviceRestoran = new APIService("Restoran");
        private readonly APIService _serviceKorisnikUloga = new APIService("KorisnikUloga");
        
        private readonly APIService _serviceKuhinja = new APIService("Kuhinja");

        int restoranId = Global.prijavljeniRestoran.RestoranId;
        int logovaniId = Global.prijavljeniKorisnik.KorisnikId;

        public Restoran()
        {
          
            InitializeComponent();
        }

      
        private void Zakljucaj()
        {
            
            txtRestoran.ReadOnly = true;
            txtTelefon.ReadOnly = true;
            txtWeb.ReadOnly = true;
            txtOpis.ReadOnly = true;
            txtRating.ReadOnly = true;
            txtRadnoVrijeme.ReadOnly = true;
            txtMinNarudzba.ReadOnly = true;
            btnUredi.Visible = true;
            cmbKuhinja.Enabled = false;
           

        }
        private void Otkljucaj()
        {
            btnSnimi.Visible = true;
            btnUredi.Visible = false;
            txtRestoran.ReadOnly = false;
            txtTelefon.ReadOnly = false;
            txtWeb.ReadOnly = false;
            txtOpis.ReadOnly = false;
            txtRadnoVrijeme.ReadOnly = false;
            txtMinNarudzba.ReadOnly = false;
            txtAdresa.ReadOnly = false;
            cmbKuhinja.Enabled = true;


        }
        private void SivaBoja()
        {
            txtRestoran.ForeColor = Color.FromArgb(117,117,117);
            txtTelefon.ForeColor = Color.FromArgb(117, 117, 117); ;
            txtWeb.ForeColor = Color.FromArgb(117, 117, 117); ;
            txtOpis.ForeColor = Color.FromArgb(117, 117, 117); ;
            txtRadnoVrijeme.ForeColor = Color.FromArgb(117, 117, 117); ;
            txtMinNarudzba.ForeColor = Color.FromArgb(117, 117, 117); ;
            cmbKuhinja.ForeColor = Color.FromArgb(117, 117, 117); ;
            txtAdresa.ForeColor = Color.FromArgb(117, 117, 117); ;
        }
        private void CrnaBoja()
        {
            txtRestoran.ForeColor = Color.Black;
            txtTelefon.ForeColor = Color.Black;
            txtWeb.ForeColor = Color.Black;
            txtOpis.ForeColor = Color.Black;
            txtRadnoVrijeme.ForeColor = Color.Black;
            txtMinNarudzba.ForeColor = Color.Black;
            cmbKuhinja.ForeColor = Color.Black;
            txtAdresa.ForeColor = Color.Black;
        }

       
        public async Task<bool> IsVlasnik()
        {

            var korisnikUlogeList = await _serviceKorisnikUloga.Get<List<MKorisnikUloga>>(null);

            var result = korisnikUlogeList.Where(i => i.UlogaId == 1 && i.KorisnikId == logovaniId).ToList();


            if (result.Count == 0)
            {

                return false;

            }
            else if (result.Count == 1)
            {
                return true;
            }

            return false;
        }
        private async void UpdateForm()
        {
            
          
            btnSnimi.Visible = false;
           
                 Zakljucaj();
             
                var restoran = await _serviceRestoran.GetById<MRestoran>(restoranId);

                txtRestoran.Text = restoran.Naziv;
                txtTelefon.Text = restoran.Telefon;
                txtWeb.Text = restoran.Web;
                txtOpis.Text = restoran.Opis;
                txtRating.Text = restoran.Rating.ToString();
                txtRadnoVrijeme.Text = restoran.RadnoVrijeme;
                txtMinNarudzba.Text = restoran.MinimalnaNarudzba.ToString();
                txtAdresa.Text = restoran.Adresa;

                
                await LoadKuhinje();

        }
        private void Restoran_Load(object sender, EventArgs e)
        {
            UpdateForm();
            
        }

        private async Task LoadKuhinje(string selected = null)
        {
           
            var kuhinje = await _serviceKuhinja.Get<List<MKuhinja>>(null);

            cmbKuhinja.DataSource = kuhinje;
            cmbKuhinja.DisplayMember = "Naziv";
            cmbKuhinja.ValueMember = "KuhinjaId";

            int index = 0;

           
            if (restoranId != 0)
            {
               
                var restoran = await _serviceRestoran.GetById<MRestoran>(restoranId);
                var kuhinja = await _serviceKuhinja.GetById<MKuhinja>(restoran.KuhinjaId);

                index = cmbKuhinja.FindString(kuhinja.Naziv);
            }
           
            else
            {
                index = cmbKuhinja.FindString(selected);

            }
            cmbKuhinja.SelectedIndex = index;

        }

        private async void btnUredi_Click(object sender, EventArgs e)
        {
            if(await IsVlasnik())
            {
                Otkljucaj();
                SivaBoja();

                await LoadKuhinje(cmbKuhinja.Text);
            }
            else
              MessageBox.Show("Nemate pravo na ovu akciju!", "Upozorenje");

        }
        RestoranUpsertRequest request = new RestoranUpsertRequest();
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                request.Naziv = txtRestoran.Text;
                request.MinimalnaNarudzba = int.Parse(txtMinNarudzba.Text);
                request.Opis = txtOpis.Text;
                request.RadnoVrijeme = txtRadnoVrijeme.Text;
                request.Telefon = txtTelefon.Text;
                request.Web = txtWeb.Text;

                request.Adresa = txtAdresa.Text;

                var kuhinja = cmbKuhinja.SelectedValue;

                if (int.TryParse(kuhinja.ToString(), out int kuhinjaId))
                {
                    request.KuhinjaId = kuhinjaId;
                }

                await _serviceRestoran.Update<MRestoran>(restoranId, request);

                UpdateForm();
                CrnaBoja();
            }

          
        }

        private void txtRating_Click(object sender, EventArgs e)
        {
            frmPregledReviews frm = new frmPregledReviews();
            frm.Show();
        }

        private void txtRestoran_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRestoran.Text))
            {
                e.Cancel = true;
                errorProviderRestoran.SetError(txtRestoran, Resources.Validation_RequiredField);
            }
            else
            {
                errorProviderRestoran.SetError(txtRestoran, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                e.Cancel = true;
                errorProviderRestoran.SetError(txtTelefon, Resources.Validation_RequiredField);
            }
            else if (!Regex.Match(txtTelefon.Text, "^[+][(][0-9]{3}[)][0-9]{2}[/][0-9]{3}[-][0-9]{3}").Success)
            {
                e.Cancel = true;
                errorProviderRestoran.SetError(txtTelefon, Resources.Validation_RegexMatch + "+(387)xx/xxx-xxx");
            }
            else
            {
                errorProviderRestoran.SetError(txtTelefon, null);
            }
        }

        private void txtWeb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWeb.Text))
            {
                e.Cancel = true;
                errorProviderRestoran.SetError(txtWeb, Resources.Validation_RequiredField);
            }
            else if (!Regex.Match(txtWeb.Text, "^[w]{3}[.][a-z]{3,10}[.](com|ba|net)").Success)
            {
                e.Cancel = true;
                errorProviderRestoran.SetError(txtWeb, Resources.Validation_RegexMatch);
            }
           
            else
            {
                errorProviderRestoran.SetError(txtWeb, null);
            }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                e.Cancel = true;
                errorProviderRestoran.SetError(txtAdresa, Resources.Validation_RequiredField);
            }
            else
            {
                errorProviderRestoran.SetError(txtAdresa, null);
            }
        }

        private void cmbKuhinja_Validating(object sender, CancelEventArgs e)
        {
            if (cmbKuhinja.SelectedIndex < 0)
            {
                e.Cancel = true;
                errorProviderRestoran.SetError(cmbKuhinja, Resources.Validation_RequiredField);
            }
            else
            {
                errorProviderRestoran.SetError(cmbKuhinja, null);
            }
        }

        private void txtMinNarudzba_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMinNarudzba.Text))
            {
                e.Cancel = true;
                errorProviderRestoran.SetError(txtMinNarudzba, Resources.Validation_RequiredField);
            }
            else
            {
                errorProviderRestoran.SetError(txtMinNarudzba, null);
            }
        }

        private void txtRadnoVrijeme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRadnoVrijeme.Text))
            {
                e.Cancel = true;
                errorProviderRestoran.SetError(txtRadnoVrijeme, Resources.Validation_RequiredField);
            }
            else if (!Regex.Match(txtRadnoVrijeme.Text, "^[0-9]{2}[:][0-9]{2}[-][0-9]{2}[:][0-9]{2}").Success)
            {
                e.Cancel = true;
                errorProviderRestoran.SetError(txtRadnoVrijeme, Resources.Validation_RegexMatch + "xx:xx-xx:xx");
            }
            
            else
            {
                errorProviderRestoran.SetError(txtRadnoVrijeme, null);
            }
        }
    }
}

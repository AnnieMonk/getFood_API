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
using getFood_UI.Properties;

namespace getFood_UI.Meni
{
   
    public partial class frmDodajMeni : Form
    {
      
        private readonly APIService _serviceKorisnikUloga = new APIService("KorisnikUloga");
        private readonly APIService _serviceMeni = new APIService("Meni");
        private readonly APIService _serviceMeniProdukti = new APIService("MeniProdukti");
        private Jelovnik _jelovnik;
        MeniUpsertRequest MeniRequest = new MeniUpsertRequest();
       
        private int? _meniId = null;
        public frmDodajMeni(Jelovnik jelovnik, int? meniId = null)
        {
            _jelovnik = jelovnik;
            _meniId = meniId;
            InitializeComponent();
        }
     
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Zakljucaj()
        {
            txtNaziv.ReadOnly = true;
            txtOpis.ReadOnly = true;
            dateTimeRok.Enabled = false;
            produktiGrid.Columns["Odaberi"].ReadOnly = true;
            btnSnimiProizvod.Visible = false;
            picDodaj.Visible = false;
            picUredi.Visible = false;
            btnObrisiMeni.Visible = false;
        }
        private void Otkljucaj()
        {
            txtNaziv.ReadOnly = false;
            txtOpis.ReadOnly = false;
            dateTimeRok.Enabled = true;
            produktiGrid.Columns["Odaberi"].ReadOnly = false;
            btnSnimiProizvod.Visible = true;
            picDodaj.Visible = false;
            picUredi.Visible = true;
            picPregled.Visible = false;
            btnUredi.Visible = false;
            btnObrisiMeni.Visible = true;
        }
        private async void frmDodajMeni_Load(object sender, EventArgs e)
        {
            await LoadProizvode();

            if (_meniId.HasValue)
            {
                Zakljucaj();

                var result = await _serviceMeni.GetById<MMeni>(_meniId);

                txtNaziv.Text = result.Naziv;
                txtOpis.Text = result.Opis;

                dateTimeRok.Value = result.DatumIsteka ?? DateTime.Now;


            }
            else
            {
                picDodaj.Visible = true;
                picUredi.Visible = false;
                picPregled.Visible = false;
                btnObrisiMeni.Visible = false;
                btnUredi.Visible = false;
            }
        }
        private async Task LoadProizvode(List<int> produktId = null, bool prikaziSve = false)
        {

            produktiGrid.AutoGenerateColumns = false;
            var restoranId = Global.prijavljeniRestoran.RestoranId;

            if (_meniId.HasValue && prikaziSve == false)
            {
                var result = await _serviceMeniProdukti.Get<List<MMeniProdukti>>(new MeniProduktiSearchRequest { MeniId = _meniId, RestoranId = restoranId });

                produktiGrid.DataSource = result;

                foreach (DataGridViewRow y in produktiGrid.Rows)
                {
                    y.Cells[4].Value = true;

                }

            }
            else 
            {

                var result = await _serviceMeniProdukti.Get<List<MMeniProdukti>>(new MeniProduktiSearchRequest { RestoranId = restoranId });

                produktiGrid.DataSource = result;

                if (produktId != null)
                {
                    foreach (var x in produktId)
                    {

                        foreach (DataGridViewRow y in produktiGrid.Rows)
                        {
                            if (y.Cells[0].Value.Equals(x))
                            {

                                y.Cells[4].Value = true;
                            }
                        }
                    }
                }
            }
           
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            var stringg = txtPretrazi.Text;

            int rowIndex = -1;
            foreach (DataGridViewRow row in produktiGrid.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(stringg))
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            if (rowIndex != -1)
            {
                produktiGrid.ClearSelection();
                produktiGrid.Rows[rowIndex].Selected = true;
            }
        }

        List<int> listachekiranih = null; 
        private async void btnSnimiProizvod_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                MeniRequest.DatumNapravljen = DateTime.Now;
                MeniRequest.Naziv = txtNaziv.Text;
                MeniRequest.Opis = txtOpis.Text;

                int restoranId = Global.prijavljeniRestoran.RestoranId;
                MeniRequest.RestoranId = restoranId;

                DateTime dt = Convert.ToDateTime(dateTimeRok.Value);
                MeniRequest.DatumIsteka = dt;

                foreach (DataGridViewRow row in produktiGrid.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[4].Value) == true)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        MeniRequest.listaProizvoda.Add(id);
                    }
                }

                if (_meniId.HasValue)
                {
                    await _serviceMeni.Update<MMeni>(_meniId, MeniRequest);

                }
                else
                {

                    await _serviceMeni.Insert<MMeni>(MeniRequest);

                }
                MessageBox.Show("Operacija uspješna!");
                this.Close();
                await _jelovnik.UpdateForm();
            }


        }

        public async Task<bool> IsVlasnik()
        {
            int logovaniId = Global.prijavljeniKorisnik.KorisnikId;

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

        private async void btnUredi_Click(object sender, EventArgs e)
        {
          
             if(await IsVlasnik())
             {
                listachekiranih = new List<int>();
                foreach (DataGridViewRow row in produktiGrid.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[4].Value) == true)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        listachekiranih.Add(id);
                    }
                }
                await LoadProizvode(listachekiranih, true);

                Otkljucaj();
             }
             else
                MessageBox.Show("Nemate pravo na ovu akciju!", "Upozorenje");
        }

        private async void btnObrisiMeni_Click(object sender, EventArgs e)
        {
            if (await IsVlasnik())
            {

                if (_meniId.HasValue)
                {
                    DialogResult dialogResult = MessageBox.Show("Da li ste sigurni?", "Upozorenje", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var result = await _serviceMeni.Delete(_meniId);
                        if (result == true)
                        {
                            this.Close();
                            await _jelovnik.UpdateForm();
                        }
                        else
                        {
                            MessageBox.Show("Greška!");
                        }
                    }
                }
            }
            else
                MessageBox.Show("Nemate pravo na ovu akciju!", "Upozorenje");
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                e.Cancel = true;
                errorProviderMeni.SetError(txtNaziv, Resources.Validation_RequiredField);
            }
            else
            {
                e.Cancel = false;
                errorProviderMeni.SetError(txtNaziv, null);
            }
        }

        private void dateTimeRok_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimeRok.Value < DateTime.Now)
            {
                e.Cancel = true;
                errorProviderMeni.SetError(dateTimeRok, "Unesite neki datum u budućnosti!");
            }
            else
            {
                e.Cancel = false;
                errorProviderMeni.SetError(dateTimeRok, null);
            }
        }

        
    }
}

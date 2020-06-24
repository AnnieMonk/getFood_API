using getFood_Model;
using getFood_Model.Requests;
using getFood_UI.Meni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getFood_UI.Home
{
    //PRETRAGA GLEDA SVE RESTORANE
    public partial class Jelovnik : UserControl
    {
        private static readonly APIService _serviceProdukti = new APIService("Produkti");
        private static readonly APIService _serviceMeni = new APIService("Meni");
        private static readonly APIService _serviceMeniProdukti = new APIService("MeniProdukti");
        private static readonly APIService _serviceKorisnikUloga = new APIService("KorisnikUloga");

        int restoranId = Global.prijavljeniRestoran.RestoranId;
        int logovaniId = Global.prijavljeniKorisnik.KorisnikId;
        public Jelovnik()
        {
            InitializeComponent();
            //UpdateForm();
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
        public async Task UpdateForm()
        {
            produktiGrid.Hide();
            await LoadMeni();

            await LoadProizvodi();
            produktiGrid.ClearSelection();


        }
        private async void btnDodajProizvod_Click(object sender, EventArgs e)
        {

            if (await IsVlasnik())
            {
                frmDodajProizvod frm = new frmDodajProizvod(this);
                frm.Show();
            }
            else
                MessageBox.Show("Nemate pravo na ovu akciju!", "Upozorenje");

        }
        private void produktiGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = produktiGrid.SelectedRows[0].Cells[0].Value;

            frmDodajProizvod frm = new frmDodajProizvod(this, int.Parse(id.ToString()));
            frm.Show();
        }

        private async void Jelovnik_Load(object sender, EventArgs e)
        {
            await UpdateForm();
        }

        private async Task LoadMeni()
        {
            
            var result = await _serviceMeni.Get<List<MMeni>>(new MeniSearchRequest { RestoranId = restoranId });
            result.Insert(0, new MMeni() { Naziv = "Svi meniji" });

            cmbMeni.DataSource = result;
            cmbMeni.DisplayMember = "Naziv";
            cmbMeni.ValueMember = "MeniId";


        }

        private async Task LoadProizvodi(int id = 0)
        {
            if (id != 0)
            {
                var result = await _serviceMeniProdukti.Get<List<MMeniProdukti>>(new MeniProduktiSearchRequest { MeniId = id });

                produktiGrid.Show();
                produktiGrid.AutoGenerateColumns = false;
                produktiGrid.DataSource = result;
            }
            else if (id == 0)
            {
                var result = await _serviceMeniProdukti.Get<List<MMeniProdukti>>(new MeniProduktiSearchRequest { RestoranId = restoranId });

                produktiGrid.Show();
                produktiGrid.AutoGenerateColumns = false;
                produktiGrid.DataSource = result;
            }
            else
            {
                produktiGrid.Hide();
            }

        }
        private async void cmbMeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbMeni.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadProizvodi(id);
            }
        }

        private async void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            List<MMeniProdukti> result;
            if (string.IsNullOrWhiteSpace(txtPretrazi.Text))
            {
               result = await _serviceMeniProdukti.Get<List<MMeniProdukti>>(new MeniProduktiSearchRequest { RestoranId = restoranId });
            }
            else
            {
                result = await _serviceMeniProdukti.Get<List<MMeniProdukti>>(new MeniProduktiSearchRequest { RestoranId = restoranId, Naziv = txtPretrazi.Text });
            }
          

            produktiGrid.DataSource = result;

        }

        private async void btnDodajMeni_Click(object sender, EventArgs e)
        {
            if (await IsVlasnik())
            {
                frmDodajMeni frm = new frmDodajMeni(this);
                frm.Show();
            }
            else
                MessageBox.Show("Nemate pravo na ovu akciju!", "Upozorenje");

        }

        private void btnPogledajMeni_Click(object sender, EventArgs e)
        {
            var idObj = cmbMeni.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                if (id != 0)
                {
                    frmDodajMeni frm = new frmDodajMeni(this, id);

                    frm.Show();
                }
            }

            
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {

        }
    }
}

using getFood_Model;
using getFood_Model.Requests;
using getFood_UI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getFood_UI.Izvještaji
{
    public partial class frmUpitKorisnik : Form
    {
        int _restoranId;
        int korisnikId;
        private readonly APIService _serviceKorisnik = new APIService("Korisnik");
        private readonly APIService _serviceIzlaz = new APIService("Izlaz");

        public frmUpitKorisnik(int restoranId)
        {
            InitializeComponent();
            _restoranId = restoranId;
        }

        private async Task LoadKorisnike()
        {
            var result = await _serviceKorisnik.Get<List<MKorisnik>>(null);
            result.Insert(0, new MKorisnik { Ime = "Odaberite" });
            cmbKorisnik.DataSource = result;
            cmbKorisnik.DisplayMember = "FullName";
            cmbKorisnik.ValueMember = "KorisnikId";
        }
        private async void frmUpitKorisnik_Load(object sender, EventArgs e)
        {
            await LoadKorisnike();
        }

        private async Task LoadIzlaze(int id)
        {
            var result = await _serviceIzlaz.Get<List<MIzlaz>>(new IzlazSearchRequest { KorisnikId = id });

            racuniGrid.AutoGenerateColumns = false;
            racuniGrid.DataSource = result;

        }
        private async  void cmbKorisnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbKorisnik.SelectedItem as MKorisnik;
            korisnikId = idObj.KorisnikId;
           await LoadIzlaze(idObj.KorisnikId);
           
        }

        private void racuniGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var racun = racuniGrid.SelectedRows[0].Cells[1].Value.ToString();

            IzdavanjeRacuna frm = new IzdavanjeRacuna(racun,_restoranId, korisnikId);
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

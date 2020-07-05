using getFood_Model;
using getFood_Model.Requests;
using getFood_UI.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getFood_UI.Narudzbe
{
    public partial class frmPregledNarudzbe : Form
    {
        private readonly APIService _serviceNarudzbaStavke = new APIService("NarudzbaStavke");
        private readonly APIService _serviceNarudzba = new APIService("Narudzba");
        private readonly APIService _serviceProizvodi = new APIService("Produkti");
        private readonly APIService _serviceIzlaz = new APIService("Izlaz");

        private Narudžbe _narudzbe;
        private int? _narudzbaId = null;
        public frmPregledNarudzbe(Narudžbe narudzbe, int? narudzbaId = null)
        {
            InitializeComponent();
            _narudzbe = narudzbe;
            _narudzbaId = narudzbaId;
        }

        private async Task LoadNarudzbe()
        {

            await LoadProizvode();

            var result = await _serviceNarudzba.GetById<MNarudzba>(_narudzbaId);
            txtBrojNarudzbe.Text = result.BrojNarudzbe;
            txtImePrezime.Text = result.Ime + " " + result.Prezime;
            txtNapomena.Text = result.Napomena;
            txtTelefon.Text = result.Telefon;
            dateTimeNarudzba.Value = result.Datum;

            if (result.StatusId == 2)
                chbProcesirana.Checked = true;
            else
                chbProcesirana.Checked = false;

        }
        private async void frmPregledNarudzbe_Load(object sender, EventArgs e)
        {
            await LoadNarudzbe();
        }
        private async Task LoadProizvode()
        {
            var result = await _serviceNarudzbaStavke.Get<List<MNarudzbaStavke>>(new NarudzbaStavkeSearchRequest { NarudzbaId = _narudzbaId });
           
            produktiGrid.ClearSelection();
            produktiGrid.AutoGenerateColumns = false;
            produktiGrid.DataSource = result;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnProcesiraj_Click(object sender, EventArgs e)
        {
            var izlaziCount = await _serviceIzlaz.Get<List<MIzlaz>>(null);
            int broj = izlaziCount.Count();

            var narudzbaStavke = await _serviceNarudzbaStavke.Get<List<MNarudzbaStavke>>(new NarudzbaStavkeSearchRequest { NarudzbaId = _narudzbaId });
            var produkti = await _serviceProizvodi.Get<List<MProdukti>>(null);

            decimal ukupno = 0;
            foreach(var x in produkti)
            {
                foreach( var y in narudzbaStavke)
                {
                    if(x.ProduktiId == y.ProduktiId)
                    {
                        ukupno += x.Cijena * y.Kolicina;
                    }
                }
               
            }

            IzlazUpsertRequest request = new IzlazUpsertRequest();
            request.NarudzbaId = _narudzbaId ?? 0;
            request.BrojRacuna = DateTime.Now.Month + DateTime.Now.Year + "/" + broj + 1;
            request.Datum = DateTime.Now;
            request.IznosBezPdv = ukupno / (decimal) 1.17;
            request.IznosSaPdv = ukupno;
            request.KorisnikId = narudzbaStavke.Select(i => i.KorisnikId).First();
            try
            {
                await _serviceIzlaz.Insert<MIzlaz>(request);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nešto je pošlo po zlu" + ex.Message, "Upozorenje");
            }

            var narudzbe = await _serviceNarudzba.GetById<MNarudzba>(_narudzbaId);
            narudzbe.NarudzbaStavke = narudzbaStavke;

            MessageBox.Show("Uspješno procesirana narudžba", "Info");
            this.Close();
            await _narudzbe.LoadNarudzbe(null);
            Reports.NarudzbeDetails frm = new Reports.NarudzbeDetails(narudzbe);
            frm.Show();

        }
    }
}

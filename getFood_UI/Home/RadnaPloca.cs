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
using System.IO;
using getFood_Model.Requests;
using System.Runtime.Serialization.Formatters.Binary;

namespace getFood_UI.Home
{
    public partial class RadnaPloca : UserControl
    {
        private readonly APIService _serviceProdukti = new APIService("Produkti");
        private readonly APIService _serviceMeniProdukti = new APIService("MeniProdukti");
        private readonly APIService _serviceIzlaz = new APIService("Izlaz");
        public RadnaPloca()
        {
            InitializeComponent();
        }

        public async Task LoadZaradaDanas()
        {
            var izlaz = await _serviceIzlaz.Get<List<MIzlaz>>(new IzlazSearchRequest { RestoranId = Global.prijavljeniRestoran.RestoranId, Datum = DateTime.Now });

            txtPromet.Text = izlaz.Sum(i => i.IznosBezPdv).ToString();
            txtDatum.Text = DateTime.Now.ToShortDateString();
            txtUkupnoNarudzbi.Text = izlaz.Count.ToString();
            txtUkupnoKupaca.Text = izlaz.Select(i => i.KorisnikId).Distinct().Sum().ToString();

        }
        public async Task PopulateAsync()
        {
            var produkti = await _serviceProdukti.Get<List<MProdukti>>(null);

            produkti = produkti.Where(i => i.Rating >= 4).OrderByDescending(i => i.Rating).ToList();

            var meniprodukti = await _serviceMeniProdukti.Get<List<MMeniProdukti>>(new MeniProduktiSearchRequest { RestoranId = Global.prijavljeniRestoran.RestoranId });

            List<MProdukti> zaPrikazati = new List<MProdukti>();

            foreach(var x in produkti.Take(3))
            {
                if (meniprodukti.Select(i => i.ProduktiId).Contains(x.ProduktiId))
                {
                    zaPrikazati.Add(x);
                }
            }
            NajboljiItems[] listItems = new NajboljiItems[zaPrikazati.Count];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new NajboljiItems();
                listItems[i].naziv = zaPrikazati[i].Naziv;
                MemoryStream ms = new MemoryStream((Byte[])zaPrikazati[i].SlikaThumb);
                listItems[i].slika = new Bitmap(ms);
                listItems[i].rating = zaPrikazati[i].Rating ?? 0;
                listItems[i].opis = zaPrikazati[i].Opis;

                if (flowLayoutPanel.Controls.Count < 0)
                {
                    flowLayoutPanel.Controls.Clear();
                }
                else
                    flowLayoutPanel.Controls.Add(listItems[i]);


            }


        }

        private async void RadnaPloca_Load(object sender, EventArgs e)
        {
            await PopulateAsync();
            await LoadZaradaDanas();
        }

    }
}

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

namespace getFood_UI.Home
{
    public partial class RadnaPloca : UserControl
    {
        private readonly APIService _serviceKorisnik = new APIService("Korisnik");
        private readonly APIService _serviceProdukti = new APIService("Produkti");
        public RadnaPloca()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private async Task PopulateAsync()
        {
           


            var produkti = await _serviceProdukti.Get<List<MProdukti>>(null);

            produkti = produkti.Where(i => i.Rating >= 4 ).OrderByDescending(i => i.Rating).ToList();

            ListItem[] listItems = new ListItem[produkti.Count];

            for (int i = 0; i < listItems.Length; i++)
            {
                    listItems[i] = new ListItem();
                    listItems[i].naziv = produkti[i].Naziv;
                    MemoryStream ms = new MemoryStream((Byte[])produkti[i].SlikaThumb);
                    listItems[i].slika = new Bitmap(ms);
                   
                listItems[i].cijena = produkti[i].Cijena;
               
                if(flowLayoutPanel.Controls.Count < 0)
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
        }
    }
}

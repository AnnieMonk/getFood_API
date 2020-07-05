
using getFood_Model;
using getFood_Model.Requests;
using getFood_UI.Login;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace getFood_UI.Home
{
    public partial class frmIndex : Form
    {

        private readonly APIService _serviceKorisnik = new APIService("Korisnik");
        private readonly APIService _serviceNarudzbe = new APIService("Narudzba");
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");

        public Panel PanelContainer
        {
            get
            {
                return panelDesavanja;
            }
            set { panelDesavanja = value; }
        }
        public frmIndex()
        {
            InitializeComponent();
            
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
           
            
                Restoran jel = new Restoran();
            
                jel.Dock = DockStyle.Fill;
                panelDesavanja.Controls.Add(jel);
               
            
           panelDesavanja.Controls["Restoran"].BringToFront();

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            RadnaPloca rp = new RadnaPloca();
            await rp.PopulateAsync();
            await rp.LoadZaradaDanas();
            rp.Dock = DockStyle.Fill;
            panelDesavanja.Controls.Add(rp);
            panelDesavanja.Controls["RadnaPloca"].BringToFront();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
         
                Jelovnik jel = new Jelovnik();
                
                jel.Dock = DockStyle.Fill;
                panelDesavanja.Controls.Add(jel);
                
           
            
            panelDesavanja.Controls["Jelovnik"].BringToFront();
            
           

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            Narudžbe jel = new Narudžbe();
            await jel.LoadNarudzbe(null);
            jel.Dock = DockStyle.Fill;
            panelDesavanja.Controls.Add(jel);



            panelDesavanja.Controls["Narudžbe"].BringToFront();

        }


        public async Task provjeriNotifikacije()
        {
            var rezervacije = await _serviceRezervacije.Get<List<MRezervacije>>(new RezervacijeSearchRequest { StatusId = 3, RestoranId = Global.prijavljeniRestoran.RestoranId, samoBuduce=true });
            List<MRezervacije> result = new List<MRezervacije>();
            foreach (var x in rezervacije)
            {
                if (x.DatumVrijeme > DateTime.Now)
                {
                    result.Add(x);
                }
            }
            var narudzbe = await _serviceNarudzbe.Get<List<MNarudzba>>(new NarudzbaSearchRequest { StatusID = 3, RestoranID = Global.prijavljeniRestoran.RestoranId, Datum=DateTime.Now });

            if (result.Count > 0)
            {
                rezervacijeNotifikacija.ShowBalloonTip(2000, "Nove rezervacije", "Broj rezervacija: " + result.Count, ToolTipIcon.Info);
               
            }
            if(narudzbe.Count > 0)
            {
                narudzbeNotifikacija.ShowBalloonTip(2000, "Nove narudžbe", "Broj narudžbi: " + narudzbe.Count, ToolTipIcon.Info);
            }

        }


        public async void frmIndex_Load(object sender, EventArgs e)
        {
            RadnaPloca rp = new RadnaPloca();
            rp.Dock = DockStyle.Fill;
            panelDesavanja.Controls.Add(rp);

            var username = _serviceKorisnik.getUsername();
            var search = new KorisnikSearchRequest()
            {
                KorisnickoIme = username
            };
            
            var result = await _serviceKorisnik.Get<List<MKorisnik>>(search);
            txtLogovaniKorisnik.Text = result.Select(i => i.Ime).FirstOrDefault();
           
            await provjeriNotifikacije();
         
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }
        Point lastPoint;
        private void frmIndex_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void frmIndex_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;

            Rezervacije jel = new Rezervacije();
            await jel.LoadRezervacije();
            jel.Dock = DockStyle.Fill;
            panelDesavanja.Controls.Add(jel);

            panelDesavanja.Controls["Rezervacije"].BringToFront();
            
        }


        private async void narudzbeNotifikacija_BalloonTipClicked(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            Narudžbe jel = new Narudžbe();
            await jel.LoadNarudzbe(null);
            jel.Dock = DockStyle.Fill;
            panelDesavanja.Controls.Add(jel);

            panelDesavanja.Controls["Narudžbe"].BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;

            Izvještaji jel = new Izvještaji();
            jel.Dock = DockStyle.Fill;
            panelDesavanja.Controls.Add(jel);

            panelDesavanja.Controls["Izvještaji"].BringToFront();
            jel.Refresh();
        }

        private void rezervacijeNotifikacija_BalloonTipClicked(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;

            Rezervacije jel = new Rezervacije();
            jel.Dock = DockStyle.Fill;
            panelDesavanja.Controls.Add(jel);

            panelDesavanja.Controls["Rezervacije"].BringToFront();
        }

        private void txtLogovaniKorisnik_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //treba se se odloguje
            DialogResult result = MessageBox.Show("Bit ćete odjavljeni!", "Upozorenje", buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                frmLogin frm = new frmLogin();
                frm.Show();
            }
        }
    }
}

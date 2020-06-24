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

namespace getFood_UI.Login
{
    public partial class frmLogin : Form
    {
        APIService serviceKorisnik = new APIService("Korisnik");
        APIService serviceRestoran = new APIService("KorisnikRestoran");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {


                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;
                 await serviceKorisnik.Get<dynamic>(null); //request na server


                var pretragaKorisnika = await serviceKorisnik.Get<List<MKorisnik>>(new KorisnikSearchRequest { KorisnickoIme = APIService.Username });
                Global.prijavljeniKorisnik = pretragaKorisnika.FirstOrDefault();

                var pretragaRestorana = await serviceRestoran.Get<List<MKorisnikRestoran>>(new KorisnikRestoranSearchRequest { KorisnikId = Global.prijavljeniKorisnik.KorisnikId });
                Global.prijavljeniRestoran = pretragaRestorana.FirstOrDefault();
                this.Hide();

                frmIndex frm = new frmIndex();

                frm.Show();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           

        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, 191, 63);
           
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 191, 63);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(64, 64, 64);
        }
    }
}

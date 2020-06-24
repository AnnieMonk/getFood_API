using getFood_Model;
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

namespace getFood_UI.Restoran
{
    public partial class frmSingleReview : Form
    {
        private readonly APIService _serviceReview = new APIService("Review");
        private readonly APIService _serviceRestoran = new APIService("Restoran");
        private readonly APIService _serviceKorisnik = new APIService("Korisnik");

        private int RestoranID = Convert.ToInt32(ConfigurationManager.AppSettings["RestoranID"]);

        private int? _reviewId = null;
        public frmSingleReview(int? reviewId = null)
        {
            _reviewId = reviewId;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmSingleReview_Load(object sender, EventArgs e)
        {
            var result = await _serviceReview.GetById<MReview>(_reviewId);

            var korisnik = await _serviceKorisnik.GetById<MKorisnik>(result.KorisnikId);
            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
            txtKomentar.Text = result.Komentar;
            txtKorisnickoIme.Text = korisnik.KorisnickoIme;
            txtOcjena.Value = result.Ocjena;
            dateTime.Value = result.Datum;
        }
    }
}

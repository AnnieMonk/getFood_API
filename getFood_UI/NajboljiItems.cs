using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getFood_UI
{
    public partial class NajboljiItems : UserControl
    {
        public NajboljiItems()
        {
            InitializeComponent();
        }


        private Image _slika;

        public Image slika
        {
            get { return _slika; }
            set { _slika = value; slikaHrane.Image = value; slikaHrane.SizeMode = PictureBoxSizeMode.StretchImage; }
        }

        private string _naziv;

        public string naziv
        {
            get { return _naziv; }
            set { _naziv = value; txtNaziv.Text = value; }
        }

        private string _opis;

        public string opis
        {
            get { return _opis; }
            set { _opis = value; txtOpis.Text = value; }
        }

        private decimal _rating;

        public decimal rating
        {
            get { return _rating; }
            set { _rating = value; txtRating.Text = value.ToString(); }
        }



    }
}

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
    public partial class ListItem : UserControl
    {
        public ListItem()
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

        private decimal _cijena;

        public decimal cijena
        {
            get { return _cijena; }
            set { _cijena = value; txtCijena.Text = value.ToString(); }
        }



    }
}

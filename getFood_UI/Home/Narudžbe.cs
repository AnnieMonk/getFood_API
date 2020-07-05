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
using getFood_Model.Requests;
using getFood_UI.Narudzbe;

namespace getFood_UI.Home
{
    public partial class Narudžbe : UserControl
    {
        private static readonly APIService _serviceNarudzba = new APIService("Narudzba");
        private static readonly APIService _serviceStatus = new APIService("Status");

        int restoranId = Global.prijavljeniRestoran.RestoranId;
       
        public Narudžbe()
        {
            InitializeComponent();
        }
       
        private async void Narudžbe_Load(object sender, EventArgs e)
        {
            await LoadNarudzbe(null);
        }

        private async Task Chekiraj(List<MNarudzba> list)
        {
           
            var resultStatus = await _serviceStatus.Get<BindingList<MStatus>>(null);


            int statusId = 0;
            foreach (var status in resultStatus)
            {
                if (status.Naziv == "Nepoznato")
                {
                    statusId = status.StatusId;
                }
            }
            List<int> listachekiranih;
            listachekiranih = new List<int>();
            foreach (var rez in list)
            {

                foreach (DataGridViewRow y in narudzbeGrid.Rows)
                {
                    if (y.Cells[0].Value.Equals(rez.NarudzbaId))
                    {
                        if (rez.StatusId == statusId)
                        {
                            y.Cells[4].Value = false;

                        }
                        else
                        {
                            y.Cells[4].Value = true;
                            listachekiranih.Add(rez.NarudzbaId);
                        }
                    }
                }

            }

        }


        public async Task LoadNarudzbe(string prezime)
        {
            txtDatumDanas.Text = DateTime.Now.ToShortDateString();
            narudzbeGrid.DataSource = null;
            List<MNarudzba> narudzbe;
            if(prezime == null)
               narudzbe = await _serviceNarudzba.Get<List<MNarudzba>>(new NarudzbaSearchRequest { RestoranID = restoranId, Datum= DateTime.Now});
            else
                narudzbe = await _serviceNarudzba.Get<List<MNarudzba>>(new NarudzbaSearchRequest { RestoranID = restoranId, Prezime = prezime, Datum = DateTime.Now });
           
            var bindinglist = new BindingList<MNarudzba>(narudzbe);
            var source = new BindingSource(bindinglist, null);
            narudzbeGrid.AutoGenerateColumns = false;
            narudzbeGrid.DataSource = source;
            narudzbeGrid.Update();
            narudzbeGrid.Refresh();

            narudzbeGrid.ClearSelection();


            await Chekiraj(narudzbe);
        }

        private void narudzbeGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = narudzbeGrid.SelectedRows[0].Cells[0].Value;

            frmPregledNarudzbe frm = new frmPregledNarudzbe(this, int.Parse(id.ToString()));
            frm.Show();
        }

        private async void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtPretrazi.Text))
            {
               
                await LoadNarudzbe(null);
            }
            else
            {
             
                await LoadNarudzbe(txtPretrazi.Text);
            }


        }
    }
}

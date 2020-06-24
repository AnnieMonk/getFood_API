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
using System.Configuration;
using getFood_UI.Home;
using getFood_UI.Rezervacije;
using getFood_Model.Requests;

namespace getFood_UI.Home
{
    public partial class Rezervacije : UserControl
    {
        private static readonly APIService _serviceRezervacije = new APIService("Rezervacije");
        
        private static readonly APIService _serviceStatus = new APIService("Status");

        int restoranId = Global.prijavljeniRestoran.RestoranId;
        public Rezervacije()
        {
            InitializeComponent();

        }

        
        public async void Rezervacije_Load(object sender, EventArgs e)
        {
            
            this.rezervacijeGrid.Refresh();
            await LoadRezervacije();
        }

        List<int> listachekiranih;
        public async Task LoadRezervacije()
        {
            rezervacijeGrid.DataSource = null;
            var result = await _serviceRezervacije.Get<List<MRezervacije>>(new RezervacijeSearchRequest { RestoranId = Global.prijavljeniRestoran.RestoranId, samoBuduce = true});
           
            var bindinglist = new BindingList<MRezervacije>(result);
            var source = new BindingSource(bindinglist, null);
            rezervacijeGrid.AutoGenerateColumns = false;
            rezervacijeGrid.DataSource = source;
            rezervacijeGrid.Update();
            rezervacijeGrid.Refresh();

            rezervacijeGrid.ClearSelection();

            var resultStatus = await _serviceStatus.Get<BindingList<MStatus>>(null);


            int statusId = 0;
            foreach (var status in resultStatus)
            {
                if (status.Naziv == "Nepoznato")
                {
                    statusId = status.StatusId;
                }
            }

            listachekiranih = new List<int>();
            foreach (var rez in result)
            {

                foreach (DataGridViewRow y in rezervacijeGrid.Rows)
                {
                    if (y.Cells[0].Value.Equals(rez.RezervacijaId))
                    {
                        if (rez.StatusId == statusId)
                        {
                            y.Cells[4].Value = false;

                        }
                        else
                        {
                            y.Cells[4].Value = true;
                            listachekiranih.Add(rez.RezervacijaId);
                        }
                    }
                }
                
            }

 
        }

        private void rezervacijeGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = rezervacijeGrid.SelectedRows[0].Cells[0].Value;

            frmPregledRezervacije frm = new frmPregledRezervacije(this, int.Parse(id.ToString()));
            frm.Show();
        }

        private async void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            var stringg = txtPretrazi.Text;
            

            foreach (DataGridViewRow row in rezervacijeGrid.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(stringg))
                {
                    var result = await _serviceRezervacije.Get<List<MRezervacije>>(new RezervacijeSearchRequest { Ime = txtPretrazi.Text, samoBuduce = true, RestoranId=restoranId });
                   
                    rezervacijeGrid.DataSource = result;

                    break;
                }
                else
                {

                    var result = await _serviceRezervacije.Get<List<MRezervacije>>(new RezervacijeSearchRequest { samoBuduce=true, RestoranId = restoranId });

                    rezervacijeGrid.DataSource = result;
                }
                

            }
           
            foreach(var chek in listachekiranih)
            {
                foreach (DataGridViewRow y in rezervacijeGrid.Rows)
                {
                    if (y.Cells[0].Value.Equals(chek))
                    {
                        y.Cells[4].Value = true;
                    }
                }
            }
            
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {

            frmDodajRezervaciju frm = new frmDodajRezervaciju(this);

            frm.Show();
        }
    }
}

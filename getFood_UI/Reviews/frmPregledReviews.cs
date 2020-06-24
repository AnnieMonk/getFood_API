using getFood_Model;
using getFood_Model.Requests;
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
    public partial class frmPregledReviews : Form
    {
        private readonly APIService _serviceReview = new APIService("Review");
        private readonly APIService _serviceRestoran = new APIService("Restoran");
        private readonly APIService _serviceProdukti = new APIService("Produkti");

        private int RestoranID = Convert.ToInt32(ConfigurationManager.AppSettings["RestoranID"]);

        private int? _produktId;
        public frmPregledReviews(int? produktId= null)
        {
            _produktId = produktId;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async  void frmPregledReviews_Load(object sender, EventArgs e)
        {
            await LoadReviews();

        }

        private async Task LoadReviews()
        {
            if (_produktId == null)
            {
                var result = await _serviceReview.Get<List<MReview>>(new ReviewSearchRequest {RestoranId = RestoranID });

                reviewsGrid.AutoGenerateColumns = false;
                reviewsGrid.DataSource = result;

                var restoran = await _serviceRestoran.GetById<MRestoran>(RestoranID);
                txtRating.Text = restoran.Rating.ToString();
            }
            else
            {
                var result = await _serviceReview.Get<List<MReview>>(new ReviewSearchRequest { ProduktId = _produktId });

                reviewsGrid.AutoGenerateColumns = false;
                reviewsGrid.DataSource = result;

                var proizvod = await _serviceProdukti.GetById<MProdukti>(_produktId);
                txtRating.Text = proizvod.Rating.ToString();
            }

            
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            var stringg = txtPretrazi.Text;

            int rowIndex = -1;
            foreach (DataGridViewRow row in reviewsGrid.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(stringg))
                {
                    rowIndex = row.Index;
                    break;
                }
                else if (row.Cells[3].Value.ToString().Equals(stringg))
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            if (rowIndex != -1)
            {
                reviewsGrid.ClearSelection();
                reviewsGrid.Rows[rowIndex].Selected = true;
            }
        }

        private void reviewsGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = reviewsGrid.SelectedRows[0].Cells[0].Value;

            frmSingleReview frm = new frmSingleReview(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}

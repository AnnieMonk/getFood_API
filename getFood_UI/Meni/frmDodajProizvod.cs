using getFood_Model;
using getFood_Model.Requests;
using getFood_UI.Home;
using getFood_UI.Properties;
using getFood_UI.Restoran;
using getFood_UI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;

namespace getFood_UI.Meni
{
    public partial class frmDodajProizvod : Form
    {
     
        private readonly APIService _serviceSastojci = new APIService("Sastojci");
        private readonly APIService _serviceProdukti = new APIService("Produkti");
        private readonly APIService _serviceProduktiSastojci = new APIService("ProduktiSastojci");
        private readonly APIService _serviceKategorija = new APIService("Kategorija");
        private readonly APIService _serviceMeni = new APIService("Meni");
        private readonly APIService _serviceMeniProdukti = new APIService("MeniProdukti");
    
        private int? _id = null;
      
        ProduktiUpsertRequest request = new ProduktiUpsertRequest();
        private Jelovnik _jelovnik;
        public frmDodajProizvod(Jelovnik jelovnik, int? Id = null)
        {
            InitializeComponent();
            _jelovnik = jelovnik;
            _id = Id;
         
           
        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Proizvod
        private async void frmDodajProizvod_Load(object sender, EventArgs e)
        {

            await LoadSastojke();
            await LoadMeni();
            await LoadKategorije();
            

            if (_id.HasValue)
            {

                txtRating.Visible = true;
                pictureBox7.Visible = true;
                lblRating.Visible = true;
                picDodajUredi.Visible = false;
                picUrediUredi.Visible = false;
                picPregledUredi.Visible = true;
                txtNaziv.ReadOnly = true;
                txtOpis.ReadOnly = true;
                decCijena.ReadOnly = true;
                chListSastojci.SelectionMode = SelectionMode.None;
                chbMeni.SelectionMode = SelectionMode.None;
                cmbKategorija.Enabled = false;
                txtSlika.Visible = true;
                btnDodajSliku.Visible = false;
                label5.Visible = true;
                btnUredi.Visible = true;
                picEdit.Visible = true;
                picNew.Visible = false;
                txtDodajSastojak.Visible = false;
                btnDodajSastojak.Visible = false;
                btnPretraziSastojak.Visible = false;
                txtPretraziSastojak.Visible = false;
                btnSnimiProizvod.Visible = false;
                btnObrisiProizvod.Visible = true;
                var proizvod = await _serviceProdukti.GetById<MProdukti>(_id);
                
                txtNaziv.Text = proizvod.Naziv;
                txtOpis.Text = proizvod.Opis;
                decCijena.Value = proizvod.Cijena;
                txtRating.Text = proizvod.Rating.ToString();


                MemoryStream ms = new MemoryStream((Byte[])proizvod.SlikaThumb);
                picDodajProizvod.Image = new Bitmap(ms);
                picDodajProizvod.SizeMode = PictureBoxSizeMode.StretchImage;

                txtSlika.Text = ConvertBytesToString((Byte[])proizvod.Slika);

               
               


            }
            else
            {
                
                btnObrisiProizvod.Visible = false;
                picNew.Visible = true;
                picEdit.Visible = false;
                btnUredi.Visible = false;
                
               
         
            }
           
            
        }
        private async void btnUredi_Click(object sender, EventArgs e)
        {


            picNew.Visible = true;
            picEdit.Visible = false;
            btnUredi.Visible = false;
            txtNaziv.ReadOnly = false;
            txtOpis.ReadOnly = false;
            decCijena.ReadOnly = false;
            chListSastojci.SelectionMode = SelectionMode.One;
            chbMeni.SelectionMode = SelectionMode.One;
            btnSnimiProizvod.Visible = true;
            txtPretraziSastojak.Visible = true;
            btnPretraziSastojak.Visible = true;
            btnDodajSastojak.Visible = true;
            txtDodajSastojak.Visible = true;
            txtSlika.Visible = true;
            btnDodajSliku.Visible = true;
            label5.Visible = true;
            txtSastojci.Visible = true;
            btnObrisiProizvod.Visible = true;
            cmbKategorija.Enabled = true;
            picDodajUredi.Visible = false;
            picPregledUredi.Visible = false;
            picUrediUredi.Visible = true;
           
            await LoadSastojke(true);

            await LoadMeni(true);

            await LoadKategorije();


        }
        private async void btnSnimiProizvod_Click(object sender, EventArgs e)
        {
           
            var sastojci = chListSastojci.CheckedItems.Cast<MSastojci>().Select(x => x.SastojciId).ToList();
            var meni = chbMeni.CheckedItems.Cast<MMeni>().Select(x => x.MeniId).ToList();

            request.Naziv = txtNaziv.Text;
            request.Cijena = decCijena.Value;
            request.Opis = txtOpis.Text;
            request.Sastojci = sastojci;
            request.Meni = meni;

            
            AddReplacePicture();

            var kategorija = cmbKategorija.SelectedValue;

            if (int.TryParse(kategorija.ToString(), out int kategorijaId))
            {
                request.KategorijaId = kategorijaId;
            }

            if (_id.HasValue)
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    await _serviceProdukti.Update<MProdukti>(_id, request);
                    MessageBox.Show("Operacija uspješna");
                    this.Close();
                    await _jelovnik.UpdateForm();
                }
               
                  
              
              
            }
            else
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    await _serviceProdukti.Insert<MProdukti>(request);

                    MessageBox.Show("Operacija uspješna");


                    this.Close();
                    await _jelovnik.UpdateForm();

                }


            }
        }
        private async void btnObrisiProizvod_Click(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni?", "Upozorenje", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var result = await _serviceProdukti.Delete(_id);
                    if (result == true)
                    {
                        this.Close();
                        await _jelovnik.UpdateForm();
                    }
                    else
                    {
                        MessageBox.Show("Greška!");
                    }
                }
            }

        }

        #endregion

        #region Slika Hrane
       
        public static string ConvertBytesToString(byte[] bytes)
        {
            string output = String.Empty;
            MemoryStream stream = new MemoryStream(bytes);
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);

            output = reader.ReadToEnd();

            return output;
        }
        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
           

            try
            {
                
                openFileDialog1.ShowDialog();

                var filename = openFileDialog1.FileName;
                txtSlika.Text = filename;

                request.Slika = File.ReadAllBytes(filename);
                Image orgImage = Image.FromFile(filename);
               
                int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
                int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
             

                if (orgImage.Width > resizedImgWidth)
                {
                    Image resizedImg = UIHelper.ResizeImage(orgImage, resizedImgWidth, resizedImgHeight);

                  
                       // picDodajProizvod.Image = resizedImg;
                       picDodajProizvod.Image = orgImage;
                       picDodajProizvod.SizeMode = PictureBoxSizeMode.StretchImage;

                        MemoryStream ms = new MemoryStream();
                        resizedImg.Save(ms, orgImage.RawFormat);

                        request.SlikaThumb = ms.ToArray();
                }
            }
            catch (Exception)
            {
                request.Slika = null;
                request.SlikaThumb = null;
                txtSlika.Text = null;
                picDodajProizvod.Image = null;
            }
        }
        private void AddReplacePicture()
        {
            MemoryStream ms = new MemoryStream();
            picDodajProizvod.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] buff = ms.GetBuffer();
            request.SlikaThumb = buff;

            byte[] slikaBytes = Encoding.ASCII.GetBytes(txtSlika.Text);
            MemoryStream stream = new MemoryStream(slikaBytes);
            request.Slika = stream.ToArray();
        }
        #endregion

        #region Sastojci
        private async Task LoadSastojke(bool prikaziSve = false)
        {

            if (_id.HasValue && prikaziSve == false)
            {
                var produktiSastojci = await _serviceProduktiSastojci.Get<List<MProduktiSastojci>>(new ProduktiSastojciSearchRequest { ProduktiId = _id });
                chListSastojci.DataSource = produktiSastojci;
                chListSastojci.DisplayMember = "NazivSastojka";
                chListSastojci.ValueMember = "SastojciId";

                for (int i = 0; i < chListSastojci.Items.Count; i++)
                {
                    chListSastojci.SetItemChecked(i, true);

                }

            }

            else if (_id.HasValue && prikaziSve == true)
            {
                var produktiSastojci = await _serviceProduktiSastojci.Get<List<MProduktiSastojci>>(new ProduktiSastojciSearchRequest { ProduktiId = _id });
                var sastojciID = produktiSastojci.Select(i => i.SastojciId).ToList();

                var sviSastojci = await _serviceSastojci.Get<List<MSastojci>>(null);
                chListSastojci.DataSource = sviSastojci;
                chListSastojci.DisplayMember = "Naziv";
                chListSastojci.ValueMember = "SastojciId";

                int index = -1;
                foreach (var sastojak in sviSastojci)
                {
                    if (sastojciID.Contains(sastojak.SastojciId))
                    {
                        index = chListSastojci.FindString(sastojak.Naziv);
                        chListSastojci.SetItemChecked(index, true);
                    }
                   
                }

            }
            else
            {
                var sastojciOznaceni = chListSastojci.CheckedItems.Cast<MSastojci>().ToList();

                var sviSastojci = await _serviceSastojci.Get<List<MSastojci>>(null);
                chListSastojci.DataSource = sviSastojci;
                chListSastojci.DisplayMember = "Naziv";
                chListSastojci.ValueMember = "SastojciId";

              
                if (sastojciOznaceni.Count != 0)
                {
                    int index = -1;
                    foreach (var x in sastojciOznaceni)
                    {
                        index = chListSastojci.FindString(x.Naziv);
                        if (index != -1)
                        {
                            chListSastojci.SetItemChecked(index, true);
                        }

                    }

                }
            }
        }
        private async Task DodajSastojak()
        {
            var listaSastojaka = await _serviceSastojci.Get<List<MSastojci>>(null);
            foreach (var x in listaSastojaka)
            {
                if (x.Naziv == txtDodajSastojak.Text)
                {

                    MessageBox.Show("Sastojak već postoji!");
                    return;
                }
            }

            var request = new SastojciUpsertRequest
            {
                Naziv = txtDodajSastojak.Text
            };

            await _serviceSastojci.Insert<MSastojci>(request);

            if (_id.HasValue)
                await LoadSastojke(true);
            else
                await LoadSastojke(false);
           
           
        
            

           int index = chListSastojci.FindString(request.Naziv);
           
            chListSastojci.SetItemChecked(index, true);
            chListSastojci.SetSelected(index, true);

        }
        private async void btnDodajSastojak_Click(object sender, EventArgs e)
        {
            await DodajSastojak();
           
        }
        private async void txtDodajSastojak_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await DodajSastojak();
            }
        }

      
        private void txtPretraziSastojak_TextChanged(object sender, EventArgs e)
        {
            var stringg = txtPretraziSastojak.Text;

            int indexx = chListSastojci.FindString(stringg);

            if (indexx != -1)
                chListSastojci.SelectedIndex = indexx;
        }


        #endregion

        #region Kategorija

        private async Task LoadKategorije()
        {
            var result = await _serviceKategorija.Get<List<MKategorija>>(null);
            result.Insert(0, new MKategorija() { Naziv = "Odaberite" });
            cmbKategorija.DataSource = result;
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "KategorijaId";

            int index = 0;
            if (_id.HasValue)
            {

                var produkt = await _serviceProdukti.GetById<MProdukti>(_id);
                var kategorija = await _serviceKategorija.GetById<MKategorija>(produkt.KategorijaId);
                index = cmbKategorija.FindString(kategorija.Naziv);
             

            }
          
           
            cmbKategorija.SelectedIndex = index;

        }
        #endregion
        #region Meni

        private async Task LoadMeni(bool prikaziSve = false)
        {
            int restoranId = Global.prijavljeniRestoran.RestoranId;

            if (_id.HasValue && prikaziSve == false)
            {
                var meniProdukti = await _serviceMeniProdukti.Get<List<MMeniProdukti>>(new MeniProduktiSearchRequest { ProduktiId = _id, RestoranId = restoranId });

                chbMeni.DataSource = meniProdukti;
                chbMeni.DisplayMember = "NazivMenija";
                chbMeni.ValueMember = "MeniId";

                for (int i = 0; i < chbMeni.Items.Count; i++)
                {
                    chbMeni.SetItemChecked(i, true);
                   
                }

            }

            else if(_id.HasValue && prikaziSve == true)
            {
                var meniProdukti = await _serviceMeniProdukti.Get<List<MMeniProdukti>>(new MeniProduktiSearchRequest { ProduktiId = _id, RestoranId=restoranId });

                var MeniID = meniProdukti.Select(i => i.MeniId).ToList();
               

                var sviMeniji = await _serviceMeni.Get<List<MMeni>>(new MeniSearchRequest { RestoranId = restoranId });
                chbMeni.DataSource = sviMeniji;
                chbMeni.DisplayMember = "Naziv";
                chbMeni.ValueMember = "MeniId";

                int index = -1;
                foreach (var meni in sviMeniji)
                {
                    if (MeniID.Contains(meni.MeniId))
                    {
                        index = chbMeni.FindString(meni.Naziv);
                        chbMeni.SetItemChecked(index, true);
                    }

                }

            }
            else
            {
               
                var sviMeniji = await _serviceMeni.Get<List<MMeni>>(new MeniSearchRequest { RestoranId = restoranId});
                chbMeni.DataSource = sviMeniji;
                chbMeni.DisplayMember = "Naziv";
                chbMeni.ValueMember = "MeniId";
            }

        }



        #endregion

        #region Reviews

        private void txtRating_Click(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                frmPregledReviews frm = new frmPregledReviews(_id);
                frm.Show();
            }
            else
            {
                frmPregledReviews frm = new frmPregledReviews();
                frm.Show();
            }
        }
        #endregion

        #region Validacija
        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                e.Cancel = true;
                txtNaziv.Focus();
                errorProviderProdukti.SetError(txtNaziv, Resources.Validation_RequiredField);
            }
            else
            {
                e.Cancel = false;
                errorProviderProdukti.SetError(txtNaziv, null);

            }
        }

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                e.Cancel = true;
                txtOpis.Focus();
                errorProviderProdukti.SetError(txtOpis, Resources.Validation_RequiredField);
            }
            else
            {
                e.Cancel = false;
                errorProviderProdukti.SetError(txtOpis, null);
            }
        }

        private void chbMeni_Validating(object sender, CancelEventArgs e)
        {
            if (chbMeni.CheckedItems.Count <= 0)
            {
                e.Cancel = true;
                chbMeni.Focus();
                errorProviderProdukti.SetError(chbMeni, Resources.Validation_RequiredField);
            }
            else
            {
                e.Cancel = false;
                errorProviderProdukti.SetError(chbMeni, null);
            }
        }

        private void chListSastojci_Validating(object sender, CancelEventArgs e)
        {
            if (chListSastojci.CheckedItems.Count <= 0)
            {
                e.Cancel = true;
                chListSastojci.Focus();
                errorProviderProdukti.SetError(chListSastojci, Resources.Validation_RequiredField);
            }
            else
            {
                e.Cancel = false;
                errorProviderProdukti.SetError(chListSastojci, null);
            }
        }

        private void txtSlika_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSlika.Text))
            {
                e.Cancel = true;
                txtSlika.Focus();
                errorProviderProdukti.SetError(txtSlika, Resources.Validation_RequiredField);
            }
            else
            {
                e.Cancel = false;
                errorProviderProdukti.SetError(txtSlika, null);
            }
        }

        private void decCijena_Validating(object sender, CancelEventArgs e)
        {
            if (decCijena.Value <= 0)
            {
                e.Cancel = true;
                decCijena.Focus();
                errorProviderProdukti.SetError(decCijena, Resources.Validation_RequiredField);
            }
            else
            {
                e.Cancel = false;
                errorProviderProdukti.SetError(decCijena, null);
            }
        }

        private void cmbKategorija_Validating(object sender, CancelEventArgs e)
        {
            if (cmbKategorija.SelectedIndex <= 0)
            {
                e.Cancel = true;
                cmbKategorija.Focus();
                errorProviderProdukti.SetError(cmbKategorija, Resources.Validation_RequiredField);
            }
            else
            {
                e.Cancel = false;
                errorProviderProdukti.SetError(cmbKategorija, null);
            }
        }
        private void txtDodajSastojak_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDodajSastojak.Text))
            {
                e.Cancel = true;
                errorProviderProdukti.SetError(txtDodajSastojak, "Ne možete dodati prazno polje");
            }
            else
            {
                e.Cancel = false;
                errorProviderProdukti.SetError(txtDodajSastojak, null);
            }
        }
        #endregion


    }
}

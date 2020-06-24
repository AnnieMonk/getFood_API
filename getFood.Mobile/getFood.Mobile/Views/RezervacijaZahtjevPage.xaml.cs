using Android.Text.Format;
using getFood.Mobile.ViewModels;
using getFood_Model;
using getFood_Model.Requests;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace getFood.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RezervacijaZahtjevPage : PopupPage
    {
        private readonly APIService _rezervacijeService = new APIService("Rezervacije");
        public RezervacijaViewModel model = null;
        TimeSpan radnoVrijemeStart = TimeSpan.Parse("08:00");
        public RezervacijaZahtjevPage(MRestoran restoran)
        {
            InitializeComponent();
            BindingContext = model = new RezervacijaViewModel() { Restoran = restoran };

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            korisnikEntry.Text = Global.prijavljeniKupac.Ime + " " + Global.prijavljeniKupac.Prezime;
        }
        protected async override void OnDisappearing()
        {
            base.OnDisappearing();
            await model.Init();
        }
        private async void Zatvori_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync(true);

        }

        private void brojLjudi_TextChanged(object sender, TextChangedEventArgs e)
        {
             if(!string.IsNullOrWhiteSpace(e.NewTextValue)) 
            { 
                 bool isValid = e.NewTextValue.ToCharArray().All(x=>char.IsDigit(x));

                ((Entry)sender).Text = isValid ? e.NewTextValue : e.NewTextValue.Remove(e.NewTextValue.Length - 1);
            }
        }
     
        private void ValidirajPolja()
        {

            ErrorLabelDatum.Text = null;
            if(zeljeniDatumDostave.Date < DateTime.Now || zeljeniDatumDostave.Date == DateTime.Now)
            {
                ErrorLabelDatum.Text = "Odaberite neki datum u budućnosti.";
               
            }
            ErrorLabelVrijeme.Text = null;
            
            if (zeljenoVrijemeDostave.Time < radnoVrijemeStart)
            {
                ErrorLabelVrijeme.Text = "Unesite vrijeme počevši od 08:00h";
            }
            ErrorLabelLjudi.Text = null;
            if (brojLjudi.Text == null)
            {
                ErrorLabelLjudi.Text = "Polje je mandatorno!";
            }
        }
        private async void Posalji_Clicked(object sender, EventArgs e)
        {
            ValidirajPolja();

            if(ErrorLabelImePrezime.Text == null && ErrorLabelDatum.Text==null && ErrorLabelVrijeme.Text==null && ErrorLabelLjudi.Text ==null)
            {
                //napravi rezervaciju sa statusom nepoznato
                RezervacijeUpsertRequest request = new RezervacijeUpsertRequest
                {
                    BrojLjudi = Convert.ToInt32(brojLjudi.Text),
                    DatumVrijeme = zeljeniDatumDostave.Date + zeljenoVrijemeDostave.Time,
                    KorisnikId = Global.prijavljeniKupac.KorisnikId,
                    Napomena = napomenaEditor.Text,
                    RestoranId = model.Restoran.RestoranId,
                    StatusId = 3

                };

                await _rezervacijeService.Insert<MRezervacije>(request);

                await DisplayAlert("Uspjeh", "Vaš zahtjev je zaprimljen!", "OK");
                await PopupNavigation.Instance.PopAsync(false);

            }


        }
    }
}
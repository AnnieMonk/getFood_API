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
    public partial class ReviewsPage : PopupPage
    {
        private readonly APIService _reviewsService = new APIService("Review");

        public ReviewsViewModel model = null;
        public ReviewsPage(MRestoran restoran, MMeniProdukti produkt)
        {
            InitializeComponent();
            BindingContext = model = new ReviewsViewModel() { Restoran = restoran, Produkt=produkt };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
          

        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Send<App>((App)Application.Current, "OnReviewAdded");
        }
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var slider = sender as Slider;

            ocjena.Text = slider.Value.ToString("0");
          //  model.MinimalnaNarudzba = Convert.ToInt32(slider.Value);
        }

        private async void zatvori_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync(true);
           
        }

        private async void Dodaj_Clicked(object sender, EventArgs e)
        {
            //napravi novi reviewrequest

            ErrorLabelOcjena.Text = null;
            if(ocjena.Text == null)
            {
                ErrorLabelOcjena.Text = "Odaberite ocjenu";
            }
            else
            {
                ReviewUpsertRequest request = new ReviewUpsertRequest
                {
                    Ime = Global.prijavljeniKupac.Ime,
                    Prezime = Global.prijavljeniKupac.Prezime,
                    Komentar = komentar.Text,
                    Ocjena = Convert.ToInt32(ocjena.Text),

                    KorisnikId = Global.prijavljeniKupac.KorisnikId,
                    Datum = DateTime.Now

                };
                if (model.Produkt == null)
                {
                    request.ProduktiId = null;
                }
                else
                    request.ProduktiId = model.Produkt.ProduktiId;

                if (model.Restoran == null)
                {
                    request.RestoranId = null;
                }
                else
                    request.RestoranId = model.Restoran.RestoranId;

                await _reviewsService.Insert<MReview>(request);

                await model.Init();
            }

            
        }
    }
}
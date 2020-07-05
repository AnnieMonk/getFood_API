using Android.Views;
using getFood.Mobile.ViewModels;
using getFood_Model;
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
    public partial class ProduktiPage : ContentPage
    {
        public ProduktiViewModel model = null;

        public MRestoran _restoran = null;
        public ProduktiPage(MRestoran restoran)
        {
            InitializeComponent();
            _restoran = restoran;
            BindingContext = model = new ProduktiViewModel() { Restoran = restoran};
            MessagingCenter.Subscribe<App>((App)Application.Current, "OnReviewAdded", (sender) => {
                model.Init();
            });

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
          
            await model.Init();
          
            kategorijaList.SelectedIndex = 0;
            meniList.SelectedIndex = 0;


        }
       
        private async void produkt_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new ProduktiDetailPage(e.Item as MMeniProdukti));

        }

        private async void vidiKorpu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KorpaPage());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Filter.IsVisible == true)
                Filter.IsVisible = false;
            else
                Filter.IsVisible = true;
        }

        private async void Vidi_Tapped(object sender, EventArgs e)
        {
            //otvara popup sa svim reviews gdje moze dodati svoj
            await PopupNavigation.Instance.PushAsync(new ReviewsPage(model.Restoran, null));

        }

        private async void Rezervisi_Clicked(object sender, EventArgs e)
        {
            //otvori zahtjev za rezervaciju
            await PopupNavigation.Instance.PushAsync(new RezervacijaZahtjevPage(model.Restoran));
        }

        private async void DodajFavorit_Clicked(object sender, EventArgs e)
        {
            await model.DodajUFavorite();
          
        }
    }
}
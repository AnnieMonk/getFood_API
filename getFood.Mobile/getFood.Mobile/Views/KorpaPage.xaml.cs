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
    public partial class KorpaPage : ContentPage
    {
        private NarudzbaViewModel model = null;
        public KorpaPage()
        {
         
            InitializeComponent();
            BindingContext = model = new NarudzbaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();

            if (CartService.Cart.Count > 0)
            {
                listaKorpa.IsVisible = true;
                ukupno.IsVisible = true;
                praznaKorpa.IsVisible = false;
            }

        }

        private void promjenaKolicine_Tapped(object sender, EventArgs e)
        {
            CartService.Ukupno = 0;
            foreach (var item in CartService.Cart.Values)
            {
               
                CartService.Ukupno += item.CijenaProizvoda;

            }
            ukupnoEntry.Text = CartService.Ukupno.ToString();
         
        }

        private async void posaljiNarudzbu_Clicked(object sender, EventArgs e)
        {
            
            if(CartService.Ukupno >= model.MinimalnaNarudzba)
            {
                await Navigation.PushAsync(new InfoNarudzbaPage(model));
            }
            else
            {
                await DisplayAlert("Upozorenje", "Minimalna narudžba je " + model.MinimalnaNarudzba +"KM, dodajte još proizvoda u korpu!", "OK");
            }
         
        }

        private void ukloni_Tapped(object sender, EventArgs e)
        {
           model.Init();
        }
    }
}
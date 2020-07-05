
using getFood.Mobile.ViewModels;
using getFood_Model;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace getFood.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        

        public HomePageViewModel model = null;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = model = new HomePageViewModel();
            
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
           

            await model.Init();
            kuhinjaList.SelectedIndex = 0;
            
            await GPS();
            Adresa.Text = LocationInfo.Adresa;

        }
     
        private async void naruci_OnSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(CartService.Cart.Count > 0)
            {
                var restoran = e.SelectedItem as MRestoran;
                foreach(var x in CartService.Cart.Values)
                {
                    if(x.RestoranId != restoran.RestoranId)
                    {
                        var result = await DisplayAlert("Upozorenje", "Korpa će biti ispražnjena. Nastaviti?", "DA", "NE");
                        if (result == false)
                        {
                            return;
                          
                        }
                        else
                        {
                            CartService.Cart.Clear();
                            break;
                        }
                    }
                }
            }

            await Navigation.PushAsync(new ProduktiPage(e.SelectedItem as MRestoran));

        }

        public async Task GPS()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);


                Geocoder geoCoder = new Geocoder();


                IEnumerable<string> possibleAddresses = await geoCoder.GetAddressesForPositionAsync(new Position(location.Latitude, location.Longitude));

                string result = possibleAddresses.FirstOrDefault();
                string address = result.Split('\n')[0].Trim();
                string city = result.Split('\n')[1].Trim();

                LocationInfo.Adresa = address;
                LocationInfo.Grad = city;
            }
            catch(Exception ex)
            {
                await DisplayAlert("Upozorenje", ex.Message, "Uredu");
                LocationInfo.Adresa = " ";
                LocationInfo.Grad = " ";
            }
           
        }
       
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Filter.IsVisible == true)
                Filter.IsVisible = false;
            else
                Filter.IsVisible = true;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var slider = sender as Slider;

            minimalnaNarudzba.Text = slider.Value.ToString("0");
            model.MinimalnaNarudzba = Convert.ToInt32(slider.Value);
        }

        private async void Odjava_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }
    }
}
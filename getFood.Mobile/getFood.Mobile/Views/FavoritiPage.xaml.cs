using getFood.Mobile.ViewModels;
using getFood_Model;
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
    public partial class FavoritiPage : ContentPage
    {
        public FavoritiViewModel model = null;
        MFavoriti item = null;
        public FavoritiPage()
        {
            InitializeComponent();
            BindingContext = model = new FavoritiViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            kuhinjaList.SelectedIndex = 0;
        }

        private void filtriraj_Tapped(object sender, EventArgs e)
        {

            if (Filter.IsVisible == true)
                Filter.IsVisible = false;
            else
                Filter.IsVisible = true;
        }

        private async void ListaRestorana_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            item = e.SelectedItem as MFavoriti;
            if (CartService.Cart.Count > 0)
            {
                var restoran = e.SelectedItem as MRestoran;
                foreach (var x in CartService.Cart.Values)
                {
                    if (x.RestoranId != restoran.RestoranId)
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


    }
}
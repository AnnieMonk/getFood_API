using getFood.Mobile.ViewModels;
using getFood_Model;
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
    public partial class NarudzbaPage : ContentPage
    {
        private static NarudzbaViewModel model = null;

        public NarudzbaPage()
        {
            InitializeComponent();
            BindingContext = model = new NarudzbaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.NarudzbeKorisnikInit();
            restoranList.SelectedIndex = 0;
        }

        private void filtriraj_Tapped(object sender, EventArgs e)
        {
            if (Filter.IsVisible == true)
                Filter.IsVisible = false;
            else
                Filter.IsVisible = true;
        }

     
    }
}
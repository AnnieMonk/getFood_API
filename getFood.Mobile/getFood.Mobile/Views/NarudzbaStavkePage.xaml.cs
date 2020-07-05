using getFood.Mobile.ViewModels;
using getFood_Model;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms.Xaml;

namespace getFood.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NarudzbaStavkePage : PopupPage
    {
        private NarudzbaViewModel model = null;

        private MNarudzba _narudzba;
        public NarudzbaStavkePage(MNarudzba narudzba)
        {
            InitializeComponent();
            BindingContext = model = new NarudzbaViewModel() { Narudzba = narudzba};
            _narudzba = narudzba;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.NarudzbaStavkeInit();
        }

        private async void zatvori_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync(true);
        }
    }
}
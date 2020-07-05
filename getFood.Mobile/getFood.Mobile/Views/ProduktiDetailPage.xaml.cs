using getFood.Mobile.ViewModels;
using getFood_Model;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace getFood.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProduktiDetailPage : PopupPage
    {
        public ProduktDetailViewModel model = null;
        public ProduktiDetailPage(MMeniProdukti _meniProdukt)
        {
            InitializeComponent();

            BindingContext = model = new ProduktDetailViewModel { MeniProdukt = _meniProdukt, NazivProizvoda=_meniProdukt.Naziv, OpisProizvoda = _meniProdukt.Opis, CijenaProizvoda=_meniProdukt.Cijena, RestoranId = _meniProdukt.RestoranId, SlikaThmb = _meniProdukt.SlikaThumb, Rating=_meniProdukt.Rating};
            MessagingCenter.Subscribe<App>((App)Application.Current, "OnReviewAdded", (sender) => {
                model.Init();
            });
           


        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            await model.RecommendInit();

        }
    
        private async void zatvori_Clicked(object sender, EventArgs e)
        {
          
            await PopupNavigation.Instance.PopAsync(true);
           
            
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new ReviewsPage(null, model.MeniProdukt));

        }
    }
}
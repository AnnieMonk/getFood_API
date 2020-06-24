using getFood.Mobile.ViewModels;
using getFood_Model;
using getFood_Model.Requests;
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
    public partial class RezervacijePage : ContentPage
    {
        private readonly APIService _rezervacijeService = new APIService("Rezervacije");

        public RezervacijaViewModel model = null;
        public RezervacijePage()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
           
            await model.Init();
            if (model.RezervacijeList.Count == 0)
            {
                noRezervacije.IsVisible = true;
                listaRezervacija.IsVisible = false;
            }
            restoranList.SelectedIndex = 0;
            statusList.SelectedIndex = 0;

          
     
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Filter.IsVisible == true)
                Filter.IsVisible = false;
            else
                Filter.IsVisible = true;
        }

        private async void listaRezervacija_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MRezervacije rezervacija = (MRezervacije) e.SelectedItem;
            if (rezervacija.Status == "Nepoznato")
                await DisplayAlert("Informacija", "Zahtjev je još uvijek u obradi", "OK");
            else if (rezervacija.Status == "Otkazana")
                await DisplayAlert("Informacija", "Ova rezervacija je otkazana", "OK");
            else if (rezervacija.Status == "Potvrđena")
            {
                var result = await DisplayAlert("Promjena statusa", "Želite li otkazati rezervaciju?", "DA", "NE");
                if(result == true)
                {
                    RezervacijeUpsertRequest request = new RezervacijeUpsertRequest { StatusId = 1, DatumVrijeme = rezervacija.DatumVrijeme, BrojLjudi=rezervacija.BrojLjudi, KorisnikId=rezervacija.KorisnikId,Napomena=rezervacija.Napomena, RestoranId=rezervacija.RestoranId};
                    await _rezervacijeService.Update<MRezervacije>(rezervacija.RezervacijaId, request);
                    await model.Init();
                }
            }
        }
    }
}
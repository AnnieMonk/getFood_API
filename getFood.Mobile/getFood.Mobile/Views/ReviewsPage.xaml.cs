using getFood.Mobile.ViewModels;
using getFood_Model;
using getFood_Model.Requests;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Application = Xamarin.Forms.Application;

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
                bool daLiPostojiProdukt = true;
                bool daLiPostojiRestoran = true;
                List<MReview> reviewZaProdukt = null;
                List<MReview> reviewZaRestoran = null;
                if(model.Produkt != null)
                {
                    reviewZaProdukt = await _reviewsService.Get<List<MReview>>(new ReviewSearchRequest { ProduktId = model.Produkt.ProduktiId, KorisnikId = Global.prijavljeniKupac.KorisnikId });
                    if(reviewZaProdukt.Count == 0)
                    {
                        daLiPostojiProdukt = false;
                    }

                }
                if(model.Restoran != null)
                {
                    reviewZaRestoran = await _reviewsService.Get<List<MReview>>(new ReviewSearchRequest { RestoranId = model.Restoran.RestoranId, KorisnikId = Global.prijavljeniKupac.KorisnikId });
                    if(reviewZaRestoran.Count == 0)
                    {
                        daLiPostojiRestoran = false;
                    }
                }

                if(daLiPostojiProdukt == false || daLiPostojiRestoran == false)
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
                else
                {
                    if(model.Produkt != null)
                    {
                        var upit = await DisplayAlert("Upozorenje", "Već ste dodali osvrt za ovaj proizvod, želite li ga obrisati?", "Da", "Ne");
                        if (upit == true)
                        {
                            await _reviewsService.Delete(reviewZaProdukt.Select(i => i.ReviewId).First());
                            await DisplayAlert("Upozorenje", "Uspješno obrisan osvrt, sada možete dodati novi", "Uredu");
                            await model.Init();
                        }

                    }
                    if (model.Restoran != null)
                    {
                        var upit = await DisplayAlert("Upozorenje", "Već ste dodali osvrt za ovaj restoran, želite li ga obrisati?", "Da", "Ne");
                        if (upit == true)
                        {
                            await _reviewsService.Delete(reviewZaRestoran.Select(i => i.ReviewId).First());
                            await DisplayAlert("Upozorenje", "Uspješno obrisan osvrt, sada možete dodati novi", "Uredu");
                            await model.Init();
                        }

                    }
                }
             
            }

            
        }
    }
}
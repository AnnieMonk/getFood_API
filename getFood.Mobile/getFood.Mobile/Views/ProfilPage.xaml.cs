using getFood.Mobile.ViewModels;
using getFood_Model;
using getFood_Model.Requests;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace getFood.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilPage : ContentPage
    {
        private static ProfilViewModel model = null;
        private readonly APIService _korisnikService = new APIService("Korisnik");
        const string emailRegex = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
        const string telefonRegex = "^[+][0-9]{3}[0-9]{2}[/][0-9]{3}[-][0-9]{3}";

        MKartica item = null;
        public ProfilPage()
        {
            InitializeComponent();
            BindingContext = model = new ProfilViewModel();
            MessagingCenter.Subscribe<App>((App)Application.Current, "OnCardCreated", (sender) => {
                model.Init();
            });
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            
        }

        private async void rezervacije_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RezervacijePage());
        }

        private async void favoriti_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FavoritiPage());
        }

        private async void kuponi_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new KuponiPage());
        }

        private async void narudzbe_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new NarudzbaPage());
        }

        private async void promijeniPassword_Clicked(object sender, EventArgs e)
        {

            if (passwordEntry.Text != null && passwordConfirmationEntry.Text != null)
            {
                ErrorLabelConfirmation.Text = null;
                ErrorLabelPassword.Text = null;
                if (passwordEntry.Text.Length >= 6)
                {
                    ErrorLabelPassword.Text = null;
                    if(passwordEntry.Text == passwordConfirmationEntry.Text)
                    {
                        ErrorLabelConfirmation.Text = null;
                        var korisnik = await _korisnikService.GetById<MKorisnik>(Global.prijavljeniKupac.KorisnikId);
                        var uloge = await _korisnikService.Get<List<MKorisnikUloga>>(new KorisnikSearchRequest { KorisnikId = korisnik.KorisnikId });
                        KorisnikUpsertRequest request = new KorisnikUpsertRequest
                        {
                            Adresa = korisnik.Adresa,
                            Email = korisnik.Email,
                            Ime = korisnik.Ime,
                            Prezime = korisnik.Prezime,
                            KorisnickoIme = korisnik.KorisnickoIme,
                            Password = passwordEntry.Text,
                            PasswordConfirmation = passwordEntry.Text,
                            Telefon = korisnik.Telefon,
                            Uloge = uloge.Select(i => i.UlogaId).ToList()
                        };
                        
                            await _korisnikService.Update<MKorisnik>(korisnik.KorisnikId, request);
                            await DisplayAlert("Upozorenje", "Aplikacija će vas odjaviti, potrebno je da se opet prijavite sa novim podacima", "Uredu");
                            await Navigation.PushModalAsync(new LoginPage());
                      
                    }
                    else
                    {
                        ErrorLabelConfirmation.Text = "Passwordi se ne slažu!";
                    }
                    
                }
                else
                {

                    ErrorLabelPassword.Text = "Password mora imati bar 6 karaktera!";
                }
              
              
            }
            else
            {
                //ako jeste jednako null, to znaci da su polja zakljucana, otkljucaj ih
                //ako je zakljucano, a kliknula sam na promjenu
                if (passwordEntry.IsReadOnly == true)
                {
                    //otkljucaj polja i spremi za unos
                    passwordEntry.IsReadOnly = false;
                    passwordEntry.BackgroundColor = Color.White;

                    PasswordConfirmation.IsVisible = true;
                    passwordConfirmationEntry.BackgroundColor = Color.White;

                }
                else
                {
                    ErrorLabelConfirmation.Text = "Polje je mandatorno!";
                    ErrorLabelPassword.Text = "Polje je mandatorno!";
                }

               
            }

           
            
        }

        private async void promijeniEmail_Clicked(object sender, EventArgs e)
        {
            if (promijeniEmailEntry.Text != null)
            {
                ErrorLabelEmail.Text = null;
                if (!(Regex.IsMatch(promijeniEmailEntry.Text, emailRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))))
                {
                    ErrorLabelEmail.Text = "Email nije u tačnom formatu example@gmail.com!";
                  
                }
                else
                {
                    ErrorLabelEmail.Text = null;

                    var korisnik = await _korisnikService.GetById<MKorisnik>(Global.prijavljeniKupac.KorisnikId);
                    var uloge = await _korisnikService.Get<List<MKorisnikUloga>>(new KorisnikSearchRequest { KorisnikId = korisnik.KorisnikId });
                    KorisnikUpsertRequest request = new KorisnikUpsertRequest
                    {
                        Adresa = korisnik.Adresa,
                        Email = promijeniEmailEntry.Text,
                        Ime = korisnik.Ime,
                        Prezime = korisnik.Prezime,
                        KorisnickoIme = korisnik.KorisnickoIme,
                        Password = passwordEntry.Text,
                        PasswordConfirmation = passwordEntry.Text,
                        Telefon = korisnik.Telefon,
                        Uloge = uloge.Select(i => i.UlogaId).ToList()
                    };
                    
                        await _korisnikService.Update<MKorisnik>(korisnik.KorisnikId, request);
                        promijeniEmailEntry.IsReadOnly = true;
                        promijeniEmailEntry.BackgroundColor = Color.LightGray;

                }
              

            }
            else
            {
                if (promijeniEmailEntry.IsReadOnly == true)
                {
                    promijeniEmailEntry.IsReadOnly = false;
                    promijeniEmailEntry.BackgroundColor = Color.White;
                }
                else
                {
                    ErrorLabelEmail.Text = "Polje je mandatorno!";

                }
            }
           
        
        }

        private async void promijeniAdresu_Clicked(object sender, EventArgs e)
        {
            if (promijeniAdresuEntry.Text != null)
            {
                ErrorLabelAdresa.Text = null;
                var korisnik = await _korisnikService.GetById<MKorisnik>(Global.prijavljeniKupac.KorisnikId);
                var uloge = await _korisnikService.Get<List<MKorisnikUloga>>(new KorisnikSearchRequest { KorisnikId = korisnik.KorisnikId });
                KorisnikUpsertRequest request = new KorisnikUpsertRequest
                {
                    Adresa = promijeniAdresuEntry.Text,
                    Email = korisnik.Email,
                    Ime = korisnik.Ime,
                    Prezime = korisnik.Prezime,
                    KorisnickoIme = korisnik.KorisnickoIme,
                    Password = passwordEntry.Text,
                    PasswordConfirmation = passwordEntry.Text,
                    Telefon = korisnik.Telefon,
                    Uloge = uloge.Select(i => i.UlogaId).ToList()
                };
               
                await _korisnikService.Update<MKorisnik>(korisnik.KorisnikId, request);
                promijeniAdresuEntry.IsReadOnly = true;
                promijeniAdresuEntry.BackgroundColor = Color.LightGray;

               

            }
            else
            {
                if (promijeniAdresuEntry.IsReadOnly == true)
                {

                    promijeniAdresuEntry.IsReadOnly = false;
                    promijeniAdresuEntry.BackgroundColor = Color.White;

                }
                else
                {
                    ErrorLabelAdresa.Text = "Polje je mandatorno!";
                }
            }

        }

        private async void promijeniTelefon_Clicked(object sender, EventArgs e)
        {
            if (promijeniTelefonEntry.Text != null)
            {
                ErrorLabelTelefon.Text = null;
                if (!(Regex.IsMatch(promijeniTelefonEntry.Text, telefonRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))))
                {
                    ErrorLabelTelefon.Text = "Telefon nije u tačnom formatu +(387)62/111-111";

                }
                else
                {
                    ErrorLabelTelefon.Text = null;
                    var korisnik = await _korisnikService.GetById<MKorisnik>(Global.prijavljeniKupac.KorisnikId);
                    var uloge = await _korisnikService.Get<List<MKorisnikUloga>>(new KorisnikSearchRequest { KorisnikId = korisnik.KorisnikId });
                    KorisnikUpsertRequest request = new KorisnikUpsertRequest
                    {
                        Adresa = korisnik.Adresa,
                        Email = korisnik.Email,
                        Ime = korisnik.Ime,
                        Prezime = korisnik.Prezime,
                        KorisnickoIme = korisnik.KorisnickoIme,
                        Password = passwordEntry.Text,
                        PasswordConfirmation = passwordEntry.Text,
                        Telefon = promijeniTelefonEntry.Text,
                        Uloge = uloge.Select(i => i.UlogaId).ToList()
                    };
                 
                        await _korisnikService.Update<MKorisnik>(korisnik.KorisnikId, request);
                        promijeniTelefonEntry.IsReadOnly = true;
                        promijeniTelefonEntry.BackgroundColor = Color.LightGray;

                  

                }


            }
            else
            {
                if (promijeniTelefonEntry.IsReadOnly == true)
                {
                    promijeniTelefonEntry.IsReadOnly = false;
                    promijeniTelefonEntry.BackgroundColor = Color.White;
                }
                else
                {

                    ErrorLabelTelefon.Text = "Polje je mandatorno!";
                }
                
            }
        }

       
        private async void dodajNovuKarticu_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new KarticaUnosPage());
        }

       
        private async void ukloni_Tapped(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Upozorenje", "Da li ste sigurni?", "Da", "Ne");
            if(result == true)
            {
                await model.Ukloni(item);
                await model.Init();
            }
           
        }

        private void ukloniIzListe_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            item = e.Item as MKartica;
        }
    }
}
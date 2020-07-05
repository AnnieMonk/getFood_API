
using getFood.Mobile.ViewModels;
using getFood_Model;
using getFood_Model.Requests;

using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace getFood.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoNarudzbaPage : ContentPage
    {
        public NarudzbaViewModel model = new NarudzbaViewModel();
        private readonly APIService _narudzbaService = new APIService("Narudzba");
        private readonly APIService _dostavaService = new APIService("Dostava");
        private readonly APIService _kuponiService = new APIService("Kuponi");
        private string brojKarticeRegex = @"\b(?:(?:\d[ -]*?){17,}|((?:\d[ -]*?){13,16}))\b";
        private string mjesecRegex = @"(^0?[1-9]$)|(^1[0-2]$)";
        private string godinaRefex = @"^[2]\d{3}$";
        const string telefonRegex = "^[+][0-9]{3}[0-9]{2}[/][0-9]{3}[-][0-9]{3}";

        public InfoNarudzbaPage(NarudzbaViewModel _model)
        {
            InitializeComponent();
          
            BindingContext = model = _model;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
           
            //bug je sa xamarinom, da ne prikazuje da su polja upisana sve dok se ne klikne na njih...
            adresaDostave.Text = LocationInfo.Adresa;
         
            korisnikLabel.Text = Global.prijavljeniKupac.Ime + " " + Global.prijavljeniKupac.Prezime;
       
            telefonEntry.Text = Global.prijavljeniKupac.Telefon;
           
            await model.KarticeInit();
            await model.KuponiInit();
            if(model.kuponiList.Count > 0)
            {
                kuponiList.IsVisible = true;
            }

            poUzecuSwitch.IsToggled = true;
        }

        private void poUzecuSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (poUzecuSwitch.IsToggled == true)
                karticaSwitch.IsToggled = false;
            unesiKarticu.IsVisible = false;
        }

        private void karticaSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (karticaSwitch.IsToggled == true)
            {
                poUzecuSwitch.IsToggled = false;
                unesiKarticu.IsVisible = true;
            }
            else
                unesiKarticu.IsVisible = false;

        }

        private void ValidirajKarticu()
        {
            if (creditCardNumber.Text == null)
            {
                ErrorLabelNumber.Text = "Polje je mandatorno!";

            }
            else
            {
                ErrorLabelNumber.Text = null;
                if (!(Regex.IsMatch(creditCardNumber.Text, brojKarticeRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))))
                {
                    ErrorLabelNumber.Text = "Broj kartice nije validan!";

                }
            }
            if (creditCardExpMonth.Text == null)
            {

                ErrorLabelMonth.Text = "Polje je mandatorno!";

            }
            else
            {
                ErrorLabelMonth.Text = null;
                if (!(Regex.IsMatch(creditCardExpMonth.Text, mjesecRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))))
                {
                    ErrorLabelMonth.Text = "Mjesec nije validan!";

                }
            }
            if (creditCardExpYear.Text == null)
            {
                ErrorLabelYear.Text = "Polje je mandatorno!";

            }
            else
            {
                ErrorLabelYear.Text = null;
                if (!(Regex.IsMatch(creditCardExpYear.Text, godinaRefex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))))
                {
                    ErrorLabelYear.Text = "Godina nije validna!";

                }
            }
            if (creditCardSecurityCode.Text == null)
            {
                ErrorLabelCVC.Text = "Polje je mandatorno!";
            }
            else
            {
                ErrorLabelCVC.Text = null;
                if (creditCardSecurityCode.Text.Length < 3 || creditCardSecurityCode.Text.Length > 4)
                {
                    ErrorLabelCVC.Text = "CVC mora imati najmanje 3 broja!";

                }
            }
        }
        private void ValidirajOstalaPolja()
        {
            ErrorLabelKorisnik.Text = null;
            if(korisnikLabel.Text == null)
            {
                ErrorLabelKorisnik.Text = "Polje je mandatorno!";
            }
            ErrorLabelAdresa.Text = null;
            if (adresaDostave.Text == null)
            {
                ErrorLabelAdresa.Text = "Polje je mandatorno!";
            }
            ErrorLabelTelefon.Text = null;
            if (telefonEntry.Text == null)
            {
                ErrorLabelTelefon.Text = "Polje je mandatorno!";
            }
            else
            {
                ErrorLabelTelefon.Text = null;
                if (!(Regex.IsMatch(telefonEntry.Text, telefonRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))))
                {
                    ErrorLabelTelefon.Text = "Telefon nije u tačnom formatu +387xx/xxx-xxx";
                }
            }

            
        }
        private async Task NapraviNarudzbu(string napomena = null)
        {
            
            DateTime trenutnoVrijeme = DateTime.Now;

            var sveDostave = await _dostavaService.Get<List<MDostava>>(null);
            DostavaUpsertRequest requestD = new DostavaUpsertRequest();
            int id = 0;
            if (sveDostave.Count == 0)
            {
                DateTime primanjeNarudzbe = new DateTime();
                if (trenutnoVrijeme.Minute > 30)
                {
                    primanjeNarudzbe = trenutnoVrijeme.AddMinutes(-trenutnoVrijeme.Minute).AddMinutes(60);
                }
                else if (trenutnoVrijeme.Minute < 30)
                {
                    primanjeNarudzbe = trenutnoVrijeme.AddMinutes(-trenutnoVrijeme.Minute).AddMinutes(30);

                }
                var kreceNarudzba = primanjeNarudzbe.AddMinutes(15);
                var stiglaNarudzba = kreceNarudzba.AddMinutes(15);

                requestD.DatumVrijemeStart = kreceNarudzba;
                requestD.DatumVrijemeEnd = stiglaNarudzba;


                var result = await _dostavaService.Insert<MDostava>(requestD);
                id = result.DostavaId;
            }
            else
            {
                
                bool nadjeno = false;
                foreach(var x in sveDostave)
                {
                    var primanjeNarudzbe = x.DatumVrijemeStart.AddMinutes(-15);
                    if(trenutnoVrijeme < primanjeNarudzbe)
                    {
                        id = x.DostavaId;
                        nadjeno = true;
                        break;
                    }
                }

                if(nadjeno == false)
                {
                    DateTime primanjeNarudzbe = new DateTime();
                    if (trenutnoVrijeme.Minute > 30)
                    {
                        primanjeNarudzbe = trenutnoVrijeme.AddMinutes(-trenutnoVrijeme.Minute).AddMinutes(60);
                    }
                    else if (trenutnoVrijeme.Minute < 30)
                    {
                        primanjeNarudzbe = trenutnoVrijeme.AddMinutes(-trenutnoVrijeme.Minute).AddMinutes(30);

                    }
                    var kreceNarudzba = primanjeNarudzbe.AddMinutes(15);
                    var stiglaNarudzba = kreceNarudzba.AddMinutes(15);
                    
                    requestD.DatumVrijemeStart = kreceNarudzba;
                    requestD.DatumVrijemeEnd = stiglaNarudzba;

                     
                    var result = await _dostavaService.Insert<MDostava>(requestD);
                    id = result.DostavaId;
                }
               
            }
          
       
            NarudzbaUpsertRequest requestN = new NarudzbaUpsertRequest
            {
                BrojNarudzbe = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year + "/" + DateTime.Now.Hour + DateTime.Now.Minute,
                Datum = DateTime.Now,
                Napomena = napomena + "\n" + Napomena.Text,
                StatusId = 3,
                DostavaId = id,
                KorisnikId = Global.prijavljeniKupac.KorisnikId,
                RestoranId = model.ProduktDetailViewModel.Select(i => i.RestoranId).FirstOrDefault()
            };

            var kupon = kuponiList.SelectedItem as MKuponi;

           // var resultK = await _kuponiService.GetById<MKuponi>(kupon.KuponId);
            if (kuponiList.SelectedIndex == -1)
                requestN.KuponId = null;
            else
            {
                requestN.KuponId = kupon.KuponId;
                //označi ga kao iskorištenog

                await _kuponiService.Update<MKuponi>(kupon.KuponId, new KuponiUpsertRequest { DatumIsteka = kupon.DatumIsteka, Kod = kupon.Kod, KorisnikId = kupon.KorisnikId, Popust = kupon.Popust, StatusId = kupon.StatusId });
            }
              

            foreach (var item in CartService.Cart)
            {
                requestN.Produkti.Add(item.Key);
                requestN.Kolicine.Add(item.Value.Kolicina);
            }

            await _narudzbaService.Insert<MNarudzba>(requestN);

            await DisplayAlert("Uspjeh", "Vaša dostava je na putu! ", "OK");
            await Navigation.PopToRootAsync(true);
        }

      
        [Obsolete]
        private async void plati_Clicked(object sender, EventArgs e)
        {
            ValidirajOstalaPolja();
            if(ErrorLabelKorisnik.Text == null && ErrorLabelAdresa.Text == null && ErrorLabelTelefon.Text == null)
            {
                if (karticaSwitch.IsToggled == true)
                {
                    ValidirajKarticu();
                    if (ErrorLabelYear.Text == null && ErrorLabelMonth.Text == null && ErrorLabelYear.Text == null && ErrorLabelCVC.Text == null)
                    {
                        StripeConfiguration.SetApiKey("sk_test_dNbO4s6LBoyZhDZYCreZlSqF00K0IGjY5G");

                        Token stripeToken = null;
                        try
                        {
                            var tokenOptions = new TokenCreateOptions()
                            {
                                Card = new CreditCardOptions()
                                {
                                    Number = creditCardNumber.Text,
                                    ExpMonth = Convert.ToInt32(creditCardExpMonth.Text),
                                    ExpYear = Convert.ToInt32(creditCardExpYear.Text),
                                    Cvc = creditCardSecurityCode.Text
                                }
                            };
                            var tokenService = new TokenService();
                            stripeToken = tokenService.Create(tokenOptions);


                            var amount = Convert.ToDouble(ukupnoEntry.Text);
                            //prvo napravi customer-a

                            var customer = new CustomerCreateOptions
                            {
                                Description = "Naplata za kupca",
                                Name = Global.prijavljeniKupac.FullName,
                                Phone = Global.prijavljeniKupac.Telefon,
                                Source = stripeToken.Id
                            };
                            var customerService = new CustomerService();


                            var customerResponse = customerService.Create(customer);
                            var charge = new ChargeCreateOptions
                            {
                                Amount = (long?)(amount * 100),
                                Currency = "bam",
                                Description = "Nova naplata ",
                                // Source = stripeToken.Id
                                Customer = customerResponse.Id
                            };
                            var chargeService = new ChargeService();

                            try
                            {

                                var chargeResponse = chargeService.Create(charge);

                                await NapraviNarudzbu();


                                await Navigation.PopToRootAsync(true);
                                CartService.Cart.Clear();
                            }
                            catch (Exception ex)
                            {
                                await DisplayAlert("Greška", "Nemoguće izvršiti naplatu!" + ex.Message, "OK");

                            }
                        }
                        catch (Exception ex)
                        {
                            await DisplayAlert("Greška", "Podaci sa kartice su netačni!", "OK");
                        }
                    }


                }
                else if (poUzecuSwitch.IsToggled == true)
                {
                    string napomena = "Plaćanje na licu mjesta.";
                    await NapraviNarudzbu(napomena);

                    await Navigation.PopToRootAsync(true);
                    CartService.Cart.Clear();
                }



            }


        }

        private void karticaList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            MKartica odabrana = (MKartica)e.Item;
            creditCardNumber.Text = odabrana.BrojKartice.ToString();
            creditCardExpMonth.Text = odabrana.ExpMonth.ToString();
            creditCardExpYear.Text = odabrana.ExpYear.ToString() ;
            creditCardSecurityCode.Text = odabrana.SecurityCode.ToString();

        }

        private void promjenaTeksta_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                bool isValid = e.NewTextValue.ToCharArray().All(x => char.IsDigit(x));

                ((Entry)sender).Text = isValid ? e.NewTextValue : e.NewTextValue.Remove(e.NewTextValue.Length - 1);
            }
        }
    }
}
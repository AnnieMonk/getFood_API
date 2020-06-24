using Android.Net;
using getFood.Mobile.ViewModels;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace getFood.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KarticaUnosPage : PopupPage
    {
        public static KarticaViewModel model = null;
        public static ProfilViewModel modelProfila = null;
        private string brojKarticeRegex = @"\b(?:(?:\d[ -]*?){17,}|((?:\d[ -]*?){13,16}))\b";
        private string mjesecRegex = @"(^0?[1-9]$)|(^1[0-2]$)";
        private string godinaRefex = @"^[2]\d{3}$";
        public KarticaUnosPage()
        {
            InitializeComponent();
            BindingContext = model = new KarticaViewModel();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Send<App>((App)Application.Current, "OnCardCreated");
        }
        private async void zatvori_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync(true);
           
          
        }

        private void promjenaTeksta_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                bool isValid = e.NewTextValue.ToCharArray().All(x => char.IsDigit(x));

                ((Entry)sender).Text = isValid ? e.NewTextValue : e.NewTextValue.Remove(e.NewTextValue.Length - 1);
            }
        }


        private void ValidirajPolja()
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
        private async void dodaj_Clicked(object sender, EventArgs e)
        {
            ValidirajPolja();
            if(ErrorLabelYear.Text == null && ErrorLabelMonth.Text==null && ErrorLabelYear.Text ==null && ErrorLabelCVC.Text == null)
            {
                //ako nema nikakvih errora onda tek dodaji

                model = new KarticaViewModel();

                model.BrojKartice = Convert.ToInt64(creditCardNumber.Text);
                model.MjesecIsteka = Convert.ToInt32(creditCardExpMonth.Text);
                model.Godina = Convert.ToInt32(creditCardExpYear.Text);
                model.SecurityCode = Convert.ToInt32(creditCardSecurityCode.Text);
                await model.DodajKarticu();

                await PopupNavigation.Instance.PopAsync(true);
            }
          
           
              
            
        }
    }
}
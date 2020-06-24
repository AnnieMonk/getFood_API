using getFood.Mobile.ViewModels;
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            
        }

        private async void RegistracijaButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegistrationPage());
        }
    }
}
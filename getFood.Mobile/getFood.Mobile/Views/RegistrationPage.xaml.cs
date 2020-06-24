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
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
            //NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, true);
        }

        private async void nazad_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
           
        }
    }
}
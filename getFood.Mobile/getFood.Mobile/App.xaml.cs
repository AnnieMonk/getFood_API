using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using getFood.Mobile.Services;
using getFood.Mobile.Views;
namespace getFood.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
          
            MainPage = new LoginPage();
           
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

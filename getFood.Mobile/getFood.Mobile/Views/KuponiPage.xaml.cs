using getFood.Mobile.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace getFood.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KuponiPage : ContentPage
    {
        public static KuponiViewModel model = null;
        public KuponiPage()
        {
            InitializeComponent();
            BindingContext = model = new KuponiViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            statusList.SelectedIndex = 0;
        }

        private void filtriraj_Tapped(object sender, EventArgs e)
        {
            if (Filter.IsVisible == true)
                Filter.IsVisible = false;
            else
                Filter.IsVisible = true;
        }
    }
}
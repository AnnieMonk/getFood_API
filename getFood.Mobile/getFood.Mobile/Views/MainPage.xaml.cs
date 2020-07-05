using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using getFood.Mobile.Models;


namespace getFood.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            

            InitializeComponent();
         
            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Restorani, (NavigationPage)Detail);

        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Profil:
                        MenuPages.Add(id, new NavigationPage(new ProfilPage()) { BarBackgroundColor = Color.FromHex("#028090") });
                        break;
                    case (int)MenuItemType.Restorani:
                        MenuPages.Add(id, new NavigationPage(new HomePage()) { BarBackgroundColor= Color.FromHex("#028090")} );
                        break;
                    case (int)MenuItemType.Korpa:
                        MenuPages.Add(id, new NavigationPage(new KorpaPage()) { BarBackgroundColor = Color.FromHex("#028090") });
                        break;
                   

                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }

           
        }
    }
}
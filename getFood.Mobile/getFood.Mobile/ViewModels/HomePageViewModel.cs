using getFood.Mobile.Views;
using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace getFood.Mobile.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        private readonly APIService _restoraniService = new APIService("Restoran");
        private readonly APIService _kuhinjaService = new APIService("Kuhinja");
        public HomePageViewModel()
        {
            Title = "Restorani";
            InitCommand = new Command(async () => await Init());
          
          
        }
        public ObservableCollection<MRestoran> RestoranList { get; set; } = new ObservableCollection<MRestoran>();
        public ObservableCollection<MRestoran> NajbliziRestoraniList { get; set; } = new ObservableCollection<MRestoran>();
        public ObservableCollection<MKuhinja> KuhinjaList { get; set; } = new ObservableCollection<MKuhinja>();
       
        public ICommand InitCommand { get; set; } 
       

        MKuhinja _selectedKuhinja = null;
        
       
        public MKuhinja SelectedKuhinja
        {
            get { return _selectedKuhinja; }
            set
            {
                SetProperty(ref _selectedKuhinja, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        private int? _minimalnaNarudzba = null;

        public int? MinimalnaNarudzba
        {
            get { return _minimalnaNarudzba; }
            set {
                SetProperty(ref _minimalnaNarudzba, value);
                if (value != 0)
                    
                        InitCommand.Execute(null);
                    
            }
        }
     
        public async Task Init()
        {

           

            if (KuhinjaList.Count == 0)
            {
                
                var kuhinje = await _kuhinjaService.Get<IEnumerable<MKuhinja>>(null);

                KuhinjaList.Insert(0, new MKuhinja { Naziv = "Sve" });
                

                foreach (var y in kuhinje)
                {
                    KuhinjaList.Add(y);
                }

            }

            //List<MRestoran> list = null;

            if (SelectedKuhinja != null)
            {

                
                if (SelectedKuhinja.KuhinjaId == 0 && MinimalnaNarudzba == null)
                {
                    
                    var list = await _restoraniService.Get<List<MRestoran>>(null);
                    await PopulateList(list);
                    
                }

                else if(SelectedKuhinja.KuhinjaId == 0 && MinimalnaNarudzba != null)
                {
                   
                    //prikazi sve kuhinje ali odabranu minimalnu
                    var list = await _restoraniService.Get<List<MRestoran>>(new RestoranSearchRequest { MinimalnaNarudzba = MinimalnaNarudzba });
                    await PopulateList(list);

                }

                else if(SelectedKuhinja.KuhinjaId > 0 && MinimalnaNarudzba == null)
                {
                   
                    //odabrane je kuhinja ali nije minimalno
                    var list = await _restoraniService.Get<List<MRestoran>>(new RestoranSearchRequest { KuhinjaId = SelectedKuhinja.KuhinjaId});
                    await PopulateList(list);


                }
                else if(SelectedKuhinja.KuhinjaId > 0 && MinimalnaNarudzba != null)
                {
                  
                    //odabrano oboje

                    var list = await _restoraniService.Get<List<MRestoran>>(new RestoranSearchRequest { KuhinjaId = SelectedKuhinja.KuhinjaId, MinimalnaNarudzba = MinimalnaNarudzba });
                    await PopulateList(list);

                }

            }
            else 
            {
               
                var list = await _restoraniService.Get<List<MRestoran>>(null);
                await PopulateList(list);


            }

         


        }
        public async Task PopulateList(List<MRestoran> list)
        {
            try
            {
                RestoranList.Clear();
                NajbliziRestoraniList.Clear();
                var request = new GeolocationRequest(GeolocationAccuracy.Lowest);
                var location = await Geolocation.GetLocationAsync(request);
                Location korisnikPozicija = new Location(location.Latitude, location.Longitude);
                foreach (var x in list)
                {
                    RestoranList.Add(x);
                    Location restoran = new Location(x.Latitude ?? 0, x.Longitude ?? 0);

                    var distanca = Location.CalculateDistance(korisnikPozicija, restoran, DistanceUnits.Kilometers);
                    if (distanca < 5)
                    {
                        NajbliziRestoraniList.Add(x);
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }


    }

  
}

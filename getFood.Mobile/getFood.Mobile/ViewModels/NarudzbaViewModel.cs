using getFood.Mobile.Models;
using getFood.Mobile.Views;
using getFood_Model;
using getFood_Model.Requests;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace getFood.Mobile.ViewModels
{
    public class NarudzbaViewModel : BaseViewModel
    {

        private readonly APIService _karticaService = new APIService("Kartica");
        private readonly APIService _kuponiService = new APIService("Kuponi");
        private readonly APIService _narudzbeStavkeService = new APIService("NarudzbaStavke");
        private readonly APIService _narudzbaService = new APIService("Narudzba");
        private readonly APIService _restoranService = new APIService("Restoran");

       
        public NarudzbaViewModel()
        {
            PogledajNarudzbuCommand = new Command(async (object obj) => await Pogledaj(obj));
         
        }
        public ICommand PogledajNarudzbuCommand { get; set; }

        public ObservableCollection<ProduktDetailViewModel> ProduktDetailViewModel { get; set; } = new ObservableCollection<ProduktDetailViewModel>();
        public ObservableCollection<MKartica> karticaList { get; set; } = new ObservableCollection<MKartica>();
        public ObservableCollection<MKuponi> kuponiList { get; set; } = new ObservableCollection<MKuponi>();
        public ObservableCollection<MNarudzba> korisnikNarudzbeList { get; set; } = new ObservableCollection<MNarudzba>();
        public ObservableCollection<MNarudzbaStavke> narudzbaStavkeList { get; set; } = new ObservableCollection<MNarudzbaStavke>();
        public ObservableCollection<MRestoran> restoranList { get; set; } = new ObservableCollection<MRestoran>();
     
        decimal _ukupno = 0;
        public decimal Ukupno
        {
            get { return _ukupno; }
            set { SetProperty(ref _ukupno, value); }
        }

        private MKuponi _selectedKupon;

        public MKuponi SelectedKupon
        {
            get { return _selectedKupon; }
            set { SetProperty(ref _selectedKupon, value);
                if (value != null)
                {
                    Init();
                }
            }
        }

        private MRestoran _selectedRestoran;

        public MRestoran SelectedRestoran
        {
            get { return _selectedRestoran; }
            set
            {
                SetProperty(ref _selectedRestoran, value);
                if (value != null)
                {
                    _ = NarudzbeKorisnikInit();
                }

            }

        }
        private MNarudzba _narudzba;

        public MNarudzba Narudzba
        {
            get { return _narudzba; }
            set { SetProperty(ref _narudzba,value); }
        }

        private double? _popust;

        public double? Popust
        {
            get { return _popust; }
            set { SetProperty(ref _popust,value); }
        }

        private decimal _ukupnaCijena;

        public decimal UkupnaCijena
        {
            get { return _ukupnaCijena; }
            set { SetProperty(ref _ukupnaCijena, value); }
        }
        private decimal _minimalnaNarudzba;

        public decimal MinimalnaNarudzba
        {
            get { return _minimalnaNarudzba; }
            set { SetProperty(ref _minimalnaNarudzba,value); }
        }



        public async void Init()
        {  
            ProduktDetailViewModel.Clear();
            CartService.Ukupno = 0;
            foreach (var item in CartService.Cart.Values)
            {
                ProduktDetailViewModel.Add(item);
                CartService.Ukupno += item.CijenaProizvoda;
               
            }
            if(_selectedKupon != null)
            {
                Ukupno = Math.Round(CartService.Ukupno - (CartService.Ukupno * (_selectedKupon.Popust / 100)),2);

            }
            else
             Ukupno = CartService.Ukupno;
            if(ProduktDetailViewModel.Count > 0)
            {
                var restoranId = ProduktDetailViewModel.Select(i => i.RestoranId).First();
                var restoran = await _restoranService.GetById<MRestoran>(restoranId);
                MinimalnaNarudzba = restoran.MinimalnaNarudzba;
            }
           
        }

        public async Task KarticeInit()
        {
            var kartice = await _karticaService.Get<List<MKartica>>(new KarticaSearchRequest { KorisnikID = Global.prijavljeniKupac.KorisnikId });
            karticaList.Clear();

            foreach (var x in kartice)
            {
                karticaList.Add(x);
            }
        }

        public async Task KuponiInit()
        {
           
            var kuponi = await _kuponiService.Get<List<MKuponi>>(new KuponiSearchRequest { KorisnikId = Global.prijavljeniKupac.KorisnikId, Status = "Neiskorišten"});
            kuponiList.Clear();

            foreach (var y in kuponi)
            {
                kuponiList.Add(y);
            }

        }
       
        public async Task NarudzbeKorisnikInit()
        {
            if (restoranList.Count == 0)
            {
                var status = await _restoranService.Get<IEnumerable<MRestoran>>(null);

                restoranList.Insert(0, new MRestoran { Naziv = "Sve" });

                foreach (var y in status)
                {
                    restoranList.Add(y);
                

                }
            }

            List<MNarudzba> result = null;

            if (SelectedRestoran != null && SelectedRestoran.RestoranId != 0)
            {
                result = await _narudzbaService.Get<List<MNarudzba>>(new NarudzbaSearchRequest { KorisnikID = Global.prijavljeniKupac.KorisnikId, RestoranID = SelectedRestoran.RestoranId });
            }
            else if ( SelectedRestoran == null || SelectedRestoran.RestoranId == 0)
            {
                result = await _narudzbaService.Get<List<MNarudzba>>(new NarudzbaSearchRequest { KorisnikID = Global.prijavljeniKupac.KorisnikId,});

            }

            korisnikNarudzbeList.Clear();

            foreach(var x in result)
            {
                korisnikNarudzbeList.Add(x);
            }
        }

        public async Task NarudzbaStavkeInit()
        {
            var result = await _narudzbeStavkeService.Get<List<MNarudzbaStavke>>(new NarudzbaStavkeSearchRequest { NarudzbaId = Narudzba.NarudzbaId });

            narudzbaStavkeList.Clear();
            foreach(var x in result)
            {
                if(x.Popust!= null)
                {
                    UkupnaCijena += (x.Cijena * x.Kolicina) - (x.Cijena * x.Kolicina * (decimal)x.Popust / 100);
                }
                else
                {
                    UkupnaCijena += (x.Cijena * x.Kolicina);
                }
               
                narudzbaStavkeList.Add(x);

            }


            Popust = result.Select(i => i.Popust).First();
            if (Popust == null)
                Popust = 0.00;
            
       

        }

     
        public async Task Pogledaj(object IdNarudzba)
        {
            var narudzba = await _narudzbaService.GetById<MNarudzba>(IdNarudzba);
            if (narudzba != null)
                await PopupNavigation.PushAsync(new NarudzbaStavkePage(narudzba));
        }
     
    }
}

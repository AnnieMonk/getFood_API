using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace getFood.Mobile.ViewModels
{
    public class ProduktDetailViewModel : BaseViewModel
    {
        private readonly APIService _meniProduktiService = new APIService("MeniProdukti");
     
        public ProduktDetailViewModel()
        {
            InitCommand = new Command(async () => await Init());
            PovecajKolicinuCommand = new Command(() => Povecaj()) ;
          
            SmanjiKolicinuCommand = new Command(() => Smanji());
            NaruciCommand = new Command(async () => await Naruci());

            UkloniCommand = new Command(async() => await Ukloni());

        }
        public ObservableCollection<MProduktiSastojci> SastojciList { get; set; } = new ObservableCollection<MProduktiSastojci>();


        public ICommand InitCommand { get; set; }
        public ICommand PovecajKolicinuCommand { get; set; }
      
        public ICommand SmanjiKolicinuCommand { get; set; }
        public ICommand NaruciCommand { get; set; }
        public ICommand UkloniCommand { get; set; }

        private byte[] _slikaThmb;

        public byte[] SlikaThmb
        {
            get { return _slikaThmb; }
            set { _slikaThmb = value; }
        }


        private int _restoranId;

        public int RestoranId
        {
            get { return _restoranId; }
            set { _restoranId = value; }
        }


        private string _nazivProizvoda;

        public string NazivProizvoda
        {
            get { return _nazivProizvoda; }
            set { _nazivProizvoda = value; }
        }

        private string _opisProizvoda;

        public string OpisProizvoda
        {
            get { return _opisProizvoda; }
            set { _opisProizvoda = value; }
        }

        public decimal _cijenaProizvoda = 0;

        public decimal CijenaProizvoda
        {
            get { return _cijenaProizvoda; }
            set { SetProperty(ref _cijenaProizvoda, value); }
        }


        public decimal? _rating = 0;
        public decimal? Rating
        {
            get { return _rating; }
            set { SetProperty(ref _rating, value); }
        }



        private MMeniProdukti _meniProdukt=null;

        public MMeniProdukti MeniProdukt
        {
            get { return _meniProdukt; }
            set { SetProperty(ref _meniProdukt,value); }
        }

        int _kolicina = 1;
        public int Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }

      
        public async Task Init()
        {
            var refresh = await _meniProduktiService.Get<List<MMeniProdukti>>(new MeniProduktiSearchRequest { ProduktiId = MeniProdukt.ProduktiId});
            MeniProdukt = refresh.FirstOrDefault();
            Rating = MeniProdukt.Rating;

            if (CartService.Cart.ContainsKey(MeniProdukt.ProduktiId))
            {
                foreach (var item in CartService.Cart.Values)
                {
                    if (item.MeniProdukt.ProduktiId == MeniProdukt.ProduktiId)
                    {
                        Kolicina = item.Kolicina;
                        CijenaProizvoda = item.CijenaProizvoda;
                    }
                }
            }
            var list = await _meniProduktiService.Get<List<MMeniProdukti>>(new MeniProduktiSearchRequest { ProduktiId = MeniProdukt.ProduktiId });


            SastojciList.Clear();
            foreach (var x in list)
            {
                foreach (var y in x.sastojciList)
                {
                    SastojciList.Add(y);
                }

            }
        }

      

        public void Povecaj()
        {
            Kolicina += 1;
            CijenaProizvoda = MeniProdukt.Cijena * Kolicina;
            
        }
        public void Smanji()
        {
            if(Kolicina != 1)
            {
                Kolicina -= 1;
                CijenaProizvoda = MeniProdukt.Cijena * Kolicina;
            }
         
        }

      
        private async Task Naruci()
        {

            if (CartService.Cart.ContainsKey(MeniProdukt.ProduktiId))
            {
                foreach (var item in CartService.Cart.Values)
                {
                    
                    if (item.MeniProdukt.ProduktiId == MeniProdukt.ProduktiId)
                    {

                        if (item.Kolicina == Kolicina)
                        {
                            item.Kolicina += 1;
                            item.CijenaProizvoda = MeniProdukt.Cijena * item.Kolicina;
                            CijenaProizvoda = item.CijenaProizvoda;
                            Kolicina = item.Kolicina;
                        }
                        else
                        {

                            //Kolicina += 1;
                            CijenaProizvoda = MeniProdukt.Cijena * Kolicina;
                            item.Kolicina = Kolicina;
                            item.CijenaProizvoda = CijenaProizvoda;

                        }
                       
                        
                       
                    }
                  
                }
            }
            else
            {
                CartService.Cart.Add(MeniProdukt.ProduktiId, this);
               
            }
            await Application.Current.MainPage.DisplayAlert("Uspjeh", "Uspješno ste dodali u korpu!", "OK");

        }

        public async Task Ukloni()
        {
            foreach(var item in CartService.Cart.Values)
            {
                if(item.NazivProizvoda == NazivProizvoda && item.OpisProizvoda == OpisProizvoda)
                {
                    CartService.Cart.Remove(item.MeniProdukt.ProduktiId);
                    break;
                }
            }
          
        }
    }
}

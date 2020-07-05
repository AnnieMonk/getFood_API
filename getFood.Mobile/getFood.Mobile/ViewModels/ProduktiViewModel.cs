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
    public class ProduktiViewModel : BaseViewModel
    {
        private readonly APIService _meniProduktiService = new APIService("MeniProdukti");
        private readonly APIService _meniService = new APIService("Meni");
        private readonly APIService _kategorijeService = new APIService("Kategorija");
        private readonly APIService _favoritiService = new APIService("Favoriti");
  
        private readonly APIService _restoranService = new APIService("Restoran");
       
        public ProduktiViewModel()
        {
            InitCommand = new Command(async () => await Init());
  

        }
        public ObservableCollection<MMeniProdukti> ProizvodiList { get; set; } = new ObservableCollection<MMeniProdukti>();
        public ObservableCollection<MKategorija> KategorijaList { get; set; } = new ObservableCollection<MKategorija>();
        public ObservableCollection<MMeni> MeniList { get; set; } = new ObservableCollection<MMeni>();
       
      
      
        public ICommand InitCommand { get; set; }
   

        MKategorija _selectedKategorijeProizvoda = null;
        MMeni _selectedMeni = null;

        public MKategorija SelectedKategorija
        {
            get { return _selectedKategorijeProizvoda; }
            set { SetProperty(ref _selectedKategorijeProizvoda, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            
            }
        }

        public MMeni SelectedMeni
        {
            get { return _selectedMeni; }
            set
            {
                SetProperty(ref _selectedMeni, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }
    

        private MRestoran _Restoran = null;

        public MRestoran Restoran
        {
            get { return _Restoran; }
            set { SetProperty(ref _Restoran, value); }
        }



        public async Task Init()
        {
            Restoran = await _restoranService.GetById<MRestoran>(Restoran.RestoranId);
              //populate pickers
                if (KategorijaList.Count == 0)
                {
                    var kategorije = await _kategorijeService.Get<IEnumerable<MKategorija>>(null);

                    KategorijaList.Insert(0, new MKategorija { Naziv = "Sve" });

                    foreach (var y in kategorije)
                    {
                        KategorijaList.Add(y);
                    }
                }

                if (MeniList.Count == 0)
                {
                    var meni = await _meniService.Get<IEnumerable<MMeni>>(new MeniSearchRequest { RestoranId = Restoran.RestoranId });

                    MeniList.Insert(0, new MMeni { Naziv = "Sve" });

                    foreach (var y in meni)
                    {
                        MeniList.Add(y);
                    }
                }

                List<MMeniProdukti> listaProdukti = null;
              
                MeniProduktiSearchRequest request = new MeniProduktiSearchRequest();

                if (SelectedKategorija != null && SelectedMeni != null)
                {
                    if (SelectedKategorija.KategorijaId == 0 && SelectedMeni.MeniId == 0)
                    {
                        request.RestoranId = Restoran.RestoranId;
                        listaProdukti = await _meniProduktiService.Get<List<MMeniProdukti>>(request);
                      
                        ProizvodiList.Clear();
                        foreach (var x in listaProdukti)
                        {

                            ProizvodiList.Add(x);

                        }

                    }
                    else
                    {
                        if (SelectedKategorija.KategorijaId == 0)
                        {
                            request.KategorijaId = null;
                        }
                        else
                        {
                            request.KategorijaId = SelectedKategorija.KategorijaId;
                        }
                        if (SelectedMeni.MeniId == 0)
                        {
                            request.MeniId = null;
                        }
                        else
                        {
                            request.MeniId = SelectedMeni.MeniId;
                        }

                        request.RestoranId = Restoran.RestoranId;
                        listaProdukti = await _meniProduktiService.Get<List<MMeniProdukti>>(request);
                        
                        ProizvodiList.Clear();
                        foreach (var x in listaProdukti)
                        {

                            ProizvodiList.Add(x);

                        }

                    }
                }
            }

        public async Task DodajUFavorite()
        {
            var favoriti = await _favoritiService.Get<List<MFavoriti>>(new FavoritiSearchRequest { KorisnikId = Global.prijavljeniKupac.KorisnikId });

            if (!favoriti.Select(i=>i.RestoranId).Contains(Restoran.RestoranId))
            {
                await _favoritiService.Insert<MFavoriti>(new FavoritiUpsertRequest { KorisnikId = Global.prijavljeniKupac.KorisnikId, RestoranId = Restoran.RestoranId });
                await Application.Current.MainPage.DisplayAlert("Uspjeh", "Uspješno ste dodali restoran " + Restoran.Naziv + " u favorite!", "Uredu");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Upozorenje", "Restoran " + Restoran.Naziv + " ste već dodali u listu favorita", "Uredu");
            }
        
           
        }

       
    }
}

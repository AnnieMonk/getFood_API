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
    public class FavoritiViewModel : BaseViewModel
    {
        private readonly APIService _favoritiService = new APIService("Favoriti");
        private readonly APIService _restoranService = new APIService("Restoran");
        private readonly APIService _kuhinjaService = new APIService("Kuhinja");
        public FavoritiViewModel()
        {
            InitCommand = new Command(async () => await Init());
            UkloniCommand = new Command(async (object id) => await Ukloni(id));

        }
        public ObservableCollection<MRestoran> FavoritiList { get; set; } = new ObservableCollection<MRestoran>();
        public ObservableCollection<MKuhinja> KuhinjaList { get; set; } = new ObservableCollection<MKuhinja>();

        public ICommand InitCommand { get; set; }
        public ICommand UkloniCommand { get; set; }
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

            List<MFavoriti> favoritiList = null;
            if (SelectedKuhinja != null && SelectedKuhinja.KuhinjaId != 0)
            {
                favoritiList = await _favoritiService.Get<List<MFavoriti>>(new FavoritiSearchRequest { KorisnikId = Global.prijavljeniKupac.KorisnikId, KuhinjaId=SelectedKuhinja.KuhinjaId });
            }
            else if(SelectedKuhinja == null || SelectedKuhinja.KuhinjaId == 0)
            {
                favoritiList = await _favoritiService.Get<List<MFavoriti>>(new FavoritiSearchRequest { KorisnikId = Global.prijavljeniKupac.KorisnikId });

            }

            var matchingRestorani = await _restoranService.Get<List<MRestoran>>(null);

            FavoritiList.Clear();
            foreach(var x in matchingRestorani)
            {
                if (favoritiList.Select(i => i.RestoranId).Contains(x.RestoranId))
                {
                    FavoritiList.Add(x);
                }
            }
        }
        public async Task Ukloni(object id)
        {
            var restoranId = await _restoranService.GetById<MRestoran>((int)id);
            var favoriti = await _favoritiService.Get<List<MFavoriti>>(new FavoritiSearchRequest { RestoranId = (int)id, KorisnikId = Global.prijavljeniKupac.KorisnikId });

            int favoritZaBrisanje = favoriti.Select(i => i.FavoritId).FirstOrDefault();
            await _favoritiService.Delete(favoritZaBrisanje);

            await Init();
         
        }
    }
}

using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace getFood.Mobile.ViewModels
{
    public class ProfilViewModel : BaseViewModel
    {
        private readonly APIService _korisnikService = new APIService("Korisnik");
        private readonly APIService _karticaService = new APIService("Kartica");

        public ProfilViewModel()
        {
            InitCommand = new Command(async () => await Init());
            UkloniCommand = new Command(async () => await Ukloni());
           
        }
        public ICommand InitCommand { get; set; }
        public ICommand UkloniCommand { get; set; }

        public ObservableCollection<MKartica> karticaList { get; set; } = new ObservableCollection<MKartica>();

        private string _fullName = null;

        public string FullName
        {
            get { return _fullName; }
            set { SetProperty(ref _fullName, value); }
        }

        private string _username = null;

        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        private string _password = null;

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value);
               
            }
        }
        private string _email = null;

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value);
               
            }
        }
        private string _adresa = null;

        
        public string Adresa
        {
            get { return _adresa; }
            set { SetProperty(ref _adresa, value);
               
            }
        }
        private string _telefon = null;

        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value);
                
                    
            }
        }


        public async Task Init()
        {
            var result = await _korisnikService.GetById<MKorisnik>(Global.prijavljeniKupac.KorisnikId);
          
           
            FullName = result.FullName;
            Username = result.KorisnickoIme;
            Password = "samoParTackica";
            Adresa = result.Adresa;
            Telefon = result.Telefon;
            Email = result.Email;
            

            var kartice = await _karticaService.Get<List<MKartica>>(new KarticaSearchRequest { KorisnikID = Global.prijavljeniKupac.KorisnikId });
            karticaList.Clear();
            if(kartice != null)
            {
                foreach (var x in kartice)
                {
                    karticaList.Add(x);
                }
            }
          

        }

        public async Task Ukloni(MKartica item=null)
        {
            await _karticaService.Delete(item.KarticaId);
        }
       
    }
}

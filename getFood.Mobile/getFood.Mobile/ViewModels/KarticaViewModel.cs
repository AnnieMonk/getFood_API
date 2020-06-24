using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace getFood.Mobile.ViewModels
{
    public class KarticaViewModel : BaseViewModel
    {
        private readonly APIService _korisnikService = new APIService("Korisnik");
        private readonly APIService _karticaService = new APIService("Kartica");
        public KarticaViewModel()
        {
            DodajKarticuCommand = new Command(async () => await DodajKarticu());
        }
        public ICommand DodajKarticuCommand { get; set; }

        private long _brojKartice = 0;

        public long BrojKartice
        {
            get { return _brojKartice; }
            set { SetProperty(ref _brojKartice ,value); }
        }
        private int _mjesecIsteka = 0;

        public int MjesecIsteka
        {
            get { return _mjesecIsteka; }
            set { SetProperty(ref _mjesecIsteka ,value); }
        }

        private int _godinaIsteka = 0;

        public int Godina
        {
            get { return _godinaIsteka; }
            set { SetProperty(ref _godinaIsteka, value); }
        }

        private int _securityCode = 0;

        public int SecurityCode
        {
            get { return _securityCode; }
            set { _securityCode = value; }
        }


        public async Task DodajKarticu()
        {
            var postojiLi = await _karticaService.Get<List<MKartica>>(new KarticaSearchRequest { BrojKartice = BrojKartice });
            if(postojiLi.Count > 0)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Kartica već postoji", "Uredu");
            }
            else
            {
                KarticaUpsertRequest request = new KarticaUpsertRequest
                {
                    KorisnikId = Global.prijavljeniKupac.KorisnikId,
                    BrojKartice = BrojKartice,
                    ExpMonth = MjesecIsteka,
                    ExpYear = Godina,
                    SecurityCode = SecurityCode
                };

                await _karticaService.Insert<MKartica>(request);

                await Application.Current.MainPage.DisplayAlert("Uspjeh", "Kartica dodana", "Uredu");
            }
          
        }

    }
}

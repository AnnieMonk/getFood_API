using Flurl.Http;
using getFood.Mobile.Views;
using getFood_Model;
using getFood_Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace getFood.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnik"); 
        const string emailRegex = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            RegisterCommand = new Command(async () => await Register());
        }
        string _username = string.Empty;

        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        string _passwordConfirmation = string.Empty;
        public string PasswordConfirmation
        {
            get { return _passwordConfirmation; }
            set { SetProperty(ref _passwordConfirmation, value); }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }

        private string _error1 = null;

        public string errorLabelIme
        {
            get { return _error1; }
            set { SetProperty(ref _error1,value); }
        }

        private string _error2 = null;

        public string errorLabelPrezime
        {
            get { return _error2; }
            set { SetProperty(ref _error2, value); }
        }

        private string _error3 = null;

        public string errorLabelUsername
        {
            get { return _error3; }
            set { SetProperty(ref _error3, value); }
        }

        private string _error4 = null;

        public string errorLabelEmail
        {
            get { return _error4; }
            set { SetProperty(ref _error4, value); }
        }

        private string _error5 = null;

        public string errorLabelPassword
        {
            get { return _error5; }
            set { SetProperty(ref _error5, value); }
        }

        private string _error6 = null;

        public string errorLabelConfirm
        {
            get { return _error6; }
            set { SetProperty(ref _error6, value); }
        }




        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        public async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
               await _service.Get<dynamic>(null);
                Application.Current.MainPage = new MainPage();

                var pretraga = await _service.Get<List<MKorisnik>>(new KorisnikSearchRequest { KorisnickoIme = Username });
               
                Global.prijavljeniKupac = pretraga.FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
        }
      
        public async Task ValidirajPolja()
        {
            errorLabelIme = null;
            if (string.IsNullOrEmpty(Ime))
            {
                errorLabelIme = "Polje je mandatorno!";
            }
            errorLabelPrezime = null;
            if (string.IsNullOrEmpty(Prezime))
            {
                errorLabelPrezime = "Polje je mandatorno";
            }
            errorLabelUsername = null;
            if (string.IsNullOrEmpty(Username))
            {
                errorLabelUsername = "Polje je mandatorno!";
            }
            errorLabelEmail = null;
            if (string.IsNullOrEmpty(Email))
            {
                errorLabelEmail = "Polje je mandatorno!";
            }
            else
            {
                errorLabelEmail = null;
                if (!(Regex.IsMatch(Email, emailRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))))
                {
                    errorLabelEmail = "Email nije u tačnom formatu example@gmail.com";
                }
            }

            errorLabelPassword = null;
            if (string.IsNullOrEmpty(Password))
            {
                errorLabelPassword = "Polje je mandatorno";
            }
            else
            {
                errorLabelPassword = null;
                if (Password.Length < 6)
                {
                   
                    errorLabelPassword = "Password mora imati bar 6 karaktera!";
                }
            }

            errorLabelConfirm = null;
            if (string.IsNullOrEmpty(PasswordConfirmation))
            {
              
                errorLabelConfirm = "Polje je mandatorno!";
            }
            else
            {
                errorLabelPassword = null;
                errorLabelConfirm = null;
                if (Password != PasswordConfirmation)
                {
                    
                    errorLabelPassword = "Passwordi se ne slažu!";
                    errorLabelConfirm = "Passwordi se ne slažu!";
                }
            }
           
            
        }
        public async Task Register()
        {
           await ValidirajPolja();

            if(errorLabelIme == null && errorLabelPrezime == null && errorLabelUsername == null && errorLabelEmail == null && errorLabelPassword == null && errorLabelConfirm == null)
            {
                IsBusy = true;

                try
                {
                    List<int> ulogazakupca = new List<int>();
                    ulogazakupca.Add(3);
                    KorisnikUpsertRequest request = new KorisnikUpsertRequest
                    {
                        Ime = _ime,
                        Prezime = _prezime,
                        KorisnickoIme = _username,
                        Password = _password,
                        PasswordConfirmation = _passwordConfirmation,
                        Email = _email,
                        Telefon = "+387xx/xxx-xxx",
                        Adresa = "Nepoznato",
                        Uloge = ulogazakupca

                    };


                    await _service.Insert<dynamic>(request);

                    await Application.Current.MainPage.DisplayAlert("Uspjeh", "Uspješno ste se registrovali", "OK");
                    Application.Current.MainPage = new LoginPage();
                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");
                }



            }



        }

        private async Task<Boolean> ValidateFields()
        { 
            if(string.IsNullOrEmpty(Username) ||
                string.IsNullOrEmpty(Password) ||
                string.IsNullOrEmpty(Ime) ||
                string.IsNullOrEmpty(Prezime) ||
                string.IsNullOrEmpty(Email))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Sva polja su mandatorna", "OK");
                return false;
            }
            if (!(Regex.IsMatch(Email, emailRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Format email-a nije ispravan", "OK");
                return false;
            }
            if (!String.IsNullOrEmpty(Password) && !Password.Equals(PasswordConfirmation))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Lozinke se ne slažu", "OK");
                return false;
            }
            if (!String.IsNullOrEmpty(Password) && Password.Length < 6)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Password mora imati bar 6 znakova", "OK");
                return false;
            }

            return true;
        }
    }
}

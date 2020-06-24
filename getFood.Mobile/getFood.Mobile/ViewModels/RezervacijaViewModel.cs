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
    public class RezervacijaViewModel : BaseViewModel
    {

        private readonly APIService _rezervacijeService = new APIService("Rezervacije");
        private readonly APIService _restoranService = new APIService("Restoran");
        private readonly APIService _statusService = new APIService("Status");

        public RezervacijaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<MRezervacije> RezervacijeList { get; set; } = new ObservableCollection<MRezervacije>();
        public ObservableCollection<MRestoran> RestoranList { get; set; } = new ObservableCollection<MRestoran>();
        public ObservableCollection<MStatus> StatusList { get; set; } = new ObservableCollection<MStatus>();

        public ICommand InitCommand { get; set; }
        private MRestoran _restoran;

        public MRestoran Restoran
        {
            get { return _restoran; }
            set { _restoran = value; }
        }

        public MRestoran _selectedRestoran = null;
        public MRestoran SelectedRestoran
        {
            get { return _selectedRestoran; }
            set
            {
                SetProperty(ref _selectedRestoran, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public MStatus _selectedStatus = null;
        public MStatus SelectedStatus
        {
            get { return _selectedStatus; }
            set
            {
                SetProperty(ref _selectedStatus, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }
        public async Task Init()
        {
            if (RestoranList.Count == 0)
            {
                var restoran = await _restoranService.Get<IEnumerable<MRestoran>>(null);

                RestoranList.Insert(0, new MRestoran { Naziv = "Sve" });

                foreach (var y in restoran)
                {
                    RestoranList.Add(y);
                }
            }

            if (StatusList.Count == 0)
            {
                var status = await _statusService.Get<IEnumerable<MStatus>>(null);

                StatusList.Insert(0, new MStatus { Naziv = "Sve" });

                foreach (var y in status)
                {
                    if(y.Naziv == "Nepoznato" || y.Naziv=="Otkazana" || y.Naziv == "Potvrđena")
                    {
                        StatusList.Add(y);
                    }
                  
                }
            }

            List<MRezervacije> rezervacije = null;
            RezervacijeSearchRequest request = new RezervacijeSearchRequest();
            request.KorisnikId = Global.prijavljeniKupac.KorisnikId;
            if (SelectedRestoran != null && SelectedStatus != null)
            {

                if(SelectedRestoran.RestoranId == 0 && SelectedStatus.StatusId == 0)
                {
                    
                    rezervacije = await _rezervacijeService.Get<List<MRezervacije>>(request);

                }
                else
                {
                    if (SelectedRestoran.RestoranId == 0)
                    {
                        request.RestoranId = null;
                    }
                    else
                    {
                        request.RestoranId = SelectedRestoran.RestoranId;
                    }

                    if (SelectedStatus.StatusId == 0)
                    {
                        request.StatusId = null;
                    }
                    else
                    {
                        request.StatusId = SelectedStatus.StatusId;
                    }
                    rezervacije = await _rezervacijeService.Get<List<MRezervacije>>(request);

                }


               
            }

            else
            {

                rezervacije = await _rezervacijeService.Get<List<MRezervacije>>(request);

            }

            RezervacijeList.Clear();

            foreach (var x in rezervacije)
            {
                RezervacijeList.Add(x);
            }

        }
    }
}

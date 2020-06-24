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
    public class KuponiViewModel : BaseViewModel
    {
      
        private readonly APIService _kuponiService = new APIService("Kuponi");
        private readonly APIService _statusService = new APIService("Status");

        public KuponiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<MKuponi> kuponiList { get; set; } = new ObservableCollection<MKuponi>();
        public ObservableCollection<MStatus> statusList { get; set; } = new ObservableCollection<MStatus>();
        public ICommand InitCommand { get; set; }
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
            if (statusList.Count == 0)
            {
                var status = await _statusService.Get<IEnumerable<MStatus>>(null);

                statusList.Insert(0, new MStatus { Naziv = "Sve" });

                foreach (var y in status)
                {
                    if(y.Naziv=="Iskorišten" || y.Naziv == "Neiskorišten")
                    {
                        statusList.Add(y);
                    }
                   
                }
            }

            List<MKuponi> result = null;
            if(SelectedStatus != null && SelectedStatus.StatusId != 0)
            {
               result = await _kuponiService.Get<List<MKuponi>>(new KuponiSearchRequest { KorisnikId = Global.prijavljeniKupac.KorisnikId, Status = SelectedStatus.Naziv });
            }
            else if(SelectedStatus == null || SelectedStatus.StatusId == 0)
            {
               result = await _kuponiService.Get<List<MKuponi>>(new KuponiSearchRequest { KorisnikId = Global.prijavljeniKupac.KorisnikId});
            }
            

            kuponiList.Clear();
            foreach(var x in result)
            {
                kuponiList.Add(x);
            }
        
        
        }
   }
}

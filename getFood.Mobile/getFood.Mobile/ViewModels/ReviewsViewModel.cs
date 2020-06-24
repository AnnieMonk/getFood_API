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
    public class ReviewsViewModel : BaseViewModel
    {
        private readonly APIService _reviewsService = new APIService("Review");
       

        public ReviewsViewModel() {

            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<MReview> ReviewsList { get; set; } = new ObservableCollection<MReview>();

        public ICommand InitCommand { get; set; }

        private MRestoran _restoran;

        public MRestoran Restoran
        {
            get { return _restoran; }
            set { _restoran = value; }
        }

        private MMeniProdukti _produkt;

        public MMeniProdukti Produkt
        {
            get { return _produkt; }
            set { _produkt = value; }
        }

       
        public async Task Init()
        {
            List<MReview> restoranReviews = null;
            if(Restoran != null && Produkt == null)
            {
                restoranReviews = await _reviewsService.Get<List<MReview>>(new ReviewSearchRequest { RestoranId = Restoran.RestoranId });
               
            }
            else if(Produkt != null && Restoran == null)
            {
                restoranReviews = await _reviewsService.Get<List<MReview>>(new ReviewSearchRequest { ProduktId=Produkt.ProduktiId });
            }

            ReviewsList.Clear();

            foreach (var x in restoranReviews)
            {
                ReviewsList.Add(x);
            }

        }

     
    }
}

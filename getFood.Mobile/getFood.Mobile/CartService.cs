using getFood.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace getFood.Mobile
{
    public static class CartService
    {
        public static Dictionary<int, ProduktDetailViewModel> Cart { get; set; } = new Dictionary<int, ProduktDetailViewModel>();

        public static decimal Ukupno { get; set; }

    }
}

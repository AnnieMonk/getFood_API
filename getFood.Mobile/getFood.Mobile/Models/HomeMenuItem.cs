using System;
using System.Collections.Generic;
using System.Text;

namespace getFood.Mobile.Models
{
    public enum MenuItemType
    {
        Profil,
        Restorani,
        Korpa
       
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
        public string ImageSource { get; internal set; }
    }
}

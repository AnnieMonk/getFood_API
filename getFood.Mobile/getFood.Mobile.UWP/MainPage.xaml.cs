using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace getFood.Mobile.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new getFood.Mobile.App());
            Xamarin.FormsMaps.Init("LumySnq0V19xktBKiPB7~6mMd8jehXAKQQwEEBgulVw~ApNDgAjb5lbr_AjLTqabVCm_mW9SVzAbOwNMxlEcZeGAwJEf3cvRB71yqPv1qzdj");
        }
    }
}

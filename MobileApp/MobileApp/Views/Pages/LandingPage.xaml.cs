using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : Shell
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Navigation.PopAsync();
            base.OnAppearing();
        }
    }
}
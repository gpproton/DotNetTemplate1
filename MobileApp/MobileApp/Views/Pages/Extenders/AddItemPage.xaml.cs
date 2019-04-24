using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views.Pages.Extenders
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddItemPage : ContentPage
    {
        public AddItemPage()
        {
            InitializeComponent();
        }

        private async void AddBut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void AddItemCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
            //await Navigation.PopToRootAsync();
        }

        private void AddItemSave_Clicked(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Views.Pages;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            bool LgnUsername = string.IsNullOrEmpty(LoginUsername.Text);
            bool LgnPassword = string.IsNullOrEmpty(LoginPassword.Text);

            if (LgnPassword || LgnUsername)
            {
                await DisplayAlert("Sign in Error", "Sign failed check Username or Password", "Ok");
            }
            else
            {
                Application.Current.MainPage = (new LandingPage ());
            }
        }
    }
}
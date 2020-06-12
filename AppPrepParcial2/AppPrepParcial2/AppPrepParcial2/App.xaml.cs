using System;
using AppPrepParcial2.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPrepParcial2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CountryPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

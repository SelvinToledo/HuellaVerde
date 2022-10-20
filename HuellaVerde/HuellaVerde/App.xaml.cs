using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HuellaVerde.Views;

namespace HuellaVerde
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Resultados();
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

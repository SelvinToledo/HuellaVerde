using HuellaVerde.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HuellaVerde.ViewModel
{
    public class VMPantalla2:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONSTRUCTOR

        public VMPantalla2(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Comenzar()
        {
            await Navigation.PushAsync(new Transporte());
        }
        public async Task CalculadoraBasura()
        {
            await Navigation.PushAsync(new CalculaBasura());
        }

        public async Task Info()
        {
            await DisplayAlert("Información", "Los datos personales recabados serán utilizados " +
                "para enviar algunas acciones que puede realizar para " +
                "disminuir su huella de carbono", "Ok");
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand btnComenzarcommand => new Command(async () => await Comenzar());
        public ICommand btnInfocommand => new Command(async () => await Info());
        public ICommand CalculadoraBasuracommand => new Command(async () => await CalculadoraBasura());
        #endregion
    }
}

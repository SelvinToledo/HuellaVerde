using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HuellaVerde.ViewModel
{
    public class VMCalculaBasura:BaseViewModel
    {
        #region VARIABLES
        int _Peso;
        int _NPersonas;
        #endregion
        #region CONSTRUCTOR
        public VMCalculaBasura(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public int Peso
        {
            get { return _Peso; }
            set { SetValue(ref _Peso, value); }
        }
        public int NPersonas
        {
            get { return _NPersonas; }
            set { SetValue(ref _NPersonas, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Calculadora()
        {

            int resultado;
            if(_NPersonas == 0 && _Peso == 0)
            {
                await DisplayAlert("Atención","Por favor ingrese valores distintos de cero","Ok");
            }
            else
            {
                resultado = _NPersonas * _Peso / 365;
                await DisplayAlert("Resultados", resultado.ToString(), "Ok");
                Peso = 0;
                NPersonas = 0;
            }
            
        }
        public async Task Regresar()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Calculadoracommand => new Command(async () => await Calculadora());
        public ICommand Regresarcommand => new Command(async () => await Regresar());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}

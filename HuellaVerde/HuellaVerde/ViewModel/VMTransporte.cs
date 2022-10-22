using HuellaVerde.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HuellaVerde.ViewModel
{
    public class VMTransporte:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONSTRUCTOR
        public VMTransporte(INavigation navigation)
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
        public async Task btnContinuar()
        {
            await Navigation.PushAsync(new Alimentos());
        }
        public async Task btnRegresar()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand btnContinuarcommand => new Command(async () => await btnContinuar());
        public ICommand btnRegresarcommand => new Command(async () => await btnRegresar());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}

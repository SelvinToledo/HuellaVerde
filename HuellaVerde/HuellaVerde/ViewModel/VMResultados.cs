using HuellaVerde.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HuellaVerde.ViewModel
{
    public class VMResultados:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        int _Contadorglobal = 0;
        #endregion
        #region CONSTRUCTOR
        public VMResultados(INavigation navigation,int Conta)
        {
            Navigation = navigation;
            _Contadorglobal = Conta;
            Console.WriteLine(_Contadorglobal);
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
        public async Task btnRegresar()
        {
            await Navigation.PopAsync();
        }

        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand btnRegresarcommand => new Command(async () => await btnRegresar());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}

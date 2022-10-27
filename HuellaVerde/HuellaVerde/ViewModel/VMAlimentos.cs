using HuellaVerde.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using HuellaVerde.ViewModel;

namespace HuellaVerde.ViewModel
{
    public class VMAlimentos:BaseViewModel
    {
        VMTransporte T;
        

        #region VARIABLES
        string _Texto;
        int ContadorGeneralA = 0;
        #endregion
        #region CONSTRUCTOR
        public VMAlimentos(INavigation navigation)
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
            AsignaAlimentos(T);//Anda mal esto
            await Navigation.PushAsync(new Hogar());
        }
        public async Task btnRegresar()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        public void AsignaAlimentos(VMTransporte P)
        {
            ContadorGeneralA = P.ContadorGlobal;
            Console.WriteLine(ContadorGeneralA);
        }
        #endregion
        #region COMANDOS
        public ICommand btnContinuarcommand => new Command(async () => await btnContinuar());
        public ICommand btnRegresarcommand => new Command(async () => await btnRegresar());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}

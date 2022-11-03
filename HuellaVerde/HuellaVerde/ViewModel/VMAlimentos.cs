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
        
        

        #region VARIABLES
        string _Texto;
        int _ContadorGlobal = 0;
        string _txtR1;
        string _txtR2;
        #endregion
        #region CONSTRUCTOR
        public VMAlimentos(INavigation navigation, int Conta)
        {
            Navigation = navigation;
            _ContadorGlobal = Conta;
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }

        public string txtR1
        {
            get { return _txtR1; }
            set { SetValue(ref _txtR1, value); }
        }
        public int ContadorGlobal
        {
            get { return _ContadorGlobal; }
            set { SetValue(ref _ContadorGlobal, value); }
        }
        public string txtR2
        {
            get { return _txtR2; }
            set { SetValue(ref _txtR2, value); }
        }

        public string SeleccionR1
        {
            get { return _txtR1; }
            set
            {
                SetProperty(ref _txtR1, value);
                txtR1 = _txtR1;
            }
        }
        public string SeleccionR2
        {
            get { return _txtR2; }
            set
            {
                SetProperty(ref _txtR2, value);
                txtR2 = _txtR2;
            }
        }


        #endregion
        #region PROCESOS
        public async Task btnContinuar()
        {
            AsignaAlimentos();
            await Navigation.PushAsync(new Hogar(_ContadorGlobal));
        }
        public async Task btnRegresar()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        public void AsignaAlimentos()
        {
            switch (SeleccionR1)
            {
                case "Pollo":
                    ContadorGlobal = _ContadorGlobal + 1;
                    break;

                case "Res":
                    ContadorGlobal = _ContadorGlobal + 3;
                    break;
                case "Pescado":
                    ContadorGlobal = _ContadorGlobal + 1;
                    break;
                case "Cerdo":
                    ContadorGlobal = _ContadorGlobal + 2;
                    break;
                case "No consumo carne":
                    ContadorGlobal = _ContadorGlobal - 2;
                    break;
            }

            switch (SeleccionR2)
            {
                case "Tengo un huerto":
                    ContadorGlobal = _ContadorGlobal - 2;
                    break;

                case "Voy al supermercado":
                    ContadorGlobal = _ContadorGlobal + 2;
                    break;
                case "Consumo en mercados locales":
                    ContadorGlobal = _ContadorGlobal + 1;
                    break;
            }

        }
        #endregion
        #region COMANDOS
        public ICommand btnContinuarcommand => new Command(async () => await btnContinuar());
        public ICommand btnRegresarcommand => new Command(async () => await btnRegresar());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}

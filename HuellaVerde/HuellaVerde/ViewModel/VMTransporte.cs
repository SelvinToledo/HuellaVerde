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
        string _txt1;
        string _txt2;
        string _txt3;
        int _ContadorGlobal = 0;
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
        public string txt1
        {
            get { return _txt1; }
            set { SetValue(ref _txt1, value); }
        }

        public string txt2
        {
            get { return _txt2; }
            set { SetValue(ref _txt2, value); }
        }
        public string txt3
        {
            get { return _txt3; }
            set { SetValue(ref _txt3, value); }
        }

        public int ContadorGlobal
        {
            get { return _ContadorGlobal; }
            set { SetValue(ref _ContadorGlobal, value); }
        }

        public string SeleccionR1
        {
            get { return _txt1; }
            set
            {
                SetProperty(ref _txt1, value);
                txt1 = _txt1;
            }
        }

        public string SeleccionR2
        {
            get { return _txt2; }
            set
            {
                SetProperty(ref _txt2, value);
                txt2 = _txt2;
            }
        }

        public string SeleccionR3
        {
            get { return _txt3; }
            set
            {
                SetProperty(ref _txt3, value);
                txt3 = _txt3;
            }
        }

        #endregion
        #region PROCESOS
        public async Task btnContinuar()
        {
            Asigna();
            await Navigation.PushAsync(new Alimentos());
        }
        public async Task btnRegresar()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }

        public void Asigna()
        {
            switch (SeleccionR1)
            {
                case "Tengo 1 vehiculo motorizado":
                    ContadorGlobal = _ContadorGlobal + 2;
                    break;

                case "1+ vehiculos motorizados":
                    ContadorGlobal = _ContadorGlobal + 3;
                    break;
                case "Camino":
                    
                    break;
                case "Utilizo bicicleta":
                    
                    break;
                case "Utilizo transporte público":
                    ContadorGlobal = _ContadorGlobal + 1;
                    break;
            }

            switch (SeleccionR2)
            {
                case "30 min - 2 horas":
                    ContadorGlobal = _ContadorGlobal + 1;
                    break;

                case "2 horas - 3 horas":
                    ContadorGlobal = _ContadorGlobal + 2;
                    break;
                case "Mas de 3 horas":
                    ContadorGlobal = _ContadorGlobal + 3;
                    break;
            }

            switch (SeleccionR3)
            {
                case "Mucho":
                    ContadorGlobal = _ContadorGlobal + 1;
                    break;

                case "A menudo":
                    ContadorGlobal = _ContadorGlobal + 2;
                    break;
                case "Poco":
                    ContadorGlobal = _ContadorGlobal + 3;
                    break;
                case "Nunca":
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

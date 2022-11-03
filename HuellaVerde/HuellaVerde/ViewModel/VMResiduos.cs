using HuellaVerde.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HuellaVerde.ViewModel
{
    public class VMResiduos:BaseViewModel
    {
        
        #region VARIABLES
        string _txtR1;
        string _txtR2;
        string _txtR3;
        string _txtR4;
        int _ContadorGlobal = 0;
        #endregion
        #region CONSTRUCTOR
        public VMResiduos(INavigation navigation, int Conta)
        {
            Navigation = navigation;
            _ContadorGlobal = Conta;
            Console.WriteLine(_ContadorGlobal);
        }
        #endregion
        #region OBJETOS
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
        
        public string txtR3
        {
            get { return _txtR3; }
            set { SetValue(ref _txtR3, value); }
        }
        
        public string txtR4
        {
            get { return _txtR4; }
            set { SetValue(ref _txtR4, value); }
        }

        public string SeleccionR1
        {
            get { return _txtR1;}
            set
            {
                SetProperty(ref _txtR1, value);
                txtR1 = _txtR1;
            }
        }
        public string SeleccionR2
        {
            get { return _txtR2;}
            set
            {
                SetProperty(ref _txtR2, value);
                txtR2 = _txtR2;
            }
        }
        public string SeleccionR3
        {
            get { return _txtR3;}
            set
            {
                SetProperty(ref _txtR3, value);
                txtR3 = _txtR3;
            }
        }
        public string SeleccionR4
        {
            get { return _txtR4;}
            set
            {
                SetProperty(ref _txtR4, value);
                txtR4 = _txtR4;
            }
        }

        #endregion
        #region PROCESOS
        public async Task btnContinuar()
        {
            Asignacion();
            if(_ContadorGlobal<=10)
            {
                await Navigation.PushAsync(new Buenosresultados());
            }
            else
            {
                await Navigation.PushAsync(new Resultados(_ContadorGlobal));
            }
        }
        public async Task btnRegresar()
        {
            await Navigation.PopAsync();
        }
        public void Asignacion()
        {

            switch (SeleccionR1)
            {
                case "Utilizo mucho":
                    ContadorGlobal = _ContadorGlobal + 3;
                    break;

                case "Utilizo a menudo":
                    ContadorGlobal = _ContadorGlobal + 2;
                    break;
                case "Utilizo muy poco":
                    ContadorGlobal = _ContadorGlobal + 1;
                    break;
                case "No utilizo":
                    break;
            }

            switch (SeleccionR2)
            {
                case "1 bolsa grande de basura":
                    ContadorGlobal = _ContadorGlobal + 1;
                    break;

                case "1 bote grande de basura":
                    ContadorGlobal = _ContadorGlobal + 2;
                    break;
                case "Mas de un bote grande de basura":
                    ContadorGlobal = _ContadorGlobal +3;
                    break;
                case "No utilizo":
                    break;
            }

            switch (SeleccionR3)
            {
                case "Realizo muy frecuentemente":
                    ContadorGlobal = _ContadorGlobal - 1;
                    break;

                case "Realizo a menudo":
                    ContadorGlobal = _ContadorGlobal + 0;
                    break;
                case "Realizo muy poco":
                    ContadorGlobal = _ContadorGlobal + 1;
                    break;
                case "No reciclo":
                    ContadorGlobal = _ContadorGlobal + 2;
                    break;
            }

        }
        #endregion
        #region COMANDOS
        public ICommand btnContinuarcommand => new Command(async () => await btnContinuar());
        public ICommand btnRegresarcommand => new Command(async () => await btnRegresar());
        public ICommand calculo => new Command(Asignacion);
        #endregion
    }

}

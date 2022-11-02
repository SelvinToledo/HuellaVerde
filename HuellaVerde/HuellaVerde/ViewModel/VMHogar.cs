using System;
using System.Collections.Generic;
using System.Text;
using HuellaVerde.Views;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HuellaVerde.ViewModel
{
    public class VMHogar:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        string _txtR1;
        string _txtR2;
        string _txtR3;
        string _txtR4;
        int _ContadorGlobal = 0;
        #endregion
        #region CONSTRUCTOR

        public VMHogar(INavigation navigation, int Conta)
        {
            Navigation = navigation;
            _ContadorGlobal = Conta;
            Console.WriteLine(_ContadorGlobal);
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
        public string SeleccionR3
        {
            get { return _txtR3; }
            set
            {
                SetProperty(ref _txtR3, value);
                txtR3 = _txtR3;
            }
        }
        public string SeleccionR4
        {
            get { return _txtR4; }
            set
            {
                SetProperty(ref _txtR4, value);
                txtR4 = _txtR4;
            }
        }

        #endregion
        #region PROCESOS
        public async Task Continuar()
        {
            Asignacion();
            await Navigation.PushAsync(new Reciduos(_ContadorGlobal));
        }
        public void ProcesoSimple()
        {

        }
        public void Asignacion()
        {
            switch (SeleccionR1)
            {
                case "Tengo 1":
                    ContadorGlobal = _ContadorGlobal + 2;
                    break;

                case "Tengo más de 1":
                    ContadorGlobal = _ContadorGlobal + 3;
                    break;
                case "No tengo":
                    ContadorGlobal = _ContadorGlobal + 0;
                    break;
            }

            switch (SeleccionR2)
            {
                case "Realizo 1":
                    ContadorGlobal = _ContadorGlobal - 1;
                    break;

                case "Realizo más de 1":
                    ContadorGlobal = _ContadorGlobal - 2;
                    break;
                case "Desconozco el significado":
                    ContadorGlobal = _ContadorGlobal + 0;
                    break;
            }

            switch (SeleccionR3)
            {
                case "Tengo 1":
                    ContadorGlobal = _ContadorGlobal - 1;
                    break;

                case "Tengo más de 1":
                    ContadorGlobal = _ContadorGlobal - 2;
                    break;
                case "No tengo":
                    ContadorGlobal = _ContadorGlobal + 1;
                    break;
            }

            switch (SeleccionR4)
            {
                case "1 Habitación":
                    ContadorGlobal = _ContadorGlobal + 1;
                    break;

                case "2 - 3 habitaciones":
                    ContadorGlobal = _ContadorGlobal + 2;
                    break;
                case "4 habitaciones o más":
                    ContadorGlobal = _ContadorGlobal + 3;
                    break;
            }

        }

        #endregion
        #region COMANDOS
        public ICommand btnContinuarcommand => new Command(async () => await Continuar());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HuellaVerde.ViewModel
{
    public class VMActividades:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        bool _Alimentos;
        bool _Hogar;
        bool _Transporte;
        bool _Ropa;
        bool _Construccion;
        bool _Jardin;

        #endregion
        #region CONSTRUCTOR
        public VMActividades(INavigation navigation, bool alimentos, bool hogar, bool transporte, bool ropa, bool construccion, bool jardin)
        {
            Navigation = navigation;
            _Alimentos = alimentos;
            _Hogar = hogar;
            _Transporte = transporte;
            _Ropa = ropa;
            _Construccion = construccion;
            _Jardin = jardin;
        }
        #endregion
        #region OBJETOS
        public bool Alimentos
        {
            get { return _Alimentos; }
            set { SetValue(ref _Alimentos, value); }
        }
        public bool Hogar
        {
            get { return _Hogar; }
            set { SetValue(ref _Hogar, value); }
        }
        public bool Transporte
        {
            get { return _Transporte; }
            set { SetValue(ref _Transporte, value); }
        }
        public bool Ropa
        {
            get { return _Ropa; }
            set { SetValue(ref _Ropa, value); }
        }
        public bool Construccion
        {
            get { return _Construccion; }
            set { SetValue(ref _Construccion, value); }
        }
        public bool Jardin
        {
            get { return _Jardin; }
            set { SetValue(ref _Jardin, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Regresar()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Regresarcommand => new Command(async () => await Regresar());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}

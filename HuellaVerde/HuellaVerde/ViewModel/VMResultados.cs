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
        string _resultado;
        bool _textoMedia;
        bool _textoAlta;
        bool _textoAlta2;
        bool _textoMedia2;

        int _Contadorglobal = 0;
        #endregion
        #region CONSTRUCTOR
        public VMResultados(INavigation navigation,int Conta)
        {
            Navigation = navigation;
            _Contadorglobal = Conta;

            if (_Contadorglobal > 10 && _Contadorglobal <= 19)
            {
                TextoAlta = false;
                TextoMedia = true;
                TextoMedia2 = true;
                TextoAlta2 = false;
            }
            else if (_Contadorglobal > 20 && _Contadorglobal <= 30)
            {
                TextoAlta = true;
                TextoMedia = false;
                TextoMedia2 = false;
                TextoAlta2 = true;
            }
        }
        #endregion
        #region OBJETOS
        public string Resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }
        public int Contador
        {
            get { return _Contadorglobal; }
            set { SetValue(ref _Contadorglobal, value); }
        }
        public bool TextoMedia
        {
            get { return _textoMedia; }
            set { SetValue(ref _textoMedia, value); }
        }
        public bool TextoAlta
        {
            get { return _textoAlta; }
            set { SetValue(ref _textoAlta, value); }
        }
        public bool TextoMedia2
        {
            get { return _textoMedia2; }
            set { SetValue(ref _textoMedia2, value); }
        }
        public bool TextoAlta2
        {
            get { return _textoAlta2; }
            set { SetValue(ref _textoAlta2, value); }
        }
        #endregion
        #region PROCESOS
        public async Task btnRegresar()
        {
            await Navigation.PopAsync();
        }

        public async Task IrAlimentos()
        {
            await Navigation.PushAsync(new actividades(true,false,false,false,false,false));
        }
        public async Task IrHogar()
        {
            await Navigation.PushAsync(new actividades(false,true,false,false,false,false));
        }
        public async Task IrTransporte()
        {
            await Navigation.PushAsync(new actividades(false,false,true,false,false,false));
        }
        public async Task IrRopa()
        {
            await Navigation.PushAsync(new actividades(false,false,false,true,false,false));
        }
        public async Task IrConstruccion()
        {
            await Navigation.PushAsync(new actividades(false,false,false,false,true,false));
        }
        public async Task IrJardin()
        {
            await Navigation.PushAsync(new actividades(false,false,false,false,false,true));
        }


        #endregion
        #region COMANDOS
        public ICommand btnRegresarcommand => new Command(async () => await btnRegresar());
        public ICommand IrAlimentoscommand => new Command(async () => await IrAlimentos());
        public ICommand IrHogarcommand => new Command(async () => await IrHogar());
        public ICommand IrRopacommand => new Command(async () => await IrRopa());
        public ICommand IrConstruccioncommand => new Command(async () => await IrConstruccion());
        public ICommand IrJardincommand => new Command(async () => await IrJardin());
        public ICommand IrTransportecommand => new Command(async () => await IrTransporte());
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}

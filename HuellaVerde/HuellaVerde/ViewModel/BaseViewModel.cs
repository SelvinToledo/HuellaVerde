using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Xamarin.Essentials;

namespace HuellaVerde.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation;

        public event PropertyChangedEventHandler PropertyChanged;

        private ImageSource foto;
        public ImageSource Foto
        {
            get { return foto; }
            set
            {
                foto = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public async Task DisplayAlert(string title, string message, string cancel)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        public async Task<bool> DisplayAlert(string title, string message, string accept, string cancel)
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            field = value;
            OnPropertyChanged(propertyName);

            return true;
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                SetProperty(ref _isBusy, value);
            }
        }
        protected void SetValue<T>(ref T backingFieled, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingFieled, value))

            {

                return;

            }

            backingFieled = value;

            OnPropertyChanged(propertyName);
        }

        #region ValidarInternet
        bool _Conectado;
        bool _SinConexion;

        public bool Conectado
        {
            get { return this._Conectado; }
            set
            {
                SetValue(ref this._Conectado, value);
            }
        }

        public bool SinConexion
        {
            get { return this._SinConexion; }
            set
            {
                SetValue(ref this._SinConexion, value);
            }
        }

        public void ValidarConexionInternet()
        {
            var time = TimeSpan.FromSeconds(1);
            Device.StartTimer(time, () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    ProbarConexion();
                }
                );

                return true;
            });
        }

        public void ProbarConexion()
        {
            if(Connectivity.NetworkAccess!=NetworkAccess.Internet)
            {
                Conectado = false;
                SinConexion = true;
            }
            else
            {
                Conectado = true;
                SinConexion = false;
            }
        }
        #endregion
    }
}

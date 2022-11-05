using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuellaVerde.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HuellaVerde.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class actividades : ContentPage
    {
        public actividades(bool alimentos, bool hogar, bool transporte, bool ropa, bool construccion, bool jardin)
        {
            InitializeComponent();
            BindingContext = new VMActividades(Navigation,alimentos,hogar,transporte,ropa,construccion,jardin);
        }
    }
}
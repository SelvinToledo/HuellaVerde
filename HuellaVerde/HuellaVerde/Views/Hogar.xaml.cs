using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HuellaVerde.ViewModel;

namespace HuellaVerde.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hogar : ContentPage
    {
        public Hogar(int C)
        {
            InitializeComponent();
            BindingContext = new VMHogar(Navigation,C);
        }
    }
}
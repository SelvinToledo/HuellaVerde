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
    public partial class Alimentos : ContentPage
    {
        public Alimentos(int C)
        {
            InitializeComponent();
            BindingContext = new VMAlimentos(Navigation,C);
            
        }
        
  
    }
}
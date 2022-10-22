﻿using System;
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
    public partial class Pantalla1 : ContentPage
    {
        public Pantalla1()
        {
            InitializeComponent();
            BindingContext = new VMPantalla1(Navigation);
        }
    }
}
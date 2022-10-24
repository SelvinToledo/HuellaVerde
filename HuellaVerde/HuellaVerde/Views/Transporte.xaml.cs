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
    public partial class Transporte : ContentPage
    {
        public Transporte()
        {
            InitializeComponent();
            BindingContext = new VMTransporte(Navigation);
        }
    }
}
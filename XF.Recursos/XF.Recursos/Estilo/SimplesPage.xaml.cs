﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Recursos.Estilo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimplesPage : ContentPage
    {
        public SimplesPage()
        {
            InitializeComponent();
            DisplayAlert("Mensagem", "Você clicou no botão", null);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xam.Forms.GraceAlert;
using Xamarin.Forms;

namespace Xam.Forms.Example
{
    public partial class MainPage : ContentPage
    {
        private readonly GraceAlertView _graceAlertView;

        public MainPage()
        {
            InitializeComponent();
            this._graceAlertView = this.GraceAlert();
        }

        private async void Error_OnClicked(object sender, EventArgs e)
        {
            await this._graceAlertView.Error("Errore","Non va bene cosi!");
        }
        
        private async void Warning_OnClicked(object sender, EventArgs e)
        {
            await this._graceAlertView.Warning("Attenzione","Aggiungi il dato che ben sai!");
        }

        private async void Info_OnClicked(object sender, EventArgs e)
        {
            await this._graceAlertView.Info("Info","Info carina ma non obbligatoria");
        }
       
    }
}
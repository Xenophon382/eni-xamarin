using Module4_TP1.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Module4_TP1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITwitterService twitterService = new TwitterService();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Connexion_Clicked(object sender, EventArgs e)
        {
            String Identifier = this.identifier.Text;
            String Password = this.password.Text;
            Boolean IsRemember = this.remember.IsToggled;

            this.error.IsVisible = false;

            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                this.error.Text = "Veuillez vous connecter à Internet";
                this.error.IsVisible = true;
                return;
            }

            if (this.twitterService.authenticate(Identifier, Password))
            {
                await Navigation.PushAsync(new TweetList());
            }
            else
            {
                this.error.Text = "Identifiants incorrects";
                this.error.IsVisible = true;
            }
        }
    }
}

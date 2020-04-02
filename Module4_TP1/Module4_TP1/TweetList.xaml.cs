using Module4_TP1.models;
using Module4_TP1.services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module4_TP1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetList : ContentPage
    {
        ObservableCollection<Tweet> ListeDetweets = new ObservableCollection<Tweet>();
        TwitterService ts = new TwitterService();

        public TweetList()
        {
            InitializeComponent();
            this.ListeDetweets = ts.getTweets();
            this.list.ItemsSource = ListeDetweets;
        }
    }
}
using Module4_TP1.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Module4_TP1.services
{
    interface ITwitterService
    {
        bool authenticate(String key, String secret);
        ObservableCollection<Tweet> getTweets();
    }
}

using Module4_TP1.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Module4_TP1.services
{
    class TwitterService : ITwitterService
    {
        public bool authenticate(string key, string secret)
        {
            if (key.Equals("toto") && secret.Equals("azertyuiop")) 
            { 
                return true; 
            }

            return false;
        }

        public ObservableCollection<Tweet> getTweets()
        {
            var tweets = new ObservableCollection<Tweet>();

            tweets.Add(
                new Tweet() 
                { 
                    CreationDate = "Thu Apr 06 15:28:43 +0000 2017", 
                    Identifier = "850007368138018817", 
                    UserIdentifier = "6253282", 
                    UserName = "Toto", 
                    UserPseudo = "Toto",
                    Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque"
                }); 
            
            tweets.Add(
                new Tweet() 
                { 
                    CreationDate = "Thu Apr 06 15:38:43 +0000 2017", 
                    Identifier = "850007368138018818", 
                    UserIdentifier = "6253282", 
                    UserName = "Jean-Pierre", 
                    UserPseudo = "JeanP",
                    Data = "Quisque auctor orci a orci posuere, quis sollicitudin urna rutrum. Phasellus pulvinar," +
                    " lacus sit amet consequat pretium, elit diam faucibus nisl, quis ornare justo risus sit amet dolor. Nam sed massa vitae"
                }); 

            tweets.Add(
                new Tweet()
                { 
                    CreationDate = "Thu Apr 06 15:48:43 +0000 2017", 
                    Identifier = "850007368138018819", 
                    UserIdentifier = "6253282", 
                    UserName = "Philipe", 
                    UserPseudo = "Phi",
                    Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque"
                }); 
            
            tweets.Add(
                new Tweet() 
                { 
                    CreationDate = "Thu Apr 06 15:58:43 +0000 2017", 
                    Identifier = "850007368138018820", 
                    UserIdentifier = "6253282", 
                    UserName = "Raphael", 
                    UserPseudo = "raph",
                    Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque"
                }); 
            
            return tweets;
        }
    }
}

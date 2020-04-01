using Module4_TP1.models;
using System;
using System.Collections.Generic;
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

        public List<Tweet> getTweets()
        {
            var tweets = new List<Tweet>();

            tweets.Add(
                new Tweet() 
                { 
                    CreationDate = "Thu Apr 06 15:28:43 +0000 2017", 
                    Identifier = "850007368138018817", 
                    UserIdentifier = "6253282", 
                    UserName = "Twitter API", 
                    UserPseudo = "twitterapi" 
                }); 
            
            tweets.Add(
                new Tweet() 
                { 
                    CreationDate = "Thu Apr 06 15:38:43 +0000 2017", 
                    Identifier = "850007368138018818", 
                    UserIdentifier = "6253282", 
                    UserName = "Twitter API", 
                    UserPseudo = "twitterapi" 
                }); 

            tweets.Add(
                new Tweet()
                { 
                    CreationDate = "Thu Apr 06 15:48:43 +0000 2017", 
                    Identifier = "850007368138018819", 
                    UserIdentifier = "6253282", 
                    UserName = "Twitter API", 
                    UserPseudo = "twitterapi" 
                }); 
            
            tweets.Add(
                new Tweet() 
                { 
                    CreationDate = "Thu Apr 06 15:58:43 +0000 2017", 
                    Identifier = "850007368138018820", 
                    UserIdentifier = "6253282", 
                    UserName = "Twitter API", 
                    UserPseudo = "twitterapi" 
                }); 
            
            return tweets;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Module4_TP1.models
{
    class Tweet
    {
        public string Identifier { get; set; }
        public string CreationDate { get; set; }
        public string UserName { get; set; }
        public string UserIdentifier { get; set; }
        public string Data { get; set; }

        private string userImage;
        public string UserImage
        {
            get
            {
                return "https://picsum.photos/50/50/?random";
            }
        }

        private string userPseudo;
        public string UserPseudo
        {
            get
            {
                return "@"+userPseudo;
            }
            set
            {
                userPseudo = value;
            }
        }

    }
}

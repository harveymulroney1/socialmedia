using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia_Testing
{
    public class Post
    {
        private string _PostCaption;
        private string _PostText;

        public string PostCaption { get => _PostCaption; set => _PostCaption = value; }
        public string PostText { get => _PostText; set => _PostText = value; }
    }
}

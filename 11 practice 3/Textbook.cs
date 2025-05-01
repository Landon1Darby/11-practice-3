using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _11_practice_3
{
    internal class Textbook
    {
        public Textbook(string title, string author, string pub ) 
        {
            Title = title;
            Author= author;
            Publisher = pub;
        }

        public Textbook() 
        {
            Title = "" ;
            Author = "";
            Publisher = "";

        }
        public string Title { get; }
        public string Author { get; }
        public string Publisher { get; }
    }
}

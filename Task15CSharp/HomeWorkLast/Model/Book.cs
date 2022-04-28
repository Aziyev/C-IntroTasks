using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkLast.Model
{
    internal class Book
    {
        public string Name { get; set; }    
        public string Author { get; set; }
        public int PageCount { get; set; }
        //public string Genre { get; set; }
        public Genere Genere { get; set; }

        public Book(string ourname,string ourauthor,int ourpagescount,Genere genere)
        {
            Name = ourname;
            Author = ourauthor;
            PageCount = ourpagescount;
            Genere = genere;
        }
        public override string ToString()
        {
            //return base.ToString();
            return $"NAME:{Name}" +
                $"\nAUTHOR:{Author}" +
                $"\nPAGECOUNT:{PageCount}" +
                $"\nGENRE:{Genere}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkDelegate
{
    //Code - Her kitabin adinin ilk iki herifi ve 
    //kitabin yaranma sirasindan ibaretdir, 
    //misalcun "programming" adli kitab 10-cu yaranmis kitabdirsa 
    //Code-u PR10 olmalidir
    //Name
    //AuthorName
    //PageCount
    internal class Book
    {
        public string Code { get; set; }    
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public static int a;

        public Book(string name,string authorName,int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = $"{name[0..2].ToUpper()} +' '+ {a}";
            a++;
        }

        internal static List<Book> FindAll(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Ad: {Name}" +
                $"\nMuellifAdi: {AuthorName}" +
                $"\nSeyfeSayi: {PageCount}" +
                $"\nKod: {Code}"; 
        }
    }
}

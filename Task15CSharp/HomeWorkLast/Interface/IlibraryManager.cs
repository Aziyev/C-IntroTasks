using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkLast.Model;
using HomeWorkLast.ForEnum;

namespace HomeWorkLast.Interface
{
    internal interface IlibraryManager
    {
        //List<string> GetLibraryNames();
        List<Book> Books { get; }
        void Add(Book book);
        Book Showinfo(string ourname);
        List<Book> Search(string search);
        List<Book> Filter(string ourauthor, Genere genere);
    }

    public class Genere
    {
    }
}

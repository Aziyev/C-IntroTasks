using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkLast.Model;
using HomeWorkLast.Interface;
//using HomeWorkLast.ServiceTry;
using HomeWorkLast.Service_Try_;
using HomeWorkLast.ForEnum;


namespace HomeWorkLast.Service_Try_
{
    internal class LibraryManagerFromInterface : IlibraryManager
    {
        private List<Book> _boook;
        public List<Book> Boook { get { return _boook; } }

        public LibraryManagerFromInterface()
        {
            _boook = new List<Book>();
        }
        public void Add(Book book)
        {
            if(_boook.Count > 0 && _boook.Exists(a => a.Name == book.Name))
                _boook.Add(book);

        }
        public List<Book> Filer(string ourauthor,Genere genere)
        {
            return _boook.FindAll(a => a.Author == ourauthor || a.Genere == genere);
        }
        //public List<Book> Search(string search)
        //{
        //    return _boook.FindAll(a)
        //}
        //ShowInfo metodu qaldi,,,
        
        
    }
}

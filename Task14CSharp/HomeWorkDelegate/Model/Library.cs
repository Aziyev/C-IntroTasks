using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkDelegate
{   
    internal class Library
    {
     //Asagidaki Memmberlerden Ibaret Library class Yaradin :
     //Books - Book claasi Type-da List Olacaq
     //FindAllBooksByName() - paramettr oalraq string value qebul edir ve adinda hemin string value olan book-lardan ibaret list qaytarir
     //RemoveAllBookByName() - paramter olaraq string value gonderilir ve adinda hemin string value olan book-lari silir
     //SearchBooks() - parameter olaraq string qebul edir ve Name, AuthorName, PageCount deyerlerinden her hanasi birinde gonderilmis string valuesu olan book-lardan ibaret list qaytarir
     //FindAllBooksByPageCountRange() - parametr olaraq iki integer qebul edir(minimum sehife ve maximum sehife sayi kimi) ve pagecount deyeri hemin araliqda olan booklardan ibaret list qaytarir
     //RemoveByNo() - parameter olaraq string value qebul edir ve nomresi hemin string value olan book-u siyahidan silir
        public Library()
        {
            Books = new List<Book>();
        }
        public List<Book> Books;
        public List<Book> FindAllBooksName(string name)
        {
           

        }
        public void RemoveAllBookName()
        {
            
        }
        public List<Book> SearchBooks()
        {

        }
        public List<Book> FindAllBooksByPageCountRange()
        {

        }
        public void RemoveByNO(string no)
        {

        }

    }
}

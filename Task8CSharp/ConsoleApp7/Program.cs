using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fullname deyerini daxil edin");
            string username = Console.ReadLine();

            User user = new User(username);

            Console.WriteLine("fullname duzgundur");
            
            Console.WriteLine("Sifreni daxil edin");
            
            string password = Console.ReadLine();
            
            user.Password = password;

            Console.WriteLine("Fullname ve sifre dogrudur");
        }
    }
}

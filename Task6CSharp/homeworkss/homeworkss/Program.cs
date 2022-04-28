using System;

namespace homeworkss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UserName-ni Daxil Edin");
            string username = Console.ReadLine();

            Console.WriteLine("Password-u Daxil Edin");
            string pazzword = Console.ReadLine();

            Isdifadeci isdifadeci = new Isdifadeci(username);
            isdifadeci.Password = pazzword;

            Console.WriteLine("Duzdur");
        }
    }
}

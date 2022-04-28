using System;

namespace Homework111
{
    internal class Program 
    {

        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine("Qrup Nomrenizi Daxil Edin");
            s.GroupNo = Console.ReadLine();
            Console.WriteLine("Ad Soyadinizi Daxil Edin");
            s.Fullname = Console.ReadLine();
            Console.WriteLine("Yasinizi Daxil Edin");
            

            int Age = int.Parse(Console.ReadLine());  
        }
    }
}

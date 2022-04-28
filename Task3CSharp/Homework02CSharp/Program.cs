using System;

namespace Homework02CSharp
{
    internal class Program
    {
        #region Bigrummer
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("sira ile uc eded daxil et");
            string b = Console.ReadLine();
            int eded = int.Parse(b);


            Console.WriteLine("ikincini daxil et");
            string c = Console.ReadLine();
            int eded1 = int.Parse(c);


            Console.WriteLine("ucuncunu daxil et -netice en boyuk olan olacaq");
            string d = Console.ReadLine();
            int eded2 = int.Parse(d);
            if (eded == eded1 && eded1 == eded2)
            {
                Console.WriteLine("beraberlik var ");

            }

            else Console.WriteLine(Biggernumber(eded, eded1, eded2));
        }
        static int Biggernumber(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;

            }

            else if (b > a && b > c)
            {

                return b;
            }
            else return c;




        }
        */
        #endregion

        #region task2
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi Daxil Edin:");

            string ededd = Console.ReadLine();

            int ededd2 = int.Parse(ededd);

            Console.WriteLine(task2(ededd2));

        }

        static int task2(int a)
        {
            int count;
            int cem = 0;
            while (a > 0)
            {
                count = a % 10;
                a /= 10;
                cem += count;

            }
            return cem;


        }

        */
        #endregion

        #region Cheepeer
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Super markette aksiyadir, aldiginiz uc mehsulun qiymetini sira daxil edin. Sadece iki en bahali malin qiymetini oduyeceksiniz.");
            string mehsulunsayi = Console.ReadLine();
            int say = int.Parse(mehsulunsayi);
            int[] arr = new int[say];

            Console.WriteLine("Diger mehsulu daxil edin.");
            string mehsulunsayi1 = Console.ReadLine();
            int say1 = int.Parse(mehsulunsayi1);
            int[] arr1 = new int[say1];


            Console.WriteLine("son mehsulu daxil edin.");
            string mehsulunsayi2 = Console.ReadLine();
            int say2 = int.Parse(mehsulunsayi2);
            int[] arr2 = new int[say2];
            Console.WriteLine(Cheeper(say1, say2, say));
        }
        static int Cheeper(int a, int b, int c)

        {
            if (a < b && a < c)
            {
                return c + b;
            }
            else if (b < a && b < c)
            {
                return a + c;

            }
            else return a + b;
        }

        #endregion
        */
        #endregion
    }
}

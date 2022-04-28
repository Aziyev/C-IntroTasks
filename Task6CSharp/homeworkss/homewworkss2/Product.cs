using System;
using System.Collections.Generic;
using System.Text;

namespace homewworkss2
{
    internal class Product
    {
        public string Name { get; set; }


        public double Price { get; set; }


        public int Count { get; set; }


        public double TotalIncome { get; set; }





        public Product(string name)
        {
            Name = name;
        }




        public void Sell()
        {
            if (Count >= 0)
            {
                Count--;
                
                TotalIncome += Price;
            }
            else
            {
                Console.WriteLine("Mehsulun sayi yoxdur yeni sifirdir");
            }
        }
    }
}

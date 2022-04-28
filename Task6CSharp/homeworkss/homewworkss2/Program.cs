using System;

namespace homewworkss2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Kitab");
            product.Count = 10;
            product.Price = 2;

            Qelem qelem = new Qelem("Oyal");
            
            qelem.Count = 10;
            qelem.Price = 2;
            
            Console.WriteLine(qelem.Count);
            
            Console.WriteLine(qelem.TotalIncome);
            
            qelem.Sell();

        }
    }
}

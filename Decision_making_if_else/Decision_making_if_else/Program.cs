using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_making_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int n = r.Next(-5, 5);

            Console.WriteLine(n);

            if (n < 0)
            {
                Console.WriteLine("The n variable is negative");

            }
            else if (n == 0)
            {
                Console.WriteLine("The n variable is zero");

            }
            else
            {
                Console.WriteLine("The n variable is positive");
            }


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxingexample
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 25;

            // boxing 
            Object obj1 = num1;

            // unboxing 
            int i = (int)obj1;


            Console.WriteLine("Boxing- The object is : {0}\n", obj1);
            Console.WriteLine("UnBoxing- The object is : {0}", i);
            Console.ReadKey();


        }
    }
}

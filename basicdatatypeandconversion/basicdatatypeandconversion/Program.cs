using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicdatatypeandconversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic datatypes

            int a = 23;
            float f = 4.44f;
            bool b = true;
            char c ='M';
            string name ="Musaraf mulla";
            double d = 4.33333365; 
            short s = 2;


            Console.WriteLine("int is :" + a);
            Console.WriteLine("float :" + f);
            Console.WriteLine("bool is :" + b);
            Console.WriteLine("char is :" + c);
            Console.WriteLine("string is :" + name);
            Console.WriteLine("double is :" + d);
            Console.WriteLine("short is :" + s);


            // data type conversion

            int val = 12345;
            string str = "";
            str = Convert.ToString(val);
            Console.WriteLine("\n int to string conversion:" + str);


            string str1 = "7865";
            int temp = Convert.ToInt32(str1);
            Console.WriteLine("\n string to int conversion:" + str1);

            float fval = Convert.ToSingle(val);
            Console.WriteLine("\n int to float conversion:" + fval);

            Double dbl = Convert.ToDouble(f);
            Console.WriteLine("\n float to double conversion:" + dbl);












            Console.ReadKey();


        }
    }
}

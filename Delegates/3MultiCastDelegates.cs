using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
   class Program
    {
        static void Main(string[] args)
        {
            // 3. Multicast Methods
            //PrintDelegateHelper PrintMessage1 = 
            //PrintDelegateHelper d1, d2, d3;
            //d1 = Method1;
            //d2 = Method2;

            //d3 = d1 + d2;
            //d3 = d3 - d1;


            //d3("Hello World!");
            //d3("Prateek");

            PrintDelegateHelper d1;

            d1 = Method1;
            d1 += Method2;
            d1 += Method3;

            d1("Prateek");

            d1 -= Method2;
            d1("Hello!");


            //Console.WriteLine(p3("Hello"));



            // 4. Using Delegates for Callbacks
            // 5. Using Delegates for making Flexible Applicaitons
            // 6. Action & Func
            Console.ReadLine();
        }

        public delegate void PrintDelegateHelper(string s);

        public static void Method1(string s)
        {
            Console.WriteLine($"Mehtod1 : {s}");
        }

        public static void Method2(string s)
        {
            Console.WriteLine($"Mehtod2 : {s}");
        }

        public static void Method3(string s)
        {
            Console.WriteLine($"Mehtod3 : {s}");
        }
    }
}

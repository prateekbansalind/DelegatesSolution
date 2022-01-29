using System;

namespace Delegates
{
    class Prgram
    {
        static void Main(string[] args)
        {
            // Topics Covered

            // 1. Simple Delegates
            // A type that represents references to methods.
            // A object that knows how to call a method.
            // Helpful in designing extensible and flexible applicaitons

            // Example Syntax
            // public delegate void PrintDelegate(string message);

            // PrintDelegate instance = AnyMethod;
            // Method should be of same signature.

            // instance("Sample Message");
            // Invoking/Calling a delegate. 

            MyDelegate d1 = Method1;

            d1(5);
            d1(6);
            d1(45);

            Console.ReadLine(); // this line of code basically waits for input. 

        }

        public delegate void MyDelegate(int d);

        public static void Method1(int i)
        {
            Console.WriteLine($"This is Method1. {i}");
        }
    }
}
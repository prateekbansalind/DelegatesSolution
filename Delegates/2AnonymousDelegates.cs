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
            // 2. Anonymous Methods

            MyDelegate square = delegate (int n) { return n * n; };
            MyDelegate cube = delegate (int n) { return n * n * n; };

            int squareValue = square(4);
            int cubeValue = cube(4);

            Console.WriteLine($"The results are {squareValue} and {cubeValue}.");
        }

        public delegate int MyDelegate(int i);
    }
}

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Arithmetic operators */
            var a = 10;
            var b = 3;
            Console.WriteLine(a / b);               // 3
            Console.WriteLine((float)a / (float)b); // 3.333333
            Console.WriteLine(a / (float)b);        // 3.333333
            Console.WriteLine((float)a / b);        // 3.333333

            a = 1;
            b = 2;
            var c = 3;
            Console.WriteLine(a + b * c);           // 7
            Console.WriteLine((a + b) * c);         // 9

            /* Logical operators */
            Console.WriteLine(a > b);               // False
            Console.WriteLine(a == b);              // False
            Console.WriteLine(a != b);              // True
            Console.WriteLine(!(a != b));           // False

            Console.WriteLine(c > b && c > a);      // True
            Console.WriteLine(c > b && c == a);     // False
            Console.WriteLine(c > b || c == a);     // True
            Console.WriteLine(!(c > b || c == a));  // False
        }
    }
}

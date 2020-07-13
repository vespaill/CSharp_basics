using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 255;
            Console.WriteLine("number: " + number);
            number++;
            Console.WriteLine("number: " + number);

            checked
            {
                byte numberToCheck = 255;
                numberToCheck++;
            }
        }
    }
}

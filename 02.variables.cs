using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.96f;
            char character = 'A';
            string firstName = "Victor";
            bool isWorkinng = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorkinng);

            // Type inference
            // var number = 2;  // Int32
            // var count = 10;
            // var totalPrice = 20.96f;
            // var character = 'A';
            // var firstName = "Victor";
            // var isWorkinng = false;

            System.Console.WriteLine("Min and Max values:");
            // Format string
            System.Console.WriteLine("bytes:  {0}, {1}", byte.MinValue, byte.MaxValue);
            System.Console.WriteLine("floats: {0}, {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;
            Pi = 1;     // Compile time error.
        }
    }
}

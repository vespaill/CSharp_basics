using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Implicity type conversions. */
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            /* Compile time error:
             * Cannot implicitly convert type 'int' to 'byte' */
            // int j = i;
            // byte c = j;
            // Console.WriteLine(c);

            /* Can explicity convert if using a cast, but may lose data. */
            int j = 255;
            byte c = (byte)j;
            Console.WriteLine("c: " + c + ", bin: " + Convert.ToString(c, 2));
            j++;
            c = (byte)j;
            Console.WriteLine("c: " + c + ", bin: " + Convert.ToString(c, 2));

            /* Converting incompatible types. */
            var number = "1234";
            // int k = (int)number;    // Compile time error: Cannot convert type 'string' to 'int'
            int k = Convert.ToInt32(number);
            Console.WriteLine(k);

            /* Runtime error: Unhandled Exception: System.OverflowException:
             * Value was either too large or too small for an unsigned byte. */
            // byte l = Convert.ToByte(number);
            // Console.WriteLine(l);

            /* Handle exception with a try-and-catch block. */
            try
            {
                byte l = Convert.ToByte(number);
                Console.WriteLine(l);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }


            try
            {
                string str = "true";
                bool bb = Convert.ToBoolean(str);
                Console.WriteLine(bb);
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to a boolean.");
            }
        }
    }
}

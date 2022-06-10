using System;
namespace HelloWorld.O01_Variable
{
    public class Variables
    {
        public Variables()
        {
        }

        public static void Initialize()
        {
            Console.WriteLine("\nVariable Example\n");
            int number = 1;
            int Number = 2;
            const float pi = 3.14f;
            Console.WriteLine("{0} {1} {2}",number, Number, pi);
        }

        public static void Overflowing()
        {
            byte number = 255;
            number = (byte)(number + 1);
            Console.WriteLine("Overflowing " + number);
            int number1 = 257;

            byte number2 = (byte)number1;
        }

        public static void TypeConversion()
        {
            // Implicit Type Conversion
            byte i = 1;
            int number = i;
            Console.WriteLine("Implicit Type Conversion - Integer Value {0}", number);

            // Explicit Type Conversion
            number = 1;
            byte i1 = (byte)number;
            Console.WriteLine("Explicit Type Conversion - Byte Value {0}", i1);

            float f = 10.2345f;
            int fi = (int)f;
            Console.WriteLine("Explicit Type Conversion - Integer Value {0}", fi);

            //Non-compatible Type Conversion
            string s = "123";
            int si = Convert.ToInt32(s);
            Console.WriteLine("Non-compatible Type Conversion - Integer Value {0}", si);

            string b = "true";
            bool bValue = Convert.ToBoolean(b);
            Console.WriteLine("Boolean Value {0}",bValue);


        }

    }
}

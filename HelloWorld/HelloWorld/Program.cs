using System;

namespace HelloWorld
{
    class Program
    {
        public static void LearnVariables()
        {
            Variables.Initialize();

            Variables.Overflowing();

            Variables.TypeConversion();
        }

        static void Main(string[] args)
        {
            LearnVariables();

        }
    }
}

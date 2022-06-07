using System;
using HelloWorld.O01_Variable;
using HelloWorld.O02_Class;
using HelloWorld.O03_Array;

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

        public static void LearnClasses()
        {
            Person person = new("Naveen", "Kumar");
            person.Introduce();

        }

        public static void LearnArray()
        {
            ArrayDemo array = new();
            array.ArrayExample();

        }

        static void Main(string[] args)
        {
            LearnVariables();
            LearnClasses();
            LearnArray();

        }
    }
}

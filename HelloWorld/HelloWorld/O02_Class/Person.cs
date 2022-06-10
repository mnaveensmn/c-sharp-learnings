using System;

namespace HelloWorld.O02_Class
{
    public class Person
    {
        private readonly string FirstName;
        private readonly string SecondName;
        public int age = 10;

        public Person(string FirstName, string SecondName)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
        }

        public void Introduce()
        {
            Console.WriteLine("\nClass Example\n");
            Console.WriteLine("Hello, {0} {1}", FirstName, SecondName);
        }
    }
}

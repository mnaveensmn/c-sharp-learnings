using System;
using System.Collections.Generic;

namespace HelloWorld.O00_Exercise
{
    public class O03_ArrayAndList
    {
        public O03_ArrayAndList()
        {
        }

        public static void Run()
        {
            LearnFaceBookLikes();

        }

        public static void LearnFaceBookLikes()
        {
            Console.WriteLine("Enter the friends names");

            List<string> names = new List<string>();
            while (true)
            {
                string userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    break;
                }
                else
                {
                    names.Add(userInput);
                }
            }

            if (names.Count > 2)
            {
                Console.WriteLine("{0}, {1} and {3} other likes your post", names[0], names[1], names.Count - 2);
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} like you post", names[0], names[1]);
            }
            else if (names.Count == 1)
            {
                Console.WriteLine("{0} like you post", names[0]);
            }

        }
    }
}


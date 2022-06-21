using System;
namespace HelloWorld.O07_ControlFlow
{

    public enum Season
    {
        Autumn,
        Winter,
        Summer,
        Spring
    }

    public class ControlFlow
    {
        public ControlFlow()
        {
        }

        public static void LearnIfElse()
        {
            Console.WriteLine("\nLearn If Else\n");
            int i = 0;
            if (i == 0)
            {
                Console.WriteLine("This is impossible");
            }
            else
            {
                Console.WriteLine("1==0 is Cannot be true");
            }

            //If else lader
            int a = 10;

            if (a == 1)
            {
                Console.WriteLine("a==1");
            }
            else if (a == 2)
            {
                Console.WriteLine("a==2");
            }
            else
            {
                Console.WriteLine("Neither a==1 nor a==2. a is {0}", a);
            }

            Console.WriteLine(a == 10 ? "Option 1" : "Option 2");
        }

        public static void LearnSwitch()
        {
            Console.WriteLine("\nLearn Switch\n");
            Season season = Season.Autumn;

            switch (season)
            {
                case Season.Winter:
                case Season.Autumn:
                    Console.WriteLine("Autumn Season");
                    break;
                case Season.Spring:
                    Console.WriteLine("Spring Season");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }

        public static void LearnForLoop()
        {
            Console.WriteLine("\nLearn For Loop\n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }

            Console.WriteLine("");

            string name = "Naveen Kumar M";

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
            }

            Console.WriteLine("");

            foreach (char c in name)
            {
                Console.Write(c);
            }

            Console.WriteLine("");

            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            foreach (int a in arr)
            {
                Console.Write(a);
            }
            Console.WriteLine("");

        }

        public static void LearnWhileLoop()
        {
            Console.WriteLine("\nLearn While Loop\n");
            int i = 0;
            while (i < 10)
            {
                Console.Write(i);
                i++;
            }
            Console.WriteLine("");

            i = 0;
            while (true)
            {
                if (i > 10)
                {
                    Console.Write(i);
                    i++;
                    continue;
                }
                break;
            }
            Console.WriteLine("");
        }

        public static void LearnRandomClass()
        {
            Console.WriteLine("\nLearn Random Class\n");
            Random random = new();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.Next());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.Next(1,10));
            }

            Console.WriteLine("\nGenerating Random Password");
            char[] buffer = new char[10];
            for (int i = 0; i < 10; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            string password = new(buffer);
            Console.WriteLine(password);
        }



    }


}


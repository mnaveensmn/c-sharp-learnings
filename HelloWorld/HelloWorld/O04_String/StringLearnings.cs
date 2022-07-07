using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.O04_String
{
    public class StringLearnings
    {
        public StringLearnings()
        {
        }

        public static void Learn()
        {
            //LearnBasics();
            //LearnStringFunctions();
            //Console.WriteLine(SummerizeText("When we have a strong wish with patience and hard work, the whole world will conspire to help us", 40));
            LearnStringBuilder();
        }

        public static void LearnBasics()
        {
            Console.WriteLine("\nString Example\n");

            string firstName = "Naveen";
            string lastName = "Kumar";

            //Using string format
            string name = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(name);

            //Using String Join
            int[] numbers = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(string.Join(", ", numbers));

            //Acceessing String Elements
            char firstChar = firstName[0];
            Console.WriteLine(firstChar);
        }

        public static void LearnStringFunctions()
        {
            string str = "ab cd  ";
            Console.WriteLine("Trim: {0}", str.Trim());
            Console.WriteLine("ToUpper: {0}", str.Trim().ToUpper());

            int index = str.IndexOf(' ');
            string first = str.Substring(0, index);
            string last = str.Substring(index + 1);
            Console.WriteLine("First String: {0}\nLast String: {1}", first, last);

            string[] strArr = str.Split(' ');
            Console.WriteLine("First String: {0}\nLast String: {1}", strArr[0], strArr[1]);

            Console.WriteLine("Replace: {0}", str.Replace(" ", ""));

            if (string.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");

            float price = 100.0f;
            Console.WriteLine(price.ToString("C"));

        }

        public static void LearnStringBuilder()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.Append('-', 10)
                        .AppendLine()
                        .Append("Header")
                        .AppendLine()
                        .Append('-', 10)
                        .Replace('-', '+')
                        .Remove(0, 10)
                        .Insert(0, new string('-',10));

            Console.WriteLine(stringBuilder);
        }


        private static string SummerizeText(string text, int? maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }

            string[] words = text.Split(' ');
            int totalCharacters = 0;
            List<string> summaryWords = new();

            foreach (string word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";
        }

    }
}


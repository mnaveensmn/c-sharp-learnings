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
            ReverseString();
            SortNumbers();
            FilterDuplicates();
            ThreeSmallestNumber();

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

                Console.WriteLine("{0}, {1} and {2} other liked your post", names[0], names[1], names.Count - 2);
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} liked your post", names[0], names[1]);
            }
            else if (names.Count == 1)
            {
                Console.WriteLine("{0} liked you post", names[0]);
            }
        }

        public static void ReverseString()
        {
            Console.WriteLine("Enter the name to reverse");
            string enteredName = Console.ReadLine();
            char[] nameCharArr = enteredName.ToCharArray();
            int start = 0, end = nameCharArr.Length - 1;
            while (start < end)
            {
                char temp = nameCharArr[start];
                nameCharArr[start] = nameCharArr[end];
                nameCharArr[end] = temp;
                start++;
                end--;
            }
            Console.WriteLine("Revered string {0}", new string(nameCharArr));
        }

        public static void SortNumbers()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter the unqiue numbers");
            int count = 0;
            while (count < 5)
            {
                string number = Console.ReadLine();
                int num = Convert.ToInt32(number);
                if (!numbers.Contains(num))
                {
                    numbers.Add(num);
                    count++;
                }
                else
                {
                    Console.WriteLine("Please enter the unqiue numbers");

                }
            }
            numbers.Sort();
            PrintList(numbers);
        }

        public static void FilterDuplicates()
        {
            Console.WriteLine("\nEnter the numbers");
            List<int> numbers = new List<int>();
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput.Trim().ToLowerInvariant().Equals("quit"))
                {
                    break;
                }
                else
                {
                    int number = Convert.ToInt32(userInput);
                    if (!numbers.Contains(number))
                    {
                        numbers.Add(number);
                    }
                }
            }
            PrintList(numbers);
        }

        public static void ThreeSmallestNumber()
        {
            Console.WriteLine("Enter the number list. 5, 1, 9, 2, 10");
            string[] numberArray;
            while (true)
            {
                string userInput = Console.ReadLine();
                numberArray = userInput.Split(",");
                if (string.IsNullOrEmpty(userInput.Trim()) || numberArray.Length < 5)
                {

                    Console.WriteLine("Invalid List. Please re-try");
                }
                else
                {
                    break;
                }
            }
            Array.Sort(numberArray);
            List<int> smallestNumber = new List<int>();
            int index = 0, count = 0;
            while (true)
            {
                if (count == 3)
                {
                    break;
                }
                int number = Convert.ToInt32(numberArray[index].Trim());
                if (!smallestNumber.Contains(number))
                {
                    smallestNumber.Add(number);
                    count++;
                }
                index++;
            }
            PrintList(smallestNumber);
        }

        private static void PrintList(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}


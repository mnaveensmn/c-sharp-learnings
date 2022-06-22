using System;
namespace HelloWorld.O00_Exercise
{
    public class O02_Loops
    {
        public O02_Loops()
        {
        }

        public static void Run()
        {
            CountNumbersDivisibleBy3();
            CalculateSum();
            FactorialOfNumber();
            GuessNumber();
            MaxNumbers();
        }

        public static void CountNumbersDivisibleBy3()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Count of numbers divisible by 3 {0}", count);
        }

        public static void CalculateSum()
        {
            int sum = 0;
            Console.WriteLine("Program for calculating sum of entered numbers");
            while (true)
            {
                Console.WriteLine("Enter a number or type 'ok' to exit");
                string userInput = Console.ReadLine();
                if (userInput.Equals("ok"))
                {
                    break;
                }
                sum += Convert.ToInt32(userInput);
            }
            Console.WriteLine("Sum of entered numbers {0}", sum);
        }

        public static void FactorialOfNumber()
        {
            Console.WriteLine("Enter a number to calculate factorial");
            string userInput = Console.ReadLine();
            int num = Convert.ToInt32(userInput);
            int factorial = 1;
            while (num > 1)
            {
                factorial *= num;
                num--;
            }
            Console.WriteLine("Factorial of given number is {0}", factorial);
        }

        public static void GuessNumber()
        {
            Random random = new();
            int i = 0;
            int randomNumber = random.Next(1, 11);
            int winFlag = 0;
            while(i<4)
            {
                Console.WriteLine("Guess the generated random number");
                string userInput = Console.ReadLine();
                int userGuess = Convert.ToInt32(userInput);
                if (userGuess == randomNumber)
                {
                    winFlag = 1;
                    break;
                }
            }

            if (winFlag == 1)
            {
                Console.WriteLine("You Won");
            } else
            {
                Console.WriteLine("You Lost");
            }

        }

        public static void MaxNumbers()
        {
            Console.WriteLine("Enter the series of number like 1, 2, 3");
            string userInput = Console.ReadLine();
            string[] numbers = userInput.Split(",");
            int max = -1;
            foreach (string number in numbers)
            {
                int num = Convert.ToInt32(number.Trim());
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("Maximum number from entered series is {0}",max);
        }




    }
}


using System;
namespace HelloWorld.O00_Exercise
{
    public class O01_ControlFlow
    {
        public O01_ControlFlow()
        {
        }

        public static void Run()
        {
            IsValidNumber();
            MaxNumber();
            IsPortraitOrLandscape();
            SpeedCamera();
        }

        public static void IsValidNumber()
        {
            Console.WriteLine("Enter the Number");
            string enteredNumber = Console.ReadLine();
            int number = Convert.ToInt32(enteredNumber);
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid Number");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }

        public static void MaxNumber()
        {
            Console.WriteLine("Enter a two numbers");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int a = Convert.ToInt32(input1);
            int b = Convert.ToInt32(input2);
            Console.WriteLine("Maximum Number {0}", (a > b) ? a : b);
        }

        public static void IsPortraitOrLandscape()
        {
            Console.WriteLine("Enter a width and height of an image");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int width = Convert.ToInt32(input1);
            int height = Convert.ToInt32(input2);
            Console.WriteLine("Given Image is a {0}", (width > height) ? "Landscape" : "Portrait");
        }

        public static void SpeedCamera()
        {
            Console.WriteLine("Enter the speed limit of the car");
            string enteredSpeedLimit = Console.ReadLine();
            int speedLimit = Convert.ToInt32(enteredSpeedLimit);
            Console.WriteLine("Enter the speed of the car");
            string enteredSpeed = Console.ReadLine();
            int speed = Convert.ToInt32(enteredSpeed);

            if (speed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demerit = (speed - speedLimit) / 5;
                if (demerit > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("{0} demerit points",demerit);
                }
            }
        }



    }
}


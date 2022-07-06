using System;
namespace HelloWorld.O09_Dates
{
    public class DateAndTimes
    {
        public DateAndTimes()
        {
        }
        public static void Learn()
        {
            //LearnDateTime();
            LearnTimeSpan();
        }

        public static void LearnDateTime()
        {
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;

            Console.WriteLine("Now " + now.ToString());
            Console.WriteLine("Today " + today.ToString());

            Console.WriteLine("Hour " + now.Hour);
            Console.WriteLine("Minute " + today.Minute);

            DateTime tomorrow = now.AddDays(1);
            DateTime yesterday = now.AddDays(-1);

            Console.WriteLine("Tomorrow " + tomorrow);
            Console.WriteLine("Yesterday " + yesterday);

            Console.WriteLine("Format Functions with DateTime Class");
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("MMMM dd, yyyy H:mm:ss zzz")); //DateTime Format Specifier

        }

        public static void LearnTimeSpan()
        {
            TimeSpan timeSpan = new(1, 2, 3);
            TimeSpan timeSpan1 = new(1, 0, 0);
            TimeSpan timeSpan2 = TimeSpan.FromHours(1);

            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan1);
            Console.WriteLine(timeSpan2);

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMinutes(2);
            TimeSpan differnce = end - start;
            Console.WriteLine("Duration: " + differnce);

            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Modify
            Console.WriteLine("Add Example: " + timeSpan1.Add(TimeSpan.FromMinutes(5)));
            Console.WriteLine("Subtract Example: " + timeSpan1.Subtract(TimeSpan.FromMinutes(5)));

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}


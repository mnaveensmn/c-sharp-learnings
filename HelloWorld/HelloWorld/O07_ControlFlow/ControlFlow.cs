using System;
namespace HelloWorld.O07_ControlFlow
{
	public class ControlFlow
	{
		public ControlFlow()
		{
		}
		public static void LearnIfElse()
		{
			Console.WriteLine("\nLearn Control Flow\n");

			if (1==0)
            {
				Console.WriteLine("This is impossible");
            } else
            {
				Console.WriteLine("1==0 is Cannot be true");
			}

			//If else lader
			int a = 10;

			if (a==1)
            {
				Console.WriteLine("a==1");
			} else if (a==2)
            {
				Console.WriteLine("a==2");
			} else
            {
				Console.WriteLine("Neither a==1 nor a==2. a is {0}",a);
			}
		}
	}

	
}


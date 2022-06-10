using System;
namespace HelloWorld.O04_String
{
	public class StringLearnings
	{
		public StringLearnings()
		{
		}

		public static void Learn()
        {
			Console.WriteLine("\nString Example\n");

			string firstName = "Naveen";
			string lastName = "Kumar";

			//Using string format
			string name = string.Format("{0} {1}", firstName, lastName);
			Console.WriteLine(name);

			//Using String Join
			int[] numbers = new int[] { 1, 2, 3, 4 };
			Console.WriteLine(string.Join(", ",numbers));

			//Acceessing String Elements
			char firstChar = firstName[0];
			Console.WriteLine(firstChar);

        }


	}
}


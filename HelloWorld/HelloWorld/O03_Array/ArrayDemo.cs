using System;
namespace HelloWorld.O03_Array
{
	public class ArrayDemo
	{
		public ArrayDemo()
		{
		}

		public static void ArrayExample()
        {
			Console.WriteLine("\nArray Example\n");
			int[] arr = new int[100];

			arr[0] = 10;
			arr[10] = 10;
			arr[99] = 10;

			Console.WriteLine(arr[99]);
        }
	}
}


using System;
namespace HelloWorld.O03_Array
{
	public class ArrayDemo
	{
		public ArrayDemo()
		{
		}

		public void ArrayExample()
        {
			int[] arr = new int[100];

			arr[0] = 10;
			arr[10] = 10;
			arr[99] = 10;

			Console.WriteLine(arr[99]);
        }
	}
}


using System;
using HelloWorld.O02_Class;

namespace HelloWorld.O06_ReferenceValueType
{
	public class ReferenceValueType
	{
		public ReferenceValueType()
		{
		}

		public static void Learn()
        {
			Console.WriteLine("\nReference and Value Type\n");
			int a = 10;
			int b = a;
			a++;
			Console.WriteLine("a => {0}, b => {1}",a, b);

			int[] arr1 = new int[10];
			int[] arr2 = arr1;
			arr1[0] = 10;
			Console.WriteLine("arr1[0] => {0}, arr2[0] => {1}", arr1[0], arr2[0]);

			Person person = new("Naveen","Kumar");
			int c = 10;
			Increment(c);
			MakeOld(person);
			Console.WriteLine("c => {0}, person.age => {1}", c, person.age);

		}

		public static void Increment(int number)
        {
			number += 10;
        }

		public static void MakeOld(Person person)
        {
			person.age += 10;	
        }
	}
}


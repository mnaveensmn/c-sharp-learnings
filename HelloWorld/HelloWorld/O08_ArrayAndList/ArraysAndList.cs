using System;
using System.Collections.Generic;

namespace HelloWorld.O08_ArrayAndList
{
    public class ArrayAndList
    {
        public ArrayAndList()
        {
        }

        public static void Learn()
        {
            LearnArray();
            LearnList();
        }

        public static void LearnArray()
        {
            Console.WriteLine("\nArray Example\n");

            //Length of an array
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Length :" + numbers.Length);

            //Index of an array
            int index = Array.IndexOf(numbers, 6);
            Console.WriteLine("Index of 6: " + index);

            //Clear Array Elements
            //Set the given range index to zero
            Console.WriteLine("Effect of Clear()");
            Array.Clear(numbers, 0, 2);
            foreach (var a in numbers)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine("");

            //Copy()
            int[] copyArray = new int[3];
            Array.Copy(numbers, copyArray, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var a in copyArray)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine("");

            //Sort()
            Console.WriteLine("Sort an Array");
            int[] array2 = new int[] { 3, 2, 1 };
            Array.Sort(array2);
            foreach (var a in array2)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine("");

            //Reverse()
            Array.Reverse(array2);
            Console.WriteLine("Reverse an Array");
            foreach (var a in array2)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine("");
        }

        public static void LearnList()
        {
            Console.WriteLine("\nList Example\n");
            List<int> list = new() { 1, 2 };
            list.AddRange(new int[] { 3, 4, 1 });
            list.Add(5);

            foreach (int a in list)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Index of 1: " + list.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + list.LastIndexOf(1));
            Console.WriteLine("List Count: " + list.Count);

            Console.WriteLine("Remove 1 in the list");
            list.Remove(1);
            foreach (int a in list)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Remove All the 1 in list");
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 1)
                {
                    list.Remove(list[i]);
                }
            }

            foreach (int a in list)
                Console.Write(a + " ");

            Console.WriteLine("");

            Console.WriteLine("Clearing the list");
            list.Clear();
            Console.WriteLine(list.Count);

        }

    }
}


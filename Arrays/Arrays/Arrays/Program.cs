using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers;
            // numbers = new int[10] { 1,2,3,4,5,6,7,8,9,10 };

            // numbers[2] = 10;  // 10 is length of array
            // Console.WriteLine(numbers[2]);
            // Console.WriteLine(numbers.Length);
            // Console.ReadLine();

            // string[] Fruits = { "Apples", "Grapes", "Kiwi", "Oranges", "Berries" };
            // Console.WriteLine(Fruits[2]);
            // Console.WriteLine(Fruits.Length);
            // Console.ReadLine();

            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);

            //numbers.Remove(4);

            //Console.WriteLine(numbers.Count);
            //Console.ReadLine();

            List<string> Fruits = new List<string>();
            Fruits.Add("Strawberry");
            Fruits.Add("Oranges");
            Fruits.Add("Grapes");
            Fruits.Add("Blueberries");
            Fruits.Add("Apples");

            Console.WriteLine(Fruits.Count);
            Console.ReadLine();

        }
    }
}

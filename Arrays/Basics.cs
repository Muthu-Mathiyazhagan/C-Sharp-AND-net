using System;
namespace Arrays
{
    public class Basics
    {
        public static void Run()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var names = new string[] { "Muthu", "Mathiyazhagan", "Yaadhumanavan" };

            //Length
            System.Console.WriteLine("Length : " + numbers.Length); // return 8

            //IndexOf()
            System.Console.WriteLine("IndexOf : " + Array.IndexOf(numbers, 0)); // return -1

            //Clear ()
            System.Console.WriteLine("Effect of Clear ");

            Array.Clear(numbers, numbers.Length - 2, 2);
            Array.Clear(numbers, 0, 2);
            foreach (var number in numbers) { System.Console.WriteLine(number); }

            //Copy ()
            var another = new int[4];
            Array.Copy(numbers, another, 4);
            System.Console.WriteLine("Effect of Copy \n Another Array");
            foreach (var item in another)
            {
                System.Console.WriteLine(item);
            }

            //Sort ()
            System.Console.WriteLine("Effect of Sort \n Sorted Array");
            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }

            //Reverse ()
            System.Console.WriteLine("Effect of Reverse() \n reversed Another Array");
            Array.Reverse(another);
            foreach (var item in another)
            {
                System.Console.WriteLine(item);
            }


        }
    }
}
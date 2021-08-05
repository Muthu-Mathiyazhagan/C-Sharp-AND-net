using System;
using System.Collections.Generic;
namespace Arrays
{
    public class SortFive
    {
        public static void Run()
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {

                System.Console.WriteLine("Enter Number of Position #{0}: ", numbers.Count + 1);
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    System.Console.WriteLine("You have previously Entered this Number");
                    continue;
                }
                numbers.Add(number);

            }
            numbers.Sort();
            foreach (var item in numbers)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine("\n");
        }
    }
}
using System;
using System.Collections.Generic;
namespace Arrays
{
    public class RemoveDuplicates
    {
        public static void Run()
        {
            var numbers = new List<int>();
            while (true)
            {
                System.Console.WriteLine("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit") break;
                numbers.Add(Convert.ToInt32(input));

            }
            var unique = new List<int>();
            foreach (var n in numbers)
            {
                if (!unique.Contains(n))
                {
                    unique.Add(n);
                }
            }
            foreach (var m in unique)
            {
                System.Console.WriteLine(m);
            }
        }
    }
}
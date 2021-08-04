using System.Collections.Generic;
using System;
namespace Arrays
{
    public class facebookLike
    {
        public static void Run()
        {
            var names = new List<string>();
            while (true)
            {
                System.Console.WriteLine("enter different names");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                names.Add(input);

            }
            if (names.Count > 2)
                System.Console.WriteLine("{0},{1} and {2} Others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();

        }
    }
}
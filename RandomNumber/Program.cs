using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
             Random rand = new Random();
  
        // Print 10 random numbers
        Console.WriteLine("Printing 10 random numbers");
        for (int i = 1; i <= 10; i++)
            Console.WriteLine("{0} -> {1}", i, rand.Next());

        }
    }
}

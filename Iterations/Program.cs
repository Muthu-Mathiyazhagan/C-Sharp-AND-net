using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // ForLoop.Examples();
            ForEach.Strings("Muthu");
            var numbers = new int[5]{1,2,3,4,5};
            ForEach.Arrays(numbers);
        }
    }
}

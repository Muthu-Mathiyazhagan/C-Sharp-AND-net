using System;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int [3]{3,6,9};
            var names = new string[3]{"Muthu","Mathiyazhagan","Yaadhumanavan"};
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(names[i]);
                Console.WriteLine(numbers[i]);
            }
            // numbers[2] = 9;
            // System.Console.WriteLine(numbers[1]);
        }
    }
}

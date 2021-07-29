using System;

namespace StaticModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // StaticModifiers.Calculator.Add(2,5);
            // System.Console.WriteLine(int Calculator.Add (6,5)); 
            // addition.Add(1,4);
            var add = new addition();
            add.Add(5,6);
        }
    }
}

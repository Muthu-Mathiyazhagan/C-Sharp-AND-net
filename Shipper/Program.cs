using System;

namespace Shipper
{
    public enum ShippingMethod{
        Local=1,Express=2,Air=4
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Muthu is the best fullstack Developer!");
            System.Console.WriteLine("Air Enum ="+(int)ShippingMethod.Air);
            var methodID = 2;
            System.Console.WriteLine((ShippingMethod)methodID);

        }
    }
}

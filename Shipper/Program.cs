using System;

namespace Shipper
{
    enum ShippingMethod{
        Local=1,Express=2,Air=4
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("Air Enum ="+(int)ShippingMethod.Air);
            var method = 2;
            System.Console.WriteLine((ShippingMethod)method);

        }
    }
}

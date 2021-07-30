using System;

namespace Shipper
{
    public enum ShippingMethod : byte
    {
        Local=1,Express=2,Air=4
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Muthu is the best fullstack Developer!");
            System.Console.WriteLine("Air Enum ="+(int)ShippingMethod.Air);
            var method = ShippingMethod.Express;
            System.Console.WriteLine((int)method);
            var methodID = 2;
            System.Console.WriteLine((ShippingMethod)methodID);
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod),methodName);
            System.Console.WriteLine(shippingMethod);
        }
    }
}

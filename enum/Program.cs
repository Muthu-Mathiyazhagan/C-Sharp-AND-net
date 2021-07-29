using System;


namespace enum
{
   
    class Program
    {

        public enum ShippingMethod
        {
            Regular = 1,
            Registered = 2,
            Express = 3
        }
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            System.Console.WriteLine((int)method);

            var methodId = 3;
            System.Console.WriteLine((ShippingMethod)methodId);
        }
    }
}

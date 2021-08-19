using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dob = new DateTime(1993, 1, 1);
            System.Console.WriteLine(dob.ToString("ddd"));
            System.Console.WriteLine(dob.ToString("dddd"));


            TimeSpanExample.Run();

        }
    }
}

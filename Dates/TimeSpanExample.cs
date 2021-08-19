using System;
namespace Dates
{
    public class TimeSpanExample
    {
        public static void Run()
        {
            //  Create 
            var timeSpan = new TimeSpan(1, 2, 3);
            System.Console.WriteLine("time span: " + timeSpan);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            System.Console.WriteLine("timeSpan 1: " + timeSpan1);

            var timeSpan2 = TimeSpan.FromHours(1);
            System.Console.WriteLine("timeSpan 2: " + timeSpan2);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            System.Console.WriteLine("End - Start Will Create a TimeSpan: (Duration) " + (end - start));

            // Properties
            System.Console.WriteLine("Minutes: " + timeSpan.Minutes);
            System.Console.WriteLine("TotalMinutes: " + timeSpan.TotalMinutes);

            // Add  and Subtract Method
            System.Console.WriteLine("Add 8 Minutes: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            System.Console.WriteLine("Subtract 3 Minutes  : " + timeSpan.Subtract(TimeSpan.FromMinutes(3)));

            // ToString
            System.Console.WriteLine("ToString :" + timeSpan.ToString);
        }
    }
}
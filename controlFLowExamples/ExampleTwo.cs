// 2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
using System;
namespace controlFLowExamples
{
    public class ExampleTwo
    {
        public static void Run (){
            var total = 0;
            while (true)
            {   
                // System.Console.WriteLine(System.Console.ReadLine());
                var input = Console.ReadLine();
                if (input == "ok" || input == "OK") {
                    System.Console.WriteLine(total);
                    break;
                }
                var IntInput = Convert.ToInt32(input);

                total+=IntInput;                               
                
            }
        }
    }
}
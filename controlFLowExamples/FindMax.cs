// 3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

using System;
namespace controlFLowExamples

{
    public class FindMax
    {
        public static void Run (){

                var input = Console.ReadLine();
                var numbers = input.Split(',');
                var max = Convert.ToInt32(numbers[0]);

                foreach (var str in numbers)
                {
                    var number = Convert.ToInt32(str);
                    if (number > max)   
                    {
                        max = number;
                    }

                }
                System.Console.WriteLine("Max is "+max);
        }
    }
}
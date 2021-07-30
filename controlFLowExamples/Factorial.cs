// 3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

using System;
namespace controlFLowExamples

{
    public class Factorial
    {
        public static void Run (){

                var result = 1;          
                var input = Console.ReadLine();
                var fact = Convert.ToInt32(input);
                for (var i = 1; i <= fact; i++)
                {
                    result *= i;
                }
                System.Console.WriteLine(result);    
        }
    }
}
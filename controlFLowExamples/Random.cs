// 4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)


using System;
using System.IO;

namespace controlFLowExamples

{
    public class Random
    {
        public static void Run (){
            var number = new Random.Next(1,10);
            System.Console.WriteLine(number);
        }
    }
}
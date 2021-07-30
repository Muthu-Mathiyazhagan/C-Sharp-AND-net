// 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.


namespace controlFLowExamples
{
    public class ExampleOne
    {
        public static void Run (){
            var count = 0;
           for (var i = 0; i < 100; i++)
           {
               if(i%3==0) count++;

           }
           System.Console.WriteLine("count of numbers between 1 and 100 are divisible by 3 with no remainder: "+count);

        }
    }
}
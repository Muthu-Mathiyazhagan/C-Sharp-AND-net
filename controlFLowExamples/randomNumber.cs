using System;
using System.IO;


namespace controlFLowExamples
{
    class randonNumber
    {
       public static void Run()
        {
            Console.WriteLine("Muthu is the best Fulstack Developer!");
            Random rand = new Random();
            var guess = rand.Next(1,10);
            System.Console.WriteLine(guess);

            System.Console.WriteLine("Type the Guess Number");
            for (int i = 0; i < 4; i++)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == guess)
                {
                    System.Console.WriteLine("You Won ! ");
                    break;
                }else
                {
                    System.Console.WriteLine("You Lost !");
                }

            }


                    
        }
    }
}

using System;


namespace ConditionFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Muthu is the Best Fullstack Developer!");
            var x =10;
            var y = 10;
            // "(x>y)?" === if(x>y) and ":" === else and ": (x<y)?" === elseif(x<y)
            var result  = (x>y)? "X is Greater than Y" : (x<y) ? "Y is Greater than X": "X is Equal to Y";
            System.Console.WriteLine(result);
            System.Console.WriteLine("Below Results for Enum and Switch cases");
            var season = Season.Summer;

            switch (season)
            {
                case Season.Autumn:
                    System.Console.WriteLine("This is Autumn");
                    break;

                case Season.Summer:
                case Season.Winter:
                    System.Console.WriteLine("This Block of Code will run for both Summer and Winter");
                    break;

                default:
                System.Console.WriteLine("Better Luck Next Time");
                    break;
            }
            

        }
    }
}

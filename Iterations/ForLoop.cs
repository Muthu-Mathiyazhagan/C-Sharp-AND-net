namespace Iterations
{
    public class ForLoop
    {
        public static void Examples (){
            for (var i = 1; i < 11; i++)
            {
                if (i%2==0) System.Console.WriteLine(i);
                
            }
            for (var j = 11; j > 1; j--) 
            {
                if (j%2==0) System.Console.WriteLine(j);
            }
        }
    }
}
namespace Iterations
{
    public class WhileLoop
    {
        public static void Even(){
            System.Console.WriteLine("Below Results for WhileLoop.Even();");        
            var i = 1;
            while (i<11)
            {
                if (i%2==0) {

                    System.Console.WriteLine(i);
                    
                    }i++;
                
            }


        }
       
    }
}
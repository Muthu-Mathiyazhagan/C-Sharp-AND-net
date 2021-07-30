using System;

namespace roughNote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var testCases = Convert.ToInt32(Console.ReadLine()); 
            String string = new String[];  
            // string [] string;      
            for(var i=0;i<testCases;i++){
            // System.Console.WriteLine(i); 
            var single = Console.ReadLine();
            // Run(single);    
            string[i] = single;       
            
        }
        System.Console.WriteLine(string);


        }

        public static void Run (string single){
            System.Console.WriteLine(single);
            System.Console.WriteLine(single.Length);

            // for(var i=0;i>single.Length;i++){
            //     System.Console.WriteLine(single[i]);
            // }
        }  
    }
}

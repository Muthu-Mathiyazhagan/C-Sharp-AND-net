using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var name = "Muthu";
            System.Console.WriteLine(name[0]);
            // name[0] = 'n';
            name = "Infinity";
            System.Console.WriteLine(name);
            //Type of Declarations of Strings
            var stringOne = "Hi\t";
            string stringTwo = "Muthu!\t";
            String stringThree = "How Are you?:\t";
            var fullString = stringOne + stringTwo + stringThree;
            var myFullString = string.Format("{0},{1},{2}",stringThree,stringTwo,stringOne);
            System.Console.WriteLine(stringOne+stringTwo+stringThree);
            var names = new string[3] {"Muthu","Mathi","Azhagan"};
            var formattedNames = string.Join("",names);
            System.Console.WriteLine("Formatted Strings: "+formattedNames);
            // For Int
            Int32 x = 25;
            int y = 35;
                System.Console.WriteLine(x*y);

            // Verbatim Strings
            var verbatimString = @"
            
            Hi, Muthu
            How     are     You ?
            *
            **
            ***
            **
            *
            ~/home/muthu/project/cSharpAndDotNet/Program.cs";
            System.Console.WriteLine(verbatimString);
            
        }
    }
}

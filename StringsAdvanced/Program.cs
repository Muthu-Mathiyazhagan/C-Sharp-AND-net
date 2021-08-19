using System;

namespace StringsAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string s1 = "Muthu"; //creating string using string keyword  
            String s2 = "Mathiyazhagan"; //creating string using String Class  
            var combined = s1 + " @ " + s2;
            System.Console.WriteLine(combined);
            char[] ch = { 'c', 's', 'h', 'a', 'r', 'p' };
            var s3 = new string(ch);
            char[] ch2 = { 'c', 's', 'h', 'a', 'r', 'p', 's' };
            var s4 = new String(ch2);
            System.Console.WriteLine(s4 + "\n" + s3);
            System.Console.WriteLine("Index of 'a': " + s4.IndexOf('a'));

            s4 = s4.ToUpper();
            System.Console.WriteLine("ToUpper(): " + s4);

            var s5 = "1234";
            var s6 = Convert.ToInt32(s5);
            System.Console.WriteLine("Converted to int: " + s6);

        }
    }
}

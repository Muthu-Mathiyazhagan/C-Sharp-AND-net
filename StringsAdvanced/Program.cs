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

            // Full name to FirstName and lastName
            // Apporach One
            var fullName = "Muthu Mathiyazhagan";
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index);
            System.Console.WriteLine("First name: " + firstName);
            System.Console.WriteLine("Last name: " + lastName);

            // Approch two
            var names = fullName.Split(' ');
            System.Console.WriteLine("First Name : {0}\nLast Name: {1}", names[0], names[1]);

            // Trim 
            var name = "Muthu ";
            System.Console.WriteLine("Trimed name is '{0}'", name.Trim());

            var str = "25";
            var age = Convert.ToSByte(str);
            System.Console.WriteLine(age);

            float price = 29.95F;
            System.Console.WriteLine("Effects Of 'c' :" + price.ToString("c"));
            System.Console.WriteLine("Effects of 'c0'" + price.ToString("c0"));
            // Null OR Empty OR Whitespace
            if (String.IsNullOrWhiteSpace(""))
            {
                System.Console.WriteLine("Invalid");
            }

            // String Replace
            System.Console.WriteLine(fullName.Replace("Mathiyazhagan", "Maravan"));




        }
    }
}

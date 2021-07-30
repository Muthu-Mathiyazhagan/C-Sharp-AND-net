using System;

namespace referenceNvalueTypes
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Muthu is the Best FullStack Developer!");
            // Value Types Copy the Data/ Duplicates :
            // It create and Destroyed in their scope Only
            int number = 10;
            Increment(number);
            System.Console.WriteLine(number);

            // Reference Type // Copy the Location address Not Value
            // Changing in one place Will Affect Globally
            var person = new Person(){Age = 20};
            MakeOld(person);
            System.Console.WriteLine(person.Age);
            // System.Console.WriteLine("Hello");
            ReferenceNValue_Types();

        }
        public static void Increment(int number)
        {   
            System.Console.WriteLine("Before Increment"+number);
            number+=10;
            System.Console.WriteLine("After Increment: "+number);

        }
        public static void MakeOld (Person person){
            person.Age +=10;           

        }
        public static void ReferenceNValue_Types (){
            // Value Type Examples
            int a = 10;
            int b = a;
            b++;
            System.Console.WriteLine(string.Format("a: {0}\t b:{0}",a,b));
            // Reference Type Examples
            var array1 = new int[3]{1,2,3};
            var array2 = array1;
            array2[0] = 7;
            System.Console.WriteLine(string.Format("array1[0]: {0}\tarray2[0]: {1}\n",array1[0],array2[0]));
        }
    }
}

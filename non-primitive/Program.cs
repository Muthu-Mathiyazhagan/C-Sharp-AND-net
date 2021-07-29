using System;
using non_primitive.Math;

namespace non_primitive
{
    public class Calc
    {
        public void Calculators (){
            var calc = new LocalCalculator();
            calc.FirstNumber = 6;
            calc.SecondNumber = 3;
            calc.Add();
            calc.Difference();
            calc.Multiplication();
        } 
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Person muthu = new Person();
            muthu.FirstName = "Muthu";
            muthu.LastName = "Mathiyazhagan";
            muthu.Introduce();
            Console.WriteLine("Hello World!");
            // Calc.Calculators();
            var calculator = new Calc();
            calculator.Calculators();
                    }
    }
}

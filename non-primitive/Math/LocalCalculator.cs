namespace non_primitive.Math
{
    public class LocalCalculator
    {
        public int FirstNumber;
        public int SecondNumber;

        public void Add()
        {
            System.Console.WriteLine("Addition Result: " + (FirstNumber + SecondNumber));
        }
        public void Difference()
        {
            System.Console.WriteLine("Difference between These Two Number: " + (System.Math.Abs(FirstNumber - SecondNumber)));
        }
        public void Multiplication()
        {
            System.Console.WriteLine("Multiplication Result: " + (FirstNumber * SecondNumber));
        }


    }
}
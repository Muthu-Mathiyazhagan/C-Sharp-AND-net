namespace Iterations
{
    public class ForEach
    {
        public static void Strings(string Name)
        {
            // for (var i = 0; i < parameter.Length; i++)
            // {
            //     System.Console.WriteLine(parameter[i]);
            // }
            //Similar to below

            foreach (var chars in Name)
            {
                System.Console.WriteLine(chars);
            }
        }

        public static void Arrays(int[] numbers)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine(numbers[i]);
            }
            System.Console.WriteLine("below results for Foreach for an integer Array");
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }
        }
    }
}
namespace Arrays
{
    public class SortFive
    {
        public static void Run()
        {
            System.Console.WriteLine("Enter Five Unique Numbers");
            var numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = System.Convert.ToInt32(System.Console.ReadLine());

            }
            System.Array.Reverse(numbers);
            // System.Console.WriteLine(ReversedArray);
            foreach (var item in numbers)
            {
                System.Console.Write("{0}  ", item);
            }
            System.Console.WriteLine("\n");
        }
    }
}
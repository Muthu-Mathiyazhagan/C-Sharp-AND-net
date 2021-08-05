namespace Arrays
{
    public class reverseName
    {
        public static void Run()
        {
            System.Console.WriteLine("Enter Your Name : ");
            var userName = System.Console.ReadLine();
            var array = new char[userName.Length];
            for (int i = userName.Length; i > 0; i--)
            {
                array[userName.Length - i] = userName[i - 1];
            }
            var reversed = new string(array);
            System.Console.WriteLine("Reversed Name : " + reversed);
        }
    }
}
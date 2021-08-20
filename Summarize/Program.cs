using System;

namespace Summarize
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var sentence = "This is the really big text with focused of the day india of kanniseri pudhur";
            var summary = StringUtility.SummarizeText(sentence, 40);
            System.Console.WriteLine(summary);
        }
    }
}

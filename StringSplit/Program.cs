using System;

namespace StringSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "I just wanna feel alive.";

            string[] subText = text.Split(' ');

            foreach (var  sub in subText)
            {
                Console.Write($"\n\nSubstring: {sub}");
            }
        }
    }
}

using System;

namespace TestMaximum
{
    internal class TestMaximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TC-1.1");
            string MaximumString = MaxString.FindMaxString("hello", "hi", "hey");
            Console.WriteLine(MaximumString);
            Console.WriteLine("TC-1.2");
            MaximumString = MaxString.FindMaxString("good morning", "good aternoon", "good night");
            Console.WriteLine(MaximumString);
            Console.WriteLine("TC-1.3");
            MaximumString = MaxString.FindMaxString("bye", "good bye", "take care");
            Console.WriteLine(MaximumString);
        }
    }
}
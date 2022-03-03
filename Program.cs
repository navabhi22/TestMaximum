using System;

namespace TestMaximum
{
    internal class TestMaximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TC-1.1");
            int MaxInt = MaxInteger.FindMaxInteger(78, 45, 12);
            Console.WriteLine(MaxInt);
            Console.WriteLine("TC-1.2");
            MaxInt = MaxInteger.FindMaxInteger(23, 38, 12);
            Console.WriteLine(MaxInt);
            Console.WriteLine("TC-1.3");
            MaxInt = MaxInteger.FindMaxInteger(23, 45, 66);
            Console.WriteLine(MaxInt);

        }
    }
}
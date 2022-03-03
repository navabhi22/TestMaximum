using System;

namespace TestMaximum
{
    internal class TestMaximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TC-1.1");
            double MaximumFloat = MaxFloat.FindMaxFloat(24.89, 24.877, 23.355);
            Console.WriteLine(MaximumFloat);
            Console.WriteLine("TC-1.2");
            MaximumFloat = MaxFloat.FindMaxFloat(19.459, 19.877, 19.002);
            Console.WriteLine(MaximumFloat);
            Console.WriteLine("TC-1.3");
            MaximumFloat = MaxFloat.FindMaxFloat(19.959, 19.377, 20.002);
            Console.WriteLine(MaximumFloat);
        }
    }
}
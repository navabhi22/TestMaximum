using System;

namespace TestMaximum
{
    internal class TestMaximum
    {
        static void Main(string[] args)
        {
            GenericMaximum<int> MaxInt = new GenericMaximum<int>(63, 45, 34);
            int maxValue = MaxInt.MaxMethod();
            Console.WriteLine(maxValue);
            Console.WriteLine("-----------");
            GenericMaximum<double> MaxDouble = new GenericMaximum<double>(19.003, 19.1, 19.00003);
            double maxDouble = MaxDouble.MaxMethod();
            Console.WriteLine(maxDouble);
            Console.WriteLine("-----------");
            GenericMaximum<string> MaxString = new GenericMaximum<string>("hello", "hi", "good bye");
            string MaxValue = MaxString.MaxMethod();
            Console.WriteLine(MaxString);
        }
    }
}
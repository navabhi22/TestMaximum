using System;

namespace TestMaximum
{
    internal class TestMaximum
    {
        static void Main(string[] args)
        {
            int[] arr = { 54, 63, 56, 65, 45 };
            MaxBySort<int> genericInt = new MaxBySort<int>(arr);
            genericInt.PrintMaxValue();

            double[] floatArr = { 54.88343, 54.3435, 55.000001, 54.333333, 54.333334 };
            MaxBySort<double> genericFloat = new MaxBySort<double>(floatArr);
            genericFloat.PrintMaxValue();

            string[] strArr = { "hello", "hey", "hi", "bye", "goog evening" };
            MaxBySort<string> genericString = new MaxBySort<string>(strArr);
            genericString.PrintMaxValue();
        }
    }
}
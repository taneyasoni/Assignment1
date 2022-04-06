using System;

namespace ParamIntegers
{
    public class Parameters
    {
        static void Main()
        {
            int result = SumOfIntegers(3, 9, 7, 1, 5);
            Console.WriteLine("Sum of Integers = {0}", result);
        }

        static int SumOfIntegers(params int[] integers)
        {
            int result1 = 0;
            foreach (int i in integers)
            {
                result1 += i;
            }
            return result1;
        }
    }
}
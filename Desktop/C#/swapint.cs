
using System;

namespace SwapIntegers
{
    public class MainSwap
    {
        static void Main()
        {
            MainSwap obj = new MainSwap();
            Console.WriteLine("Enter two values");
            int FValue = Convert.ToInt32(Console.ReadLine()); 
            int SValue = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("initial Values");
            obj.DisplayValues(FValue, SValue);
            obj.SwapValues(ref FValue, ref SValue);
            Console.WriteLine("Values after swap");
            obj.DisplayValues(FValue, SValue);
        }

        void SwapValues(ref int firstValue, ref int secondValue)
        {
            firstValue = firstValue + secondValue;
            secondValue = firstValue - secondValue; 
            firstValue = firstValue - secondValue; 
        }

        void DisplayValues(int firstValue, int secondValue)
        {
            Console.WriteLine("First Value = {0}\nSecond Value = {1}\n", firstValue, secondValue);
        }
    }
}
using System;

namespace ConsoleApp
{
    internal class SwapNumber
    {
        public void SwapNum(int num1, int num2)
        {
            int digit = (num1 % 10);
            num1 = (num2 % 10) + (num1 / 10) * 10;
            num2 = digit + (num2 / 10) * 10;

            Console.WriteLine("Num1 " + num1 + "\n" + "Num2 " + num2);
            AnotherSwap(num1, num2);
        }

        void AnotherSwap(int x, int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"Value 1 {x} Value 2 {y}");
        }
        public static void Main(string[] args)
        {
            SwapNumber sw = new SwapNumber();
            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            sw.SwapNum(num, num2);
        }
    }
}

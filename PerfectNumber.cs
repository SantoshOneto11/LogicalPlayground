using System;

namespace ConsoleApp
{
    internal class PerfectNumber
    {
        int sum = 0;
        public void CheckPerfect(int Num)
        {
            for (int i = 1; i < (Num / 2) + 1; i++)
            {
                if (Num % i == 0)
                {                  
                    sum += i;
                }
            }
            if (sum == Num)
            {
                Console.WriteLine("Perfect Num "+sum);
            }
            else
            {
                Console.WriteLine("NOT Perfect "+sum);
            }

        }

        //public static void Main(string[] args)
        //{
        //    PerfectNumber pr = new PerfectNumber();
        //    int value = Convert.ToInt32(Console.ReadLine());
        //    pr.CheckPerfect(value);
        //}
    }
}

using System;

public class SumEven
{
    static int[] value = { 5, 4, 1, 8, 12, 7, 8, 96, 5, 3, 1 };
    int sum = 0;
    int FindSum(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                sum += nums[i];
            }
        }
        return sum;
    }
    //public static void Main(string[] args)
    //{
    //    SumEven sumE = new SumEven();
    //    Console.WriteLine(sumE.FindSum(value));
    //}
}

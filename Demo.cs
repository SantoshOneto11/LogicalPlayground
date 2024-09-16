using System;

public class Demo
{
    bool status = true;
    bool CheckPalindrome(int value)
    {
        for (int i = 2; i < value; i++)
        {
            for (int j = 2; j < value; j++)
            {
                if (i % j == 0)
                {
                    status = false;
                }

                if (status)
                {
                    Console.WriteLine(j);
                }
            }
        }
        return status;
    }
    //public static void Main(string[] args)
    //{
    //    Demo demo = new Demo();
    //    int value = Convert.ToInt32(Console.ReadLine());

    //    Console.WriteLine(demo.CheckPalindrome(value));
    //}
}

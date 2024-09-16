using System;

namespace ConsoleApp
{
    internal class ArmstrongNum
    {
        int temp = 0;
        int index = 0;
        int sum = 0;
        public void CheckArmStrong(int num)
        {
            int count = num.ToString().Length;
            Console.WriteLine(count);
            temp = num;

            do
            {
                index = temp % 10;
                temp = temp / 10;
                int pow = (int)Math.Pow(index, count);

                sum += pow;
            } while (temp > 0);

            if (sum == num)
            {
                Console.WriteLine("Armstrong Num ->" + sum+"<-");
            }
            else
            {
                Console.WriteLine("Not Armstrong " + sum);
            }
        }

        //public static void Main(string[] args)
        //{
        //    ArmstrongNum arm = new ArmstrongNum();
        //    int value = Convert.ToInt32(Console.ReadLine());
        //    arm.CheckArmStrong(value);
        //}
    }
}

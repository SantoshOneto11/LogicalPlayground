using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class TablePrint
    {
        public void GetNumber(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num * i);
            }

        }

        //public static void Main(string[] args)
        //{
        //    TablePrint d = new TablePrint();
        //    int value = Convert.ToInt32(Console.ReadLine());
        //    d.GetNumber(value);
        //}
    }
}

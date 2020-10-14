using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_minSplit
{
    class Program
    {
        static int sum = 0;
        static int divisor1 = 50, divisor2 = 20, divisor3 = 10, divisor4 = 5, divisor5 = 1;
        static void Main(string[] args)
        {
            int result = minSplit(120);
            Console.ReadKey();
        }
        static int minSplit(int amount)
        {
            while (amount / divisor1 >= 1)
            {
                sum++;
                amount -= divisor1;
            }
            while (amount / divisor2 >= 1)
            {
                sum++;
                amount -= divisor2;
            }
            while (amount / divisor3 >= 1)
            {
                sum++;
                amount -= divisor3;
            }
            while (amount / divisor4 >= 1)
            {
                sum++;
                amount -= divisor4;
            }
            while (amount / divisor5 >= 1)
            {
                sum++;
                amount -= divisor5;
            }
            return sum;
        }
    }
}

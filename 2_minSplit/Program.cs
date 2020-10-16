using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_minSplit
{
    class Program
    {        
        static void Main(string[] args)
        {
            int amount = 116;

            Console.WriteLine("Amount = " + minSplit(amount));

            Console.ReadKey();
        }
        static int minSplit(int amount)
        {
            int[] array = new int[] { 50, 20, 10, 5, 1 };

            int count = 0;

            List<int> list = new List<int>(); //optional

            int number = 116;

            for (int i = 0; i < array.Length; i++)
            {

                while (number >= array[i])
                {
                    number = number - array[i];
                    count++;
                    list.Add(array[i]); //optional
                }
            }

            foreach (var item in list)
            { //optional
                Console.WriteLine(item);  //optional
            }  //optional
            Console.WriteLine(); //optional
            return count;
        }
    }
}

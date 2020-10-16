using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MaxElement
{
    class Program
    {        
            static void Main(string[] args)
            {
                int[] Array = new int[] { 10, -1, 0, 5, 9 };
                int minInteger = NotContains(Array);
                Console.WriteLine("Number = " + minInteger);
                Console.ReadKey();
            }
            private static int NotContains(int[] Array)
            {
                int minNumber = 0;
                for (int i = 1; i <= MaxElement(Array) + 1; i++)
                {
                    bool contains = false;
                    for (int j = 0; j < Array.Length; j++)
                    {
                        if (i == Array[j])
                            contains = true;
                    }
                    if (!contains)
                    {
                        minNumber = i;
                        break;
                    }
                }
                return minNumber;
            }
            private static int MaxElement(int[] Array)
            {
                int max = Array[0];
                for (int i = 0; i < Array.Length; i++)
                {
                    if (max < Math.Abs(Array[i]))
                        max = Math.Abs(Array[i]);
                }
                return max;
            }
        }
    }


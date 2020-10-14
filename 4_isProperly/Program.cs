using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_isProperly
{
    class Program
    {
        public static bool answer;
        static void Main(string[] args)
        {
            bool result = isProperly("(()())");
            Console.ReadLine();
        }
        static Boolean isProperly(String sequence)
        {
            for (int i = 0; i < (int)(sequence.Length / 2); i++)
            {
                if ((sequence[i] == '(' && sequence[sequence.Length - 1 - i] == ')') || ((sequence[i] == ')' && sequence[sequence.Length - 1 - i] == '(')))
                {
                    answer = true;
                }
                else
                {
                    return false;
                }
                return answer;
            }
        }
    }
}

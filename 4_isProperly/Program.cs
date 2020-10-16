using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_isProperly
{
    class Program
    {        
        static void Main(string[] args)
        {
            string sequence = "((a+b)*c)-(a-b)";
            bool checkResult = IsProperly(sequence);
            if (checkResult)
                Console.WriteLine("Brackets Correct!");
            else
                Console.WriteLine("Brackets Not Correct!");
            Console.ReadKey();
        }
        static Boolean IsProperly(String sequence)
        {
            int checkBrackets = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '(')
                    checkBrackets++;
                else if (sequence[i] == ')')
                    checkBrackets--;
            }
            if (checkBrackets == 0)
                return true;
            return false;
        }
    }
}

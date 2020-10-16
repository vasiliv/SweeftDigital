using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_isPalindrome
{
    class Program    {
        public static bool answer;

        static void Main(string[] args)
        {
            bool result = isPalindrome("abra");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static bool isPalindrome(String text)
        {
            
            for (int i = 0; i <  (int)text.Length/2; i++)
            {
                if (text[i] == text[text.Length - 1 - i])
                {
                    answer = true;
                }
                else
                {
                    return false;
                }
            }            
            return answer;
        }
    }
}

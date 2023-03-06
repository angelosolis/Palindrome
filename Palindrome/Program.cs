using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine().Replace(" ", "");
            bool isPalindrome = true;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine("The input is a palindrome.");
            }
            else
            {
                Console.WriteLine("The input is not a palindrome.");
            }
        }
    }
}

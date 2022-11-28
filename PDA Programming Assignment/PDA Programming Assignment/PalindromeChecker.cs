using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDA_Programming_Assignment
{
    public class PalindromeChecker : IStringChecker
    {
        public void CheckString(string input)
        {
            Stack<char> stack = new Stack<char>();
            int length = input.Length;
            int i, mid = length / 2;

            for (i = 0; i < mid; i++)
            {
                stack.Push(input[i]);
            }

            if (length % 2 != 0)
            {
                i++;
            }

            while (i < length)
            {
                char element = stack.Pop();
                if (element != input[i])
                {
                    Console.WriteLine("The inputted string is not a palindrome.");
                }
                else
                {
                    Console.WriteLine("The inputted string is a palindrome.");
                }
                i++;
            }
        }
    }
}

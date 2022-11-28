using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDA_Programming_Assignment
{
    public class BalancedSymbolChecker : IStringChecker
    {
        public void CheckString(string input)
        {
            Stack<char> stack = new Stack<char>();
            int length = input.Length;
            int stringNumber = 0;
            
            for(int i = 0; i < length; i++)
            {
                if(input[i].Equals('(') || input[i].Equals('{') || input[i].Equals('['))
                {
                    stack.Push(input[i]);
                }
                else if(input[i].Equals(')') || input[i].Equals('}') || input[i].Equals(']'))
                {
                    if (stack.Count == 0)
                    {
                        stringNumber++;
                        Console.WriteLine("The inputted string is not balanced.");
                    }
                    else
                    {
                        stack.Pop();
                        
                    }
                }
            }

            if (stack.Count > 0)
            {
                Console.WriteLine("The inputted string is not balanced.");
            }
            else if (stack.Count == 0 && stringNumber == 0)
            {
                Console.WriteLine("The inputted string is balanced.");
            }
            
        }
    }
}

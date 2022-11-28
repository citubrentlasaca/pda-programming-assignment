using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDA_Programming_Assignment
{
    public class BalancedSymbolChecker : IStringChecker
    {
        public bool isMatchingPair(char firstSymbol,  char secondSymbol)
        {
            if (firstSymbol == '(' && secondSymbol == ')')
                return true;
            else if (firstSymbol == '{' && secondSymbol == '}')
                return true;
            else if (firstSymbol == '[' && secondSymbol == ']')
                return true;
            else
                return false;
        }

        public void CheckString(string input)
        {
            Stack<char> stack = new Stack<char>();
            int length = input.Length;
            int stringNumber = 0;

            for (int i = 0; i < length; i++)
            {
                if (input[i].Equals('(') || input[i].Equals('{') || input[i].Equals('['))
                {
                    stack.Push(input[i]);
                }
                if (input[i].Equals(')') || input[i].Equals('}') || input[i].Equals(']'))
                {
                    if (stack.Count == 0)
                    {
                        stringNumber++;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{input} is not balanced.");
                        Console.ResetColor();
                        return;
                    }

                    else if (!isMatchingPair(stack.Pop(), input[i]))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{input} is not balanced.");
                        Console.ResetColor();
                        return;
                    }
                }
            }

            if (stack.Count == 0 && stringNumber == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{input} is balanced.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{input} is not balanced.");
                Console.ResetColor();
            }
        }
    }
}

using PDA_Programming_Assignment;

for(int i = 0; i < 6; i++)
{
    Console.Write("Enter string: ");
    string input = Console.ReadLine();
    Console.Write("String checker to use (P - Palindrome, B - Balanced Symbol): ");
    string checker = Console.ReadLine();

    StringInput str;
    if (checker.Equals("P"))
    {
        str = new StringInput(new PalindromeChecker());
        str.CheckString(input);
    }
    else if (checker.Equals("B"))
    {
        str = new StringInput(new BalancedSymbolChecker());
        str.CheckString(input);
    }
    else
    {
        throw new ArgumentException();
    }

    Console.WriteLine();
}

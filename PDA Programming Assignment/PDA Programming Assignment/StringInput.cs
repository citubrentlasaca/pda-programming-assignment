using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDA_Programming_Assignment
{
    public class StringInput
    {
        public IStringChecker _stringChecker;

        public StringInput(IStringChecker stringChecker)
        {
            _stringChecker = stringChecker;
        }

        public void CheckString(string input)
        {
            _stringChecker.CheckString(input);
        }
    }
}

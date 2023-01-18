using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class ReverseString
    {

        public string ReverseStringWithRecursion(string input)
        {
            if (input is string)
            {
                if (input.Length == 0)
                {
                    return input;
                }
                else
                {
                    return ReverseStringWithRecursion(input.Substring(1)) + input[0];
                }
            }
            else
            {
                throw new ArgumentException("Input must be a String!");
            }
        }
    }
}

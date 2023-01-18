using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class ReverseString:StringParser
    {

        public override string Manipulate(string input)
        {
            if (input is string)
            {
                if (input.Length == 0)
                {
                    return input;
                }
                else
                {
                    String reversed= Manipulate(input.Substring(1)) + input[0];
                    Console.WriteLine(reversed);
                    return reversed;
                }
            }
            else
            {
                throw new ArgumentException("Input must be a String!");
            }
        }
    }
}

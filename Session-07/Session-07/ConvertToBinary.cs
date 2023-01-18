using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class ConvertToBinary
    {
        public string BinaryConverter(string input)
        {
            decimal number;
            if(decimal.TryParse(input,out number))
            {
                string binary = "";
                int intNumber=(int)number;
                while(intNumber > 0)
                {
                    binary = (intNumber % 2) + binary;
                    intNumber /= 2;
                }
                return binary;
            }

            return "Invalid Input.";
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class SumAndDivisionOfTwoNumbers
    {
    
        int firstNumber = 10;
        int secondNumber = 2;
        
        public String sumOfTwoNumbers() {
            Console.WriteLine("//    Program Number  #2      //\n");
            int sum = firstNumber + secondNumber;
            String result = ("The Sum of " + firstNumber + " and " + secondNumber + " = " + sum);
            return result;
        }


        public String  divizionOfTwoNumbers()
        {
            int divizion=firstNumber / secondNumber;
            String result= ("The Divizion of " + firstNumber + " and " + secondNumber + " = " + divizion);
            return result;
        }
    }
}

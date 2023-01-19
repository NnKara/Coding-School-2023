﻿using System.Xml.XPath;

namespace CalculateOperations
{
    public class Calculation
    {
        public decimal Addition(decimal? value1,decimal? value2)
        {
            decimal result= 0;
            if(value1!=null && value2!=null)
            {
                result = value1.Value + value2.Value;
            }

            return result;
        }

        public decimal Division(decimal? value1,decimal? value2)
        {
            decimal result= 0;
            if(value1 != null && value2 != null)
            {
                result= value1.Value / value2.Value;
            }
            return result;
        }

        public decimal Subtraction(decimal? value1, decimal? value2)
        {
            decimal result = 0;
            if (value1 != null && value2 != null)
            {
                result = value1.Value - value2.Value;
            }
            return result;
        }

        public decimal Multiplication(decimal? value1, decimal? value2)
        {
            decimal result = 0;
            if (value1 != null && value2 != null)
            {
                result = value1.Value * value2.Value;
            }
            return result;
        }

        public decimal Power(decimal? value1, decimal? value2)
        {
            decimal result = 0;
            if (value1.HasValue && value2.HasValue)
            {
                decimal val1 = value1.Value;
                decimal val2 = value2.Value;
                result = (decimal)Math.Pow((double)val1, (double)val2);
            }
            return result;
        }

        public decimal SquareRoot(decimal? value1)
        {
            decimal result = 0;
            if (value1.HasValue)
            {
                double doubleVal=(double)value1.Value;
                double doubleResult = Math.Sqrt(doubleVal);
                result =(decimal) doubleResult;
                
            }
            return result;
        }




    }
}
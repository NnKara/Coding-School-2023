using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MultiplyValuesBetweenArrays
    {
        public void MultiplyArrayValues()
        {
            int[] array1= {2,4,9,12};
            int[] array2= {1,3,7,10};
            int[] resultArray= new int[array1.Length*array2.Length];
            int calcResult = 0;
            for(int i = 0; i < array1.Length; i++)
            {
                for(int j = 0; j < array2.Length; j++)
                {
                    calcResult = array1[i] * array2[j];
                    for(int e=0; e<resultArray.Length; e++)
                    {
                        resultArray.SetValue(calcResult,e);                        
                    }
                    Console.WriteLine(calcResult);
                }
            }          
        }
    }
}

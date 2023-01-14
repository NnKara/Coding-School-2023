using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class SortGivenArray
    {
        public void SortArrayByHand()
        {
            int[] array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            int temp = 0;
            for(int i=0;i<array.Length;i++)
            {
                for(int j=0;j<array.Length-i-1;j++)
                {
                    if (array[j] > array[j+1])
                    {
                        temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;  
                    }
                }
            }
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void SortWithLibrary()
        {
            int[] array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            Array.Sort(array);
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class PrimeNumbers
    {
        public void FindPrimeNumbers()
        {
            Console.WriteLine("Please enter an Integer: ");
            while (true)
            {

                int usersInput;
                if (!int.TryParse(Console.ReadLine(),out usersInput) || usersInput<0)
                {
                    Console.WriteLine("Invalid input.Re-Enter your |INTEGER| : ");
                }
                else
                {
                    for (int i = 1; i <= usersInput; i++)
                    {
                        int counter = 0;
                        for (int j = 2; j <=i/2 ; j++)
                        {
                            if (i % j == 0)
                            {
                                counter++;
                                break;
                            }
                        }
                        if (counter==0 && i!=1)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                }
            }
        }
    }
}

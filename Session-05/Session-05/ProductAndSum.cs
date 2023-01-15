﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ProductAndSum
    {

        public void SumAndProduct()
        {
            
            Console.WriteLine("Please enter an Integer: ");
            while (true)
            {
                
                String usersInput = Console.ReadLine();
                if (!int.TryParse(usersInput, out int givenNumber) || givenNumber<0)
                {
                    Console.WriteLine("Invalid input.Re-Enter your |INTEGER| : ");
                }
                else
                {
                    while (true)

                    {
                        Console.WriteLine("-Menu-\n" +
                                          "Press |1| to Sum your number with N values \n" +
                                          "Press |2| to get the Product of your number with N values");
                        string menusInput = Console.ReadLine();
                        if (!int.TryParse(menusInput, out int selection) || selection < 0 || selection > 2)
                        {
                            Console.WriteLine("Invalid input.Only 1|2 are acceptable. Re-Enter your option: ");                            
                        }
                        else
                        {
                            if (selection == 1)
                            {
                                int sum = 0;
                                for (int i = 0; i <= givenNumber; i++)
                                {
                                    //sum+=givenNumber+i;
                                    sum += i;
                                    
                                }
                                Console.WriteLine("Result: " + sum);
                                break;
                            }
                            else if (selection == 2)
                            {
                                int product = 1;
                                for (int i = 1; i <= givenNumber; i++)
                                {
                                    product *=i ;                                   
                                }
                                Console.WriteLine("Result: " + product);
                                break;
                            }                           
                        }                        
                    }
                    break;
                }
            }

        }
    }
}

    


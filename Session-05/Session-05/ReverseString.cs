using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ReverseString
    {
    
        public void ReverseWithLibrary()
        {
            
            Console.WriteLine("Enter your String: ");
            String givenString = Console.ReadLine();

            char[] stringsCharacters = givenString.ToCharArray();
            Array.Reverse(stringsCharacters);
            String reversedString = new string(stringsCharacters);
            Console.WriteLine("Reversed String :"+reversedString);                    
        }


        public void ReverseByHand()
        {
            Console.WriteLine("Enter your String: ");
            String givenString = Console.ReadLine();
            String reversedString = "";
            for(int i=givenString.Length-1;i>=0; i--)
            {
                reversedString += givenString[i];
            }
            Console.WriteLine("Reversed String: " + reversedString);
        }



    }
}
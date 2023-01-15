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
            StringBuilder sb= new StringBuilder();
            Console.WriteLine("Enter your String: ");
            String usersInput=Console.ReadLine();
            char[] stringsCharacters = usersInput.ToCharArray();
            Array.Reverse(stringsCharacters);
            String reversedString = new string(stringsCharacters);
            Console.WriteLine("Reversed String: "+reversedString);            
        }


        public void ReverseByHand()
        {
            StringBuilder stringBuilder= new StringBuilder();   
            Console.WriteLine("Enter your String: ");
            String givenString = Console.ReadLine();
            
            for(int i=givenString.Length-1;i>=0; i--)
            {
                stringBuilder.Append(givenString[i]);
            }
            Console.WriteLine(stringBuilder);           
        }

    }
}
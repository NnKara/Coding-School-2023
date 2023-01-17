using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class ActionResolver
    {
        public ActionRequest Request;

        public MessageLogger Logger { get; set; }

        public ActionResolver() { }

        public ActionResolver(ActionRequest request)
        {
            Request = request;
        }

        
        public ActionResolver(ActionRequest request,MessageLogger logger)
        {
            Request= request;
            Logger= logger;
        }

        public ActionResponse Execute(ActionRequest actionRequest)
        {
            ActionResponse response = new ActionResponse();
            switch (actionRequest.Action)
            {
                case ActionEnum.Convert:
                    Console.WriteLine("Please enter a decimal Number: ");
                    String? usersInput = Console.ReadLine();
                    int decimalNumber;
                    if (int.TryParse(usersInput, out decimalNumber))
                    {
                        string binary = Convert(decimalNumber);
                        Console.WriteLine("Binary representation of {0} is {1}", decimalNumber, binary);
                        response.Output = binary;
                    }
                    else
                    {

                        Console.WriteLine("Invalid input.Please enter a decimal number.");
                    }
                    break;


                case ActionEnum.Uppercase:
                    Console.WriteLine("Please enter your String: ");
                    string? input = Console.ReadLine();
                    string result=Uppercase(input);
                    response.Output = result;
                    break;


                case ActionEnum.Reverse:
                    Console.WriteLine("Enter a String: ");
                    var inputString = Console.ReadLine();
                    if (inputString is string)
                    {
                        var reversedString = Reverse(inputString);
                        response.Output = reversedString;
                    }
                    else
                    {
                        String fail = "Input is not a string.";
                        response.Output= fail;
                    }
                    break;
            }

        }

        public string Convert(int decimalNumber)
        {
            string binaryNumber = "";
            while (decimalNumber > 0)
            {
                binaryNumber = (decimalNumber % 2) + binaryNumber;
                decimalNumber = decimalNumber / 2;
            }
            return binaryNumber;
        }



        public string Uppercase(String usersInput)
        {
            if (!string.IsNullOrEmpty(usersInput))
            {
                string[] characters = usersInput.Split("");
                string longestWord = "";
                foreach (string character in characters)
                {
                    if (character.Length > longestWord.Length)
                    {
                        longestWord = character;
                    }
                }
                string uppercaseWord = longestWord.ToUpper();
                Console.WriteLine("The longest word in the input string is: " + uppercaseWord);
                return uppercaseWord;
            }
            else
            {
                return "Input is empty";
            }
        }

        public String Reverse(String inputString)
        {
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

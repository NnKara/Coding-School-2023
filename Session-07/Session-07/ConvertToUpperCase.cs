using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class ConvertToUpperCase
    {
        public string UppercaseConverter(string input)
        {
            if (input.Contains(""))
            {
                string[] words = input.Split(' ');
                string longestWord = "";
                int maxLength = 0;

                for(int i=0; i < words.Length; i++)
                {
                    if (words[i].Length > maxLength)
                    {
                        longestWord = words[i];
                        maxLength = words[i].Length;
                    }
                }

               string upperLongestWord = longestWord.ToUpper();
                Console.WriteLine(upperLongestWord);
                return upperLongestWord;
            }
            else
            {
                return "Input is not a string with more than one word.";
            }
        }
    }
}

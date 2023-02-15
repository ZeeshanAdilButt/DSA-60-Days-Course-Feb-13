using System;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = " Count the  number of words in this string ";

            //TODO; trime

            input = input.Trim(); // tbd

            int wordCount = 0;
            bool WasPreviousCharacterAlphabet = true;
            bool WasPreviousCharacterWhitespace = true;

            
            for (int i = 0; i < input.Length; i++)
            {
                if ((WasPreviousCharacterAlphabet) && (input[i] == ' ' || i == input.Length - 1))
                {
                    wordCount++;
                }

                // if(input[i])

                //TODO : if condition which check if the current char is alphabvt , prev > under consideration
                // WasPreviousCharacterAlphabet = true;
                // else
                 // WasPreviousCharacterAlphabet = true;
            }
            Console.WriteLine("Word count: " + wordCount);
        }

        public static bool IsWhiteSpace(char charcter){
         
           if(charcter == ' ')
            return true;

            return false;

        }

        public static bool IsProperLetter(char charcter){
         
            if ((character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z'))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

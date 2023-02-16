using System.Globalization;

namespace Strings_Find_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Find the awesomes words in this string";
            string substringToFind = " awesome";

            int wordStartIndex = -1;
            int wordLength = substringToFind.Length;

            for (int i = 0; i < input.Length - wordLength + 1; i++)
            {
                if (input[i] == substringToFind[0])
                {
                    int j;
                    int foundChars = 0;

                    for (j = i; j < i + wordLength; j++)
                    {
                        if (input[j] != substringToFind[j - i])
                        {
                            break;
                        }

                        foundChars++;
                    }

                    if (foundChars == wordLength)
                    {
                        wordStartIndex = i;
                        break;
                    }
                }
            }

            if (wordStartIndex != -1)
            {
                Console.WriteLine($"Found '{substringToFind}' at index {wordStartIndex}.");
            }
            else
            {
                Console.WriteLine($"Could not find '{substringToFind}' in the input.");
            }


        }
    }
}
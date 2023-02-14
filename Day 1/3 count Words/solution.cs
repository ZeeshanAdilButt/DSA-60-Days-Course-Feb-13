using System;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = " Count the number of words in this string ";

            //TODO; trime

            input = input.Trim(); // 

            int wordCount = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ' || i == input.Length - 1)
                {
                    wordCount++;
                }
            }
            Console.WriteLine("Word count: " + wordCount);
        }
    }
}

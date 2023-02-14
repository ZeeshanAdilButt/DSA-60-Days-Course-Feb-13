#include <iostream>
#include <string>

int main()
{
    std::string input = "Count the number of words in this string";
    int wordCount = 0;
    for (int i = 0; i < input.length(); i++)
    {
        if (input[i] == ' ' || i == input.length() - 1)
        {
            wordCount++;
        }
    }
    std::cout << "Word count: " << wordCount << std::endl;
    return 0;
}

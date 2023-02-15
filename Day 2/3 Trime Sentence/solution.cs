public string TrimSentence(string sentence)
{
    int start = 0;
    int end = sentence.Length - 1;
    
    // Trim whitespace from the start of the sentence
    while (start < end && Char.IsWhiteSpace(sentence[start]))
    {
        start++;
    }
    
    // Trim whitespace from the end of the sentence
    while (end > start && Char.IsWhiteSpace(sentence[end]))
    {
        end--;
    }
    
    // Return the trimmed sentence
    return sentence.Substring(start, end - start + 1);
}

// write code to find median in array [1,2,3,4,5,6,7]
int[] arr = new int[1,2,3,4,5];
// find first index





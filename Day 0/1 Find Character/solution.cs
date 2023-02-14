int FindIndexOfChar(string s, char c) {
    for (int i = 0; i < s.Length; i++) {
        if (s[i] == c) return i;
    }
    return -1;
}


int FindSubstring(string s, string substringToFind ) {

    for (int i = 0; i < input.Length - substringLength + 1; i++)
            {
                int j = 0;
                for (; j < substringLength; j++)
                {
                    if (input[i + j] != substringToFind[j])
                    {
                        break;
                    }
                }
                if (j == substringLength)
                {
                    substringStartIndex = i;
                    break;
                }
            }
    return -1;
}


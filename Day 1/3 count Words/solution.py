input = "Count the number of words in this string"
wordCount = 0
for i in range(len(input)):
    if input[i] == ' ' or i == len(input) - 1:
        wordCount += 1
print("Word count: " + str(wordCount))



def is_character(character): # 'c'
    if (ord(character) >= 65 and ord(character) <= 90) or (ord(character) >= 97 and ord(character) <= 122):
        return True
    else:
        return False
    
#  In Python, the ord() function returns the Unicode code point of a given character as an integer.
# The Unicode standard assigns a unique number to each character, including those from different writing systems, and ord() maps a given character to its corresponding Unicode code point.
# For example, ord('A') returns 65, because 65 is the Unicode code point for the uppercase letter "A". Similarly, ord('a') returns 97, because 97 is the Unicode code point for the lowercase letter "a".

# Using ord() is particularly useful when working with non-ASCII characters or when dealing with text in different languages.

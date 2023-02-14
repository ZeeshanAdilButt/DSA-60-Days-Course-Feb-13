input = "Count the number of words in this string"
wordCount = 0
for i in range(len(input)):
    if input[i] == ' ' or i == len(input) - 1:
        wordCount += 1
print("Word count: " + str(wordCount))

def trim_sentence(sentence):
    start = 0
    end = len(sentence) - 1

    # Trim whitespace from the start of the sentence
    while start < end and sentence[start].isspace():
        start += 1

    # Trim whitespace from the end of the sentence
    while end > start and sentence[end].isspace():
        end -= 1

    # Return the trimmed sentence
    return sentence[start:end+1]
 



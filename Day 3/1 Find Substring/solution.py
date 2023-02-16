def find_word(input_str, word_to_find):
    word_length = len(word_to_find)
    word_start_index = -1

    for i in range(len(input_str) - word_length + 1):
        if input_str[i] == word_to_find[0]:
            j = i
            found_chars = 0

            while j < i + word_length and input_str[j] == word_to_find[j - i]:
                found_chars += 1
                j += 1

            if found_chars == word_length:
                word_start_index = i
                break

    if word_start_index != -1:
        print(f"Found '{word_to_find}' at index {word_start_index}.")
    else:
        print(f"Could not find '{word_to_find}' in the input.")

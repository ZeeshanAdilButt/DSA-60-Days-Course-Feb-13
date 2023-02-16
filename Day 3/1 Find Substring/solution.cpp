#include <iostream>
#include <string>

void find_word(const std::string& input_str, const std::string& word_to_find) {
  const int word_length = word_to_find.length();
  int word_start_index = -1;

  for (int i = 0; i < input_str.length() - word_length + 1; i++) {
    if (input_str[i] == word_to_find[0]) {
      int j = i;
      int found_chars = 0;

      while (j < i + word_length && input_str[j] == word_to_find[j - i]) {
        found_chars++;
        j++;
      }

      if (found_chars == word_length) {
        word_start_index = i;
        break;
      }
    }
  }

  if (word_start_index != -1) {
    std::cout << "Found '" << word_to_find << "' at index " << word_start_index << "." << std::endl;
  } else {
    std::cout << "Could not find '" << word_to_find << "' in the input." << std::endl;
  }
}

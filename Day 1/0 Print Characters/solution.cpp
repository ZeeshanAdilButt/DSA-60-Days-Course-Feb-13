#include <iostream>
#include <string>

int PrintCharactersInString(std::string word) {
  for (int i = 0; i < word.length(); i++) {
    std::cout << word[i] << std::endl;
  }
  return -1;
}

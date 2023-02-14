#include <iostream>
#include <string>
#include <vector>

int findCharcterInString(std::string word, char character) {
  for (int i = 0; i < word.length(); i++) {
    if (word[i] == character) {
      return i;
    }
  }
  return -1;
}

std::vector<int> findAllCharcterIndexesInString(std::string word, char character) {
  std::vector<int> indexes;
  for (int i = 0; i < word.length(); i++) {
    if (word[i] == character) {
      indexes.push_back(i);
    }
  }
  return indexes;
}

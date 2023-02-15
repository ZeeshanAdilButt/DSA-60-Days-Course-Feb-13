#include <string>
#include <algorithm>

std::string trim_sentence(std::string sentence) {
    auto start = sentence.begin();
    auto end = sentence.end() - 1;

    // Trim whitespace from the start of the sentence
    while (start < end && std::isspace(*start)) {
        start++;
    }

    // Trim whitespace from the end of the sentence
    while (end > start && std::isspace(*end)) {
        end--;
    }

    // Return the trimmed sentence
    return std::string(start, end + 1);
}

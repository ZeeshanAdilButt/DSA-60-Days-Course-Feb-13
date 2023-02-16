function trimSentence(sentence) {
  let start = 0;
  let end = sentence.length - 1;

  // Trim whitespace from the start of the sentence
  while (start < end && /\s/.test(sentence[start])) {
      start++;
  }

  // Trim whitespace from the end of the sentence
  while (end > start && /\s/.test(sentence[end])) {
      end--;
  }

  // Return the trimmed sentence
  return sentence.substring(start, end + 1);
}

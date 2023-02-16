function findWord(input, wordToFind) {
    const wordLength = wordToFind.length;
    let wordStartIndex = -1;
  
    for (let i = 0; i < input.length - wordLength + 1; i++) {
      if (input[i] === wordToFind[0]) {
        let j = i;
        let foundChars = 0;
  
        while (j < i + wordLength && input[j] === wordToFind[j - i]) {
          foundChars++;
          j++;
        }
  
        if (foundChars === wordLength) {
          wordStartIndex = i;
          break;
        }
      }
    }
  
    if (wordStartIndex !== -1) {
      console.log(`Found '${wordToFind}' at index ${wordStartIndex}.`);
    } else {
      console.log(`Could not find '${wordToFind}' in the input.`);
    }
  }
  
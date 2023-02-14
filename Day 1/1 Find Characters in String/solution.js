function findCharcterInString(word, character) {
    for (let i = 0; i < word.length; i++) {
      if (word.charAt(i) == character) {
        return i;
      }
    }
    return -1;
  }
  
  function findAllCharcterIndexesInString(word, character) {
    const indexes = [];
    for (let i = 0; i < word.length; i++) {
      if (word.charAt(i) == character) {
        indexes.push(i);
      }
    }
    return indexes;
  }
  
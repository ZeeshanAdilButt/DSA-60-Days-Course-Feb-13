def findCharcterInString(word, character):
  for index, char in enumerate(word):
    if char == character:
      return index
  return -1

def findAllCharcterIndexesInString(word, character):
  indexes = []
  for index, char in enumerate(word):
    if char == character:
      indexes.append(index)
  return indexes

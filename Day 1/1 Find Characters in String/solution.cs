 public static int FindCharcterInString(string word, char character)
        {

            for (int index = 0; index < word.Length; index++)
            {
                
                if (word[index] == character)
                {

                    return index;
                }


            }

            return -1;
        }

        public static List<int> FindAllCharcterIndexesInString(string word, char character)
        {
            List<int> ints = new List<int>();

            for (int index = 0; index < word.Length; index++)
            {


                if (word[index] == character)
                {

                    ints.Add(index);
                }


            }

            return ints;
        }
public class Solution {
   public bool IsAlienSorted(string[] words, string order) {
    
    int[] charMap = new int[26];
    
    for (int i = 0; i < order.Length; i++) {
        charMap[order[i] - 'a'] = i;
    }

    for (int i = 0; i < words.Length - 1; i++) {

        string curr = words[i];
        string next = words[i + 1];

        int minLength = Math.Min(curr.Length, next.Length);

        for (int j = 0; j < minLength; j++) {
            
            if (curr[j] != next[j]) {
                if (charMap[curr[j] - 'a'] > charMap[next[j] - 'a']) {
                    return false;
                } else {
                    break;
                }
            }
            if (j == minLength - 1 && curr.Length > next.Length) {
                return false;
            }
        }
    }
    return true;
}

}
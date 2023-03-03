public class Solution {
    public string ReverseOnlyLetters(string s) {
    int left = 0, right = s.Length - 1;
    char[] chars = s.ToCharArray();

    while (left < right) {
        if (!Char.IsLetter(chars[left])) {
            left++;
        } else if (!Char.IsLetter(chars[right])) {
            right--;
        } else {
            char temp = chars[left];
            chars[left++] = chars[right];
            chars[right--] = temp;
        }
    }

    return new string(chars);
}

}
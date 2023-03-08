public class Solution {
    public IList<string> FizzBuzz(int n) {
        var result = new List<string>();

        if (n < 1) return result;

        for (int i = 1; i <= n; i++) {
            if (i % 3 == 0 && i % 5 == 0) {
                result.Add("FizzBuzz");
            } else if (i % 3 == 0) {
                result.Add("Fizz");
            } else if (i % 5 == 0) {
                result.Add("Buzz");
            } else {
                result.Add($"{i}");
            }
        }

        return result;
    }
}
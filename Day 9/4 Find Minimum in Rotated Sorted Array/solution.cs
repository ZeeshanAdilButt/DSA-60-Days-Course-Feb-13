public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        int low = 0, high = n - 1;

        // Perform a modified binary search to find the pivot
        while (low < high) {
            int mid = (low + high) / 2;
            
            if (nums[mid] > nums[high]) {
                low = mid + 1;
            } else {
                high = mid;
            }
        }

        // The element immediately following the pivot is the minimum element
        return nums[low];
    }
}

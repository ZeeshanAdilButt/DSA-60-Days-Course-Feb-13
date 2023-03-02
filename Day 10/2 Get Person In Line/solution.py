class Solution:
    def findMin(self, nums: List[int]) -> int:
        n = len(nums)
        low, high = 0, n-1
        
        # Perform a modified binary search to find the pivot
        while low < high:
            mid = (low + high) // 2
            if nums[mid] > nums[high]:
                low = mid + 1
            else:
                high = mid
        
        # The element immediately following the pivot is the minimum element
        return nums[low]

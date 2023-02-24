   def maxSubArray(self, nums: List[int]) -> int:
        maxSum = nums[0]
        currentMax = 0
        for i in range(len(nums)):
            if currentMax < 0:
                currentMax = nums[i]
            else:
                currentMax = nums[i] + currentMax
            if currentMax > maxSum:
                maxSum = currentMax
        return maxSum
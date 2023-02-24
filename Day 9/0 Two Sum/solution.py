class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        map = {}
        for i in range(len(nums)):
            requiredNum = target - nums[i]
            if requiredNum in map:
                return [map[requiredNum], i]
            if nums[i] not in map:
                map[nums[i]] = i
        return []

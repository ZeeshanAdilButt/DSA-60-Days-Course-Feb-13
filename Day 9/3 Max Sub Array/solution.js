function maxSubArray(nums) {
    let maxSum = nums[0];
    let currentMax = 0;
    for (let i = 0; i < nums.length; i++) {
        if (currentMax < 0) {
            currentMax = nums[i];
        } else {
            currentMax = nums[i] + currentMax;
        }
        if (currentMax > maxSum) {
            maxSum = currentMax;
        }
    }
    return maxSum;
}
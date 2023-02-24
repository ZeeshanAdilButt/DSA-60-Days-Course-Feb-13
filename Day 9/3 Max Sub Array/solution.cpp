class Solution {
public:
    int maxSubArray(vector<int>& nums) {
        int maxSum = nums[0];
        int currentMax = 0;
        for (int i =0; i < nums.size(); i++){
            if(currentMax < 0){
                currentMax = nums[i];
            } else{
                currentMax = nums[i] + currentMax ;
            }
            if(currentMax > maxSum)
                maxSum = currentMax;
        }
        return maxSum;
    }
};
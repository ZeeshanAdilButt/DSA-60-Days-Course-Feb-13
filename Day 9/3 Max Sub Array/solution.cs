public class Solution {
    public int MaxSubArray(int[] nums) {
        
        
        int maxSum = nums[0];

        int currentMax = 0;
        
        for (int i =0; i < nums.Length; i++){
            

            if(currentMax < 0){
                currentMax = nums[i]; // new story begins
            }
            else{
                currentMax = nums[i] + currentMax ; // take old friends with you
            }

            // // neagtive thingyyy
            // currentMax= Math.Max(nums[i], currentMax+nums[i]);
            
            if(currentMax>maxSum)
                maxSum = currentMax;
        }
        
        return maxSum;
        
    }
}
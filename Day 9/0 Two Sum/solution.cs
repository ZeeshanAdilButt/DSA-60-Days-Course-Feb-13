public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        //
        Dictionary<int,int> map =  new  Dictionary<int,int>();
            
            //   1
        for (int i=0; i<nums.Length; i++){
            
            // 2              9    -    7
            var requiredNum = target - nums[i];
            
            //if the required num is there in the map, return the indexes of curent num and required num
            if(map.ContainsKey(requiredNum)){

                return new int[]{map[requiredNum], i};
            }
            
            //adding to map
            if(!map.ContainsKey(nums[i])){
                map.Add(nums[i],i);   // 2 > 0 | 
            }
        }
        
        return new int[]{};
        
    }
} 
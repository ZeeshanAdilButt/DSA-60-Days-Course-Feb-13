public class Solution {
    public int MaxProfit(int[] prices) {
        
        int MaxProfit = 0;
        
        int buyTime = 0;
        
        for (int sellTime=1; sellTime< prices.Length; sellTime++){
            
            // low point > high pointer
            if(prices[buyTime] > prices[sellTime]){
                buyTime = sellTime; // this mean a lower buing price
            }
            
            MaxProfit = Math.Max(MaxProfit, prices[sellTime] - prices[buyTime]);
            
        }
        
        return MaxProfit;
    }
}
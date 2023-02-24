public class Solution {
    public int MaxProfit(int[] prices) {
        
        int MaxProfit = 0;
        
        int buyTime = 0;
        
        for (int sellTime=1; sellTime< prices.Length; sellTime++){
            
            //
            if(prices[buyTime] > prices[sellTime]){
                buyTime = sellTime;
            }
            
            MaxProfit = Math.Max(prices[sellTime] - prices[buyTime], MaxProfit);
            
        }
        
        return MaxProfit;
    }
}
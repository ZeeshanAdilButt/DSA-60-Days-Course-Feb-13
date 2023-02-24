class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int maxProfit = 0;
        int buyTime = 0;
        for (int sellTime = 1; sellTime < prices.size(); sellTime++) {
            if (prices[buyTime] > prices[sellTime]) {
                buyTime = sellTime;
            }
            maxProfit = max(maxProfit, prices[sellTime] - prices[buyTime]);
        }
        return maxProfit;
    }
};

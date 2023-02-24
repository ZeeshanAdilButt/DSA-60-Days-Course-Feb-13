var maxProfit = function(prices) {
    let maxProfit = 0;
    let buyTime = 0;
    for (let sellTime = 1; sellTime < prices.length; sellTime++) {
        if (prices[buyTime] > prices[sellTime]) {
            buyTime = sellTime;
        }
        maxProfit = Math.max(maxProfit, prices[sellTime] - prices[buyTime]);
    }
    return maxProfit;
};

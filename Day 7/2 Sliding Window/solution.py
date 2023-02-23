class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        max_profit = 0
        buy_time = 0
        for sell_time in range(1, len(prices)):
            if prices[buy_time] > prices[sell_time]:
                buy_time = sell_time
            max_profit = max(max_profit, prices[sell_time] - prices[buy_time])
        return max_profit

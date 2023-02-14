class Solution:
    def countPrimes(self, n: int) -> int:
        count = 0
        for i in range(2, n):
            if self.is_prime(i):
                count += 1
        return count
    
    def is_prime(self, n: int) -> bool:
        if n <= 1:
            return False
        for i in range(2, int(n ** 0.5) + 1):
            if n % i == 0:
                return False
        return True

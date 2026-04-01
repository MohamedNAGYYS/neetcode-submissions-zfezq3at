class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:

        dictionary = {}
        for current_number in nums:
            if current_number in dictionary:
                return True
            dictionary [current_number] = 1
        
        return False
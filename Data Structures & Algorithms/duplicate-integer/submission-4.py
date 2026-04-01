class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:

        nums = sorted(nums)
        for curr in range(len(nums) - 1):
            if nums[curr] == nums[curr+1]:
                return True

        return False
        
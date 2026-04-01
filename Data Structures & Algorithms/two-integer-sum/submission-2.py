class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        numbers = {}
        for i in range(len(nums)):
            difference = target - nums[i]
            if difference in numbers:
                return [numbers[difference], i]
            else:
                numbers[nums[i]] = i
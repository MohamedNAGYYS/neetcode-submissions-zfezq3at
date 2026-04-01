class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
            # [1,2,3,4]
        # Step 1: Get an integer array 
        # Step 2: Create prefix array
        prefix = []
        prefix.append(1)



        # Step 3: For through on nums or the parameter, and start at index 1
        for i in range(1, len(nums)):
            # Step 4: Append num *= from 0 to current num in nums ito prefix array
            prefix.append(nums[i-1] * prefix[-1])
    
    
        # Step 5: Create postfix array
        postfix = []
        postfix.append(1)
        
        
        
        # Step 7: For through on reversed nums
        for i in range(len(nums) - 2, -1, -1):
            # Step 8: Append num += from 0 to current num in rever nums into postfix array
            postfix.append(nums[i+1] * postfix[-1])

        postfix.reverse()
        # Step 9: Return postfix * prefix
        return [prefix[i] * postfix[i] for i in range(len(nums))]
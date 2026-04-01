class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        dictionary = {}
        for i in nums:
            if i not in dictionary:
                dictionary[i] = 0
            
            dictionary[i] += 1
        result = dict(sorted(dictionary.items(), key=lambda x: x[1], reverse=True))

        return list(result.keys())[:k]
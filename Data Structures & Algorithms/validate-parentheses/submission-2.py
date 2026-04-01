class Solution:
    def isValid(self, s: str) -> bool:
        open_brackets = []
        valid_brackets = {
            ']':'[',
            '}':'{',
            ')':'(',
        }


        for item in s:
            if item not in [')', '}', "]"]:
                open_brackets.append(item)
            else:
                if open_brackets and valid_brackets[item] == open_brackets[-1]:
                    open_brackets.pop()
                else:
                    return False
        
        if open_brackets:
            return False
        return True

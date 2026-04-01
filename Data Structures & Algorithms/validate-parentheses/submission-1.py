class Solution:
    def isValid(self, s: str) -> bool:
        open_brackets = []
        valid_brackets = ['()', '{}','[]']
        for item in s:
            if item not in [')', '}', "]"]:
                open_brackets.append(item)
            else:
                if open_brackets and ( open_brackets[-1] + item ) in valid_brackets:
                    open_brackets.pop()
                else:
                    return False
        
        if open_brackets:
            return False
        return True

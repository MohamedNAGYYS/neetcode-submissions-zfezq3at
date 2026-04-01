class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        stack=[]
        for item in tokens:
            if item.lstrip('-').isdigit():
                stack.append(int(item))
            else:
                if item in ['+','-','/','*']:
                    first=int(stack.pop())
                    sec=int(stack.pop())
                    if item =='+':
                        stack.append(sec + first)
                    elif item=='*':
                        stack.append(sec*first)
                    elif item=='/':
                        stack.append(int(sec/first))
                    else:
                        stack.append(sec-first)
        return int(stack[-1])
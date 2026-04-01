class MinStack:

    def __init__(self):
        self.stack=[]
        self.minimums=[]

    def push(self, val: int) -> None:
            if len(self.stack) == 0:
                self.stack.append(val)
                self.minimums.append(val)
            else:
                self.stack.append(val)
                if val < self.minimums[-1]:
                    self.minimums.append(val)
                else:
                    self.minimums.append(self.minimums[-1])

    def pop(self) -> None:
        if len(self.stack) > 0:
            self.stack.pop()
            self.minimums.pop()
        return None


    def top(self) -> int:
        if len(self.stack) > 0:
            return self.stack[-1]
        return None

    def getMin(self) -> int:
        if len(self.minimums) > 0:
            return self.minimums[-1]
        return None

        

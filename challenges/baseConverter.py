class Stack:
    def __init__(self):
        self.items = []

    def push(self, data):
        self.items.append(data)

    def isEmpty(self):
        return not self.items

    def size(self):
        return len(self.items)

    def peek(self):
        return self.items[1]

    def pop(self):
        return self.items.pop()


def baseConverter(decNumber, base):
    digits = "0123456789ABCDEF"

    remstack = Stack()

    while decNumber > 0:
        remander = decNumber % base
        remstack.push(remander)
        decNumber = decNumber // base

    newString = ''
    while not remstack.isEmpty():
        newString += digits[remstack.pop()]

    return newString


value = 26

print("bin of " + str(value) + ": ", baseConverter(value, 2))
print("oct of " + str(value) + ": ", baseConverter(value, 8))
print("hex of " + str(value) + ": ", baseConverter(value, 16))
"""
Python Data Structures - A Game-Based Approach
Queue class
Robin Andrews - https://compucademy.net/
"""

from asyncio import protocols
from collections import deque


class Queue:
    def __init__(self):
        self.items = deque()

    def is_empty(self):
        return not self.items
    
    def enqueue(self, item):
        self.items.append(item)

    def dequeue(self):
        return self.items.popleft()
    
    def size(self):
        return len(self.items)

    def peek(self):
        return self.items[0]
    
    def __str__(self):
        return str(self.items)

if __name__ == "__main__":
    q = Queue()
    q.enqueue(1)
    q.enqueue(2)
    q.enqueue(2)
    print(q.is_empty())
    print(q.peek())
    print(q.size())
    print(q)
    print(q.dequeue())
    print(q)
    print(q.size())

    print('\n----\n')

    q=Queue()
    q.enqueue("Learning")
    q.enqueue("with")
    q.dequeue()
    q.enqueue("Linked")
    q.enqueue("In")
    q.dequeue()
    print(q)

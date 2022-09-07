from collections import deque
import sys

class Queue:
    def __init__(self):
        self.items = deque()

    def is_empty(self):
        return not self.items
        # return len(self.items) == 0

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

class Node:
    def __init__(self, data):
        self.left = None
        self.right = None
        self.data = data

    def PrintTree(self):
        print(self.data)
        if (self.left != None):
            self.left.PrintTree()
        if (self.right != None):
            self.right.PrintTree()
        
    
    def PrintTreeLevels(self):
        if (self.left == None and self.right == None):
            print(self.data)
        current_level = Queue()
        next_level = Queue()
        current_level.enqueue(self)

        while not current_level.is_empty():
            value = current_level.dequeue()
            print(value.data)
            if current_level.is_empty():
                print("\n")
                
                while not next_level.is_empty():
                    current_level.enqueue(next_level.dequeue())

                if value.left != None:
                    current_level.enqueue(value.left)
                if value.right != None:
                    current_level.enqueue(value.right)
            else:
                if value.left != None:
                    next_level.enqueue(value.left)
                if value.right != None:
                    next_level.enqueue(value.right)

    def is_bst_rec(self, root, min_value, max_value):
        if root == None:
            return True

        if root.data < min_value or root.data > max_value:
            return False
        
        #      check if left root is bst                            check if right tree is bst
        return self.is_bst_rec(root.left, min_value, root.data) and self.is_bst_rec(root.right, root.data, max_value)

    def is_bst(self):
        return self.is_bst_rec(self, -sys.maxsize - 1, sys.maxsize)


if __name__ == "__main__":
    n100 = Node(100)
    n50 = Node(50)
    n200 = Node(200)
    n25 = Node(25)
    n75 = Node(75)
    n125 = Node(125)
    n350 = Node(350)
    #n351 = Node(351)
    n100.left = n50
    n100.right = n200
    n50.left = n25
    n50.right = n75
    n200.left = n125
    n200.right = n350
    #n350.left = n351
    #n100.PrintTree()
    print(n100.is_bst())
    n100.PrintTreeLevels()
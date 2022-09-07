class Node:
    def __init__(self, data):
        self.data = data
        self.left = None
        self.right = None

    def treeMax(self):
        if self is None:
            return float("-inf")
        else:
            leftMax = float("-inf")
            rightMax = float("-inf")
            if self.left:
                leftMax = self.left.treeMax()
            if self.right:
                rightMax = self.right.treeMax()
            return max(self.data, leftMax, rightMax)

    def search(self, target):
        current = self.data

        if target == current:
            return True

        if target < current and self.left:
            return self.left.search(target)

        if target > current and self.right:
            return self.right.search(target)

        return False

    def traversePreOrder(self):
        print(self.data)

        if self.left:
            self.left.traversePreOrder()

        if self.right:
            self.right.traversePreOrder()

    def minValue(self):
        if self is None:
            return float('inf')
        else:
            minLeft = float('inf')
            minRight = float('inf')
            if self.left:
                minLeft = self.left.minValue()
            if self.right:
                minRight = self.right.minValue()
            return min(self.data, minLeft, minRight)

    def traverseInOrder(self):
        if self.left:
            self.left.traverseInOrder()

        print(self.data)

        if self.right:
            self.right.traverseInOrder()

    def traversePostOrder(self):
        if self.left:
            self.left.traversePostOrder()

        if self.right:
            self.right.traversePostOrder()

        print(self.data)

    def height(self, h=0):
        leftHeight = self.left.height(h+1) if self.left else h
        rightHeight = self.right.height(h+1) if self.right else h
        return max(leftHeight, rightHeight)

    def getNodesAtDepth(self, depth, nodes=[]):
        if depth == 0:
            nodes.append(self.data)
            return nodes

        if self.left:
            self.left.getNodesAtDepth(depth-1, nodes)
        else:
            nodes.extend([None]*2**(depth-1))

        if self.right:
            self.right.getNodesAtDepth(depth-1, nodes)
        else:
            nodes.extend([None]*2**(depth-1))

        return nodes

    def printTree(self):
        i = 0
        h = self.height()
        while i <= h:

            nodes = self.getNodesAtDepth(i, [])
            string = ''
            for node in nodes:
                string += str(node) + " "
            i += 1

            print(string)


class Tree:
    def __init__(self, root, name=''):
        self.root = root
        self.name = name

    def search(self, target):
        return self.root.search(target)

    def traversePostOrder(self):
        return self.root.traversePostOrder()

    def traverseInOrder(self):
        return self.root.traverseInOrder()

    def traversePreOrder(self):
        return self.root.traversePreOrder()

    def height(self):
        return self.root.height()

    def getNodesAtDepth(self, depth):
        return self.root.getNodesAtDepth(depth)

    def printTree(self):
        self.root.printTree()

    def treeMax(self):
        return self.root.treeMax()
    def minValue(self):
        return self.root.minValue()


if __name__ == "__main__":
    node = Node(50)
    node.left = Node(25)
    node.right = Node(75)
    node.left.left = Node(13)
    node.left.right = Node(35)
    node.left.right.right = Node(37)
    node.right.left = Node(55)
    node.right.right = Node(103)
    node.left.left.left = Node(2)
    node.left.left.right = Node(20)
    node.right.left = Node(55)
    node.right.right.right = Node(256)

    tree = Tree(node, 'Depth Tree')

    # print(tree.getNodesAtDepth(3))
    tree.printTree()
    print("\nMax value: " + str(tree.treeMax()))
    print("\nMin value: " + str(tree.minValue()))

    # myTree = Tree(node, 'BST')

    # print(myTree.name + "\n")
    # print('search for 27')
    # print(myTree.search(27))
    # print('search for 28')
    # print(myTree.search(28))
    # print('search for 60')
    # print(myTree.search(60))
    # print('search for 61')
    # print(myTree.search(61))

    # myTree = Tree(node, 'Traversals')
    # print("InOrder")
    # print(myTree.traverseInOrder())
    # print("\nPostOrder")
    # print(myTree.traversePostOrder())
    # print("\nPreOrder")
    # print(myTree.traversePreOrder())

    # myTree = Tree(node, 'Height')
    # tree2 = Tree(Node(2))
    # print(myTree.height())
    # print(tree2.height())

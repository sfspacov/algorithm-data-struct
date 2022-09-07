def inOrder(root):
    if root.left:
        preOrder(root.left)

    print(root.info, end=" ")

    if root.right:
        preOrder(root.right)

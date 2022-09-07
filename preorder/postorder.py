def postOrder(root):
    if root.left:
        preOrder(root.left)

    if root.right:
        preOrder(root.right)

    print(root.info, end=" ")
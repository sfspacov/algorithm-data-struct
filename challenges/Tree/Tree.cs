class Tree
{
    public Tree()
    {

    }
    public Tree(Node root)
    {
        Root = root;
    }
    public Tree(int data)
    {
        Root = new Node(data);
    }
    public Node Root { get; set; }

    public void PrintPreOrder(Node root)
    {
        if (root == null)
            return;

        Console.Write(root.Data + " ");
        PrintPreOrder(root.Left);
        PrintPreOrder(root.Right);
    }

    public void PrintInOrder(Node root)
    {
        if (root == null)
            return;

        PrintInOrder(root.Left);
        Console.Write(root.Data + " ");
        PrintInOrder(root.Right);
    }

    public void PrintPostOrder(Node root)
    {
        if (root == null)
            return;

        PrintPostOrder(root.Left);
        PrintPostOrder(root.Right);
        Console.Write(root.Data + " ");
    }

    public int CountLevels(Node root)
    {
        var levels = 0;
        if (root == null) return levels;

        var current = new MyQueue<Node>(root);
        var next = new MyQueue<Node>();

        while (!current.IsEmpty())
        {
            var node = current.Dequeue();

            if (current.IsEmpty())
            {
                levels++;

                while (!next.IsEmpty())
                    current.Enqueue(next.Dequeue());

                if (node.Left != null)
                    current.Enqueue(node.Left);

                if (node.Right != null)
                    current.Enqueue(node.Right);
            }
            else
            {
                if (node.Left != null)
                    next.Enqueue(node.Left);

                if (node.Right != null)
                    next.Enqueue(node.Right);
            }
        }

        return levels;
    }

    public void PrintLevels(Node root)
    {
        if (root == null) return;

        var current = new MyQueue<Node>(root);
        var next = new MyQueue<Node>();

        while (!current.IsEmpty())
        {
            var node = current.Dequeue();
            Console.Write(node.Data + " ");

            if (current.IsEmpty())
            {
                Console.WriteLine();

                while (!next.IsEmpty())
                    current.Enqueue(next.Dequeue());

                if (node.Left != null)
                    current.Enqueue(node.Left);

                if (node.Right != null)
                    current.Enqueue(node.Right);
            }
            else
            {
                if (node.Left != null)
                    next.Enqueue(node.Left);

                if (node.Right != null)
                    next.Enqueue(node.Right);
            }
        }
    }

    public bool IsBinarySearch(Node root)
    {
        if (root == null)
            return true;

        if (root.Left?.Data >= root.Data || root.Right?.Data <= root.Data)
            return false;

        if (!IsBinarySearch(root.Left) || !IsBinarySearch(root.Right))
            return false;

        return true;
    }

    public Node Insert(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = Insert(root.Left, data);

        else if (data > root.Data)
            root.Right = Insert(root.Right, data);

        return root;
    }

    public bool Contains(Node root, int data)
    {
        if (root == null) return false;

        if (root.Data == data) return true;

        if (Contains(root.Left, data) || Contains(root.Right, data))
            return true;

        return false;
    }
    public int Size(Node root)
    {
        if (root == null)
            return 0;

        var left = Size(root.Left);
        var right = Size(root.Right);

        return 1 + left + right;
    }

    public void PrintPaths(Node node, int[] path, int pathLen)
    {
        if (node == null) return;

        // append this node to the path array
        path[pathLen++] = node.Data;

        // it's a leaf, so print the path that led to here
        if (node.Left == null && node.Right == null)
        {
            PrintArray(path, pathLen);
        }
        else
        {
            // otherwise try both subtrees
            PrintPaths(node.Left, path, pathLen);
            PrintPaths(node.Right, path, pathLen);
        }
    }

    void PrintArray(int[] ints, int len)
    {
        int i;
        for (i = 0; i < len; i++)
        {
            Console.WriteLine(ints[i]);
        }
        Console.WriteLine("\n");
    }



    public bool AreSimetric(Node root1, Node root2)
    {
        if (root1 == null && root2 == null)
            return true;

        else if ((root1 is null) != (root2 is null) || (root1.Data != root2.Data))
            return false;

        else
            return AreSimetric(root1.Left, root2.Right) && AreSimetric(root1.Right, root2.Left);
    }
}
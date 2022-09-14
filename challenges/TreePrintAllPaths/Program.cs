var tree = new Tree();
var root = new Node
{
    data = 1,
    left = new Node
    {
        data = 2,
        right = new Node
        {
            data = 9,
            right = new Node
            {
                data = -19,
                right = new Node
                {
                    data = 33
                }
            }
        }
    },
    right = new Node
    {
        data = 3,
        left = new Node
        {
            data = 8
        },
        right = new Node
        {
            data = 5
        }
    }
};

tree.Root = root;

Tree.PrintAllPaths(tree.Root, new int[5], 0);

class Node
{
    public int data;
    public Node left;
    public Node right;
}

class Tree
{
    public Node Root;

    public static void PrintAllPaths(Node node, int[] array, int index)
    {
        if (node == null)  return;

        array[index++] = node.data;

        if (node.left == null && node.right == null)
        {
            foreach (var data in array.Take(index))
                Console.WriteLine(data);
            Console.WriteLine();
        }
        else
        {
            PrintAllPaths(node.left, array, index);
            PrintAllPaths(node.right, array, index);
        }
    }
}
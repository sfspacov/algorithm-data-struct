class Node
{

    public Node()
    {

    }

    public Node(int data)
    {
        this.data = data;
    }
    public Node(int data, Node left, Node right)
    {
        this.data = data;
        this.left = left;
        this.right = right;
    }

    public Node(int data, Node child, bool isRight = false)
    {
        this.data = data;
        if (isRight)
            this.right = child;
        else
            this.left = child;
    }
    public int data;
    public Node left;
    public Node right;
    /*
          4					4
        /   \			   / \
       2     6			  2	  6
      / \   / \			 /   / \
    1    3 5   7		1   5   7
                                9
                                10
                              12  11
                              16
    */
    public void PrintPaths(Node node, List<int> list = null)
    {
        if (node == null)
            return;

        if (list == null)
            list = new List<int>();

        list.Add(node.data);
        var lastIndex = list.Count() - 1;
        if (node.left == null && node.right == null)
        {
            for (var i = 0; i <= lastIndex; i++)
            {
                Console.WriteLine(list[i]);
                if (i == lastIndex)
                    Console.WriteLine("-");
            }
            list.RemoveAt(lastIndex);
        }

        PrintPaths(node.left, list);

        PrintPaths(node.right, list);
    }

    /*
        [3,2,12] - print
        [3,2]
        [3]
    */
}
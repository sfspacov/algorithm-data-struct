var queries = new List<int> { 1, 1 };
var tree = new Node(1, new Node(2), new Node(3)); ;
var sn = SwapNodes(tree, queries);

foreach (var item in sn)
{
    foreach (var item2 in item)
    {
        Console.WriteLine(item2);
    }
    Console.WriteLine();
}
var queries2 = new List<int> { 2 };
var tree2 = new Node(1, new Node(2, null, new Node(4)), new Node(3, null, new Node(5))); ;
var sn2 = SwapNodes(tree2, queries2);
Console.WriteLine();
Console.WriteLine();

foreach (var item in sn2)
{
    foreach (var item2 in item)
    {
        Console.WriteLine(item2);
    }
    Console.WriteLine();
}

var queries3 = new List<int> { 2, 4 };
var tree3 = new Node(1,
new Node(2, new Node(4, new Node(6, null, new Node(9)), null), null),
new Node(3, new Node(5, new Node(7), new Node(8, new Node(10), new Node(11))), null)); ;
var sn3 = SwapNodes(tree3, queries3);
Console.WriteLine();
Console.WriteLine();

foreach (var item in sn3)
{
    foreach (var item2 in item)
    {
        Console.WriteLine(item2);
    }
    Console.WriteLine();
}


List<List<int>> SwapNodes(Node tree, List<int> queries)
{
    var result = new List<List<int>>();
    var level = 1;
    foreach (var query in queries)
    {
        var swappedTree = SwapNodesByLevel(tree, level, query);
        var inOrderArray = ReturnInOrder(swappedTree);
        result.Add(inOrderArray);
    }

    return result;
}

static List<int> ReturnInOrder(Node node, List<int> list = null)
{
    if (list == null)
        list = new List<int>();

    if (node == null)
        return list;

    ReturnInOrder(node.Left, list);
    list.Add(node.Data);
    ReturnInOrder(node.Right, list);

    return list;
}

static Node SwapNodesByLevel(Node node, int level, int query)
{
    if (node == null)
        return null;

    if (level % query == 0)
    {
        var temp = node.Left;
        node.Left = node.Right;
        node.Right = temp;
    }
    SwapNodesByLevel(node.Left, level + 1, query);
    SwapNodesByLevel(node.Right, level + 1, query);

    return node;
}

public class Node
{
    public Node(int data) => Data = data;
    public Node(int data, Node left, Node right)
    {
        Data = data;
        Right = right;
        Left = left;
    }
    public int Data { get; set; }
    public Node Right { get; set; }
    public Node Left { get; set; }
}
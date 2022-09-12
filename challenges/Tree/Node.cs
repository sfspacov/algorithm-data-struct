class Node
{
    public Node()
    {

    }
    public Node(int data)
    {
        Data = data;
    }
    public Node(int data, Node left, Node right)
    {
        Data = data;
        Left = left;
        Right = right;
    }
    public int Data { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
}
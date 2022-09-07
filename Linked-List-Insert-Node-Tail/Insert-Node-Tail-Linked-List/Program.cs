//141 --> null
//22

Node Loop(Node h, int d)
{
    var newNode = new Node(d);
    var current = h;

    if (h == null)
        return newNode;

    while (current.next != null)
        current = current.next;

    current.next = newNode;

    return h;
}

Node Recursive(Node head, int data)
{
    if (head == null)
        return new Node { data = data };

    head.next = Recursive(new Node { data = head.data }.next, data);

    return head;
}

var result = Loop(new Node { data = 144, next = new Node { data = 3 } }, 22);
while (result != null)
{
    Console.WriteLine(result.data);
    result = result.next;
}
public class Node
{
    public Node()
    {

    }
    public Node(int d)
    {
        data = d;
    }

    public Node(int d, Node n)
    {
        data = d;
        next = n;
    }
    public int data;
    public Node next;
}

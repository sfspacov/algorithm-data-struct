Node InsertNodeAfterValue(Node h, int d, int afterValue)
{
    var newNode = new Node(d);
    if (h == null || h.next == null) return newNode;
    var current = h;
    while (current != null)
    {
        if (current.data == afterValue)
        {
            var temp = current.next;
            current.next = newNode;
            newNode.next = temp;
            return h;
        }

        current = current.next;
    }

    return h;
}

var result = InsertNodeAfterValue(new Node(1, new Node(2, new Node(3, null))), 4, 1);
var current = result;
while (current != null)
{
    Console.Write(current.data + " -> ");
    current = current.next;
}
Console.Write("null");

Node InsertNodeAtPosition(Node llist, int data, int position)
{
    if (llist == null)
        return new Node { data = data };

    var current = llist;
    var previous = new Node();
    for (int i = 0; i < position; i++)
    {
        previous = current;
        current = current.next;
    }

    var newNode = new Node { data = data };
    previous.next = newNode;
    newNode.next = current;

    return llist;

}

// var result = InsertNodeAtPosition(new Node(16, new Node(13, new Node(7, null))), 1, 2);
// var current = result;
// while (current != null)
// {
//     Console.Write(current.data + " -> ");
//     current = current.next;
// }
// Console.Write("null");

public class Node
{
    public Node()
    {

    }

    public Node(int d)
    {
        data = d;
    }
    public Node(int data, Node next)
    {
        this.data = data;
        this.next = next;
    }
    public int data;
    public Node next;
}
var llist = new SinglyLinkedListNode(7, new SinglyLinkedListNode(1, new SinglyLinkedListNode(8,null)));

var newLlist = InsertNodeAtHead(llist, 5);

while (newLlist!=null){
    Console.WriteLine(newLlist.data+" -> ");
    newLlist = newLlist.next;
}

static Node InsertNodeAtHead(Node llist, int data)
{
    var newNode = new Node(data); //5
    if (llist == null)
        return newNode;

    var aux = llist; //7
    llist = newNode;
    newNode.next = aux;

    return llist;
}

public class Node
{
    public Node(int data)
    {
        this.data = data;
    }
    public Node(int data, Node next)
    {
        this.data = data;
        this.next=next;
    }
    public int data;
    public Node next;
}
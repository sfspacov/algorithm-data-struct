var headA = new Node(1)
{
    next = new Node(3)
    {
        next = new Node(7)
    }
};

var headB = new Node(1)
{
    next = new Node(2)
    {
        next = new Node(4)
    }
};

MergeLists(headA, headB);

static Node MergeLists(Node head1, Node head2)
{
    var dummy = new Node();
    var tail = dummy;

    while (head1 != null && head2 != null)
    {
        if (head1.data < head2.data)
        {
            tail.next = head1;
            head1 = head1.next;
        }
        else
        {
            tail.next = head2;
            head2 = head2.next;
        }
        tail = tail.next;
    }

    if (head1 != null)
        tail.next = head1;
    else if (head2 != null)
        tail.next = head2;

    return dummy.next;
}

class Node
{
    public Node()
    {

    }
    public Node(int data)
    {
        this.data = data;
    }
    public int data;
    public Node next;
}
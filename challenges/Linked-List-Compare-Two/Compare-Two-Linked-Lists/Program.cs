static bool CompareLists(Node head1, Node head2)
{
    var current1 = head1;
    var current2 = head2;

    while (current1 != null && current2 != null)
    {
        if (current1.Data != current2.Data)
        {
            return false;
        }
        current1 = current1.Next;
        current2 = current2.Next;
    }

    if (current1 == null && current2 != null || current1 != null && current2 == null)
    {
        return false;
    }

    return true;
}

Console.WriteLine(CompareLists(
    new SinglyLinkedListNode(1, new SinglyLinkedListNode(2, new SinglyLinkedListNode(3, null))), 
    new SinglyLinkedListNode(1, new SinglyLinkedListNode(2, new SinglyLinkedListNode(3, new SinglyLinkedListNode(4, null))))
    ));

Console.WriteLine(CompareLists(
    new SinglyLinkedListNode(1, new SinglyLinkedListNode(2, new SinglyLinkedListNode(3, null))),
    new SinglyLinkedListNode(1, new SinglyLinkedListNode(2, new SinglyLinkedListNode(3, null)))
    ));

Console.WriteLine(CompareLists(
    new SinglyLinkedListNode(2, new SinglyLinkedListNode(2, new SinglyLinkedListNode(3, null))),
    new SinglyLinkedListNode(1, new SinglyLinkedListNode(2, new SinglyLinkedListNode(3, null)))
    ));

public class Node
{
    public Node(int data, Node next)
    {
        Data = data;
        Next = next;
    }
    public int Data;
    public Node Next;
}
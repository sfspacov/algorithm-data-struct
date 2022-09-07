var head = new SinglyLinkedListNode(1);
var n2 = new SinglyLinkedListNode(2);
var n3 = new SinglyLinkedListNode(3);
var n4 = new SinglyLinkedListNode(4);
var n5 = new SinglyLinkedListNode(5);

head.next = n2;
n2.next = n3;
n3.next = n4;
n4.next = n5;
n5.next = n3;

static bool FloydCycle(SinglyLinkedListNode head)
{
    var slow = head;
    var fast = head;

    while (fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast.next;
        if (slow == fast)
            return true;
    }

    return false;
}

static bool HasCycleHash(SinglyLinkedListNode head)
{
    var current = head;
    var myHash = new HashSet<int>();
    if (current == null)
        return false;

    while (current != null)
    {
        if (myHash.Contains(current.data))
            return true;

        myHash.Add(current.data);

        current = current.next;
    }

    return false;
}

public class SinglyLinkedListNode
{
    public SinglyLinkedListNode(int data)
    {
        this.data = data;
    }
    public int data { get; set; }
    public SinglyLinkedListNode next { get; set; }
}

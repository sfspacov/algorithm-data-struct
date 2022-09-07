using System;

class MyLinkedList<T>
{

    public Node head;

    public class Node
    {
        public T data;
        public Node next;

        public Node(T data)
        {
            this.data = data;
        }
    }

    internal void DisplayContents()
    {
        Node current = head;

        while (current != null)
        {
            Console.Write($"{current.data} -->");
            current = current.next;
        }
        Console.WriteLine();
    }

    internal void DeleteBackHalf()
    {
        if (head == null || head.next == null)
        {
            head = null;
        }

        Node slow = head;
        Node fast = head;
        Node prev = null;

        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        prev.next = null;
    }
}
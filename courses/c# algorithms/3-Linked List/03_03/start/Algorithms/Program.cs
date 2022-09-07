using System;

namespace Algorithms
{
    class CustomLinkedList
    {
        public CustomLinkedList(Node head)
        {
            _head = head;
        }

        private Node _head;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
            }
        }

        void DeleteKthElement(int k)
        {

        }

        void DeleteBackHalf()
        {
            if (_head == null || _head.next == null)
            {
                _head = null;
            }

            Node slow = _head;
            Node fast = _head;
            Node prev = null;

            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            prev.next = null;
        }
        void DisplayContents()
        {
            Node current = _head;
            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new MyLinkedList<int>();
            var node1 = new MyLinkedList<int>.Node(3);
            var node2 = new MyLinkedList<int>.Node(4);
            var node3 = new MyLinkedList<int>.Node(5);
            var node4 = new MyLinkedList<int>.Node(6);
            linkedList.head = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            linkedList.DisplayContents();
            //linkedList.DeleteKthElement(1);
            linkedList.DeleteBackHalf();
            linkedList.DisplayContents();
        }
    }
}
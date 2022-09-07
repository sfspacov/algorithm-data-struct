using System;

namespace Algorithms {
    class CustomLinkedList {
        Node head;
        public class Node {
            public int data;
            public Node next;
            public Node(int d) { data = d; }
        }

        public void displayContents() {
            Node current = head;
            while(current != null) {
                Console.Write(current.data + "->");
                current = current.next;
            }
        }

        static void Main(string[] args) {
            CustomLinkedList linkedList = new CustomLinkedList();
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);

            linkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;
        }
    }
}
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Node rootNode = new Node(4);
            BynarySearchTree.Insert(rootNode, 12);
            BynarySearchTree.Insert(rootNode, 22);
            BynarySearchTree.Insert(rootNode, 3);
            BynarySearchTree.Insert(rootNode, 2);
            BynarySearchTree.Insert(rootNode, 1);
        }
        public class Node
        {
            public Node(int data)
            {
                Data = data;
            }
            public Node Right { get; set; }
            public Node Left { get; set; }
            public int Data { get; set; }
        }
        class BynarySearchTree
        {
            public static Node Insert(Node root, int data)
            {
                if (root == null)
                {
                    root = new Node(data);
                }
                else
                {
                    if (data > root.Data)
                        root.Right = Insert(root.Right, data);
                    else if(data < root.Data)
                        root.Left = Insert(root.Left, data);
                }

                return root;
            }
        }
    }

}
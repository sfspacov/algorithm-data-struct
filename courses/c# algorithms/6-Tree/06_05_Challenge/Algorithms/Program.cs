using System;

namespace Algorithms
{
    class Program
    {
        class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }

        class BinarySearchTree
        {
            public static Node Insert(Node root, int value)
            {
                if (root == null)
                {
                    root = new Node();
                    root.Data = value;
                }
                else if (value < root.Data)
                {
                    root.Left = Insert(root.Left, value);
                }
                else if (value > root.Data)
                {
                    root.Right = Insert(root.Right, value);
                }

                return root;
            }

            public static bool Contains(Node root, int data)
            {
                if (root == null)
                    return false;

                if (data < root.Data)
                    return Contains(root.Left, data);
                
                if (data > root.Data)
                    return Contains(root.Right, data);

                return true;
            }
        }
        /*
                            4
                    2               5
                1       3       6       7
        */
        static void Main(string[] args)
        {
            Node rootNode = new Node();
            rootNode.Data = 4;

            BinarySearchTree.Insert(rootNode, 1);
            BinarySearchTree.Insert(rootNode, 2);
            BinarySearchTree.Insert(rootNode, 3);
            BinarySearchTree.Insert(rootNode, 5);
            BinarySearchTree.Insert(rootNode, 7);
            BinarySearchTree.Insert(rootNode, 6);
            Console.WriteLine(BinarySearchTree.Contains(rootNode, -1));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 4));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 3));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 5));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 6));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 2));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 1));
        }
    }
}
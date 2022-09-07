using System;

/*
Inorder:
    Recursively visit left subtree, visit root, and recursively visit right subtree

Preorder:
    Visit the root, recursively visit the left subtree, and recursively visit the right subtree

Postorder:
    Recursively the left subtree, recursively the right subtree, and visit the root

*/
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

        class BinaryTree
        {
            public static void PreOrderTraversal(Node root)
            {
                if (root == null)
                    return;

                Console.Write(root.Data + " ");
                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }


            public static void InOrderTraversal(Node root)
            {
                if (root == null)
                    return;

                InOrderTraversal(root.Left);
                Console.Write(root.Data + " ");
                InOrderTraversal(root.Right);
            }

            public static void PostOrderTraversal(Node root)
            {
                if (root == null)
                    return;

                PostOrderTraversal(root.Left);
                PostOrderTraversal(root.Right);
                Console.Write(root.Data + " ");
            }
        }

        static void Main(string[] args)
        {

            //       4
            //    1     3
            //  8   9  6
            Node rootNode = new Node();
            rootNode.Data = 4;

            Node nodeOne = new Node();
            nodeOne.Data = 1;

            Node nodeThree = new Node();
            nodeThree.Data = 3;

            Node nodeEight = new Node();
            nodeEight.Data = 8;

            Node nodeNine = new Node();
            nodeNine.Data = 9;

            Node nodeSix = new Node();
            nodeSix.Data = 6;

            rootNode.Left = nodeOne;
            rootNode.Right = nodeThree;
            nodeOne.Left = nodeEight;
            nodeOne.Right = nodeNine;
            nodeThree.Left = nodeSix;
            
            //4 1 8 9 3 6
            Console.WriteLine("PreOrder");
            BinaryTree.PreOrderTraversal(rootNode);
            Console.WriteLine("\n");
            
            //8 1 9 4 3 6
            Console.WriteLine("InOrder");
            BinaryTree.InOrderTraversal(rootNode);
            Console.WriteLine("\n");
            
            //8 9 1 6 3 4
            Console.WriteLine("PostOrder");
            BinaryTree.PostOrderTraversal(rootNode);
        }
    }
}
var root = new Node(3);
root.Left = new Node(2);
root.Right = new Node(4);
root.Left.Left = new Node(12);
root.Left.Right = new Node(50);
root.Right.Right = new Node(18);
root.Right.Left = new Node(7);

// // /*
// //             3
// //     2                4
// // 12      50      7       18

// // */

// // var tree = new Tree(root);

// // //Root, Left, Rigt  - 3 2 12 50 4 7 18
// // Console.WriteLine("PreOrder");
// // tree.PrintPreOrder(tree.Root);
// // Console.WriteLine();
// // Console.WriteLine();

// // //Left, Root, Rigt  - 12 2 50 3 7 4 18
// // Console.WriteLine("InOrder");
// // tree.PrintInOrder(tree.Root);
// // Console.WriteLine();
// // Console.WriteLine();

// // //Left, Rigt, Root  - 12 50 2 7 18 4 3
// // Console.WriteLine("PostOrder");
// // tree.PrintPostOrder(tree.Root);
// // Console.WriteLine();
// // Console.WriteLine();

// // Console.WriteLine("Levels");
// // tree.PrintLevels(tree.Root);

// // Console.WriteLine("FALSE");
// // Console.WriteLine(tree.IsBinarySearch(tree.Root));

// // Console.WriteLine("TRUE");
// // Console.WriteLine(tree.IsBinarySearch(null));

// // Console.WriteLine("TRUE");
// // Console.WriteLine(tree.IsBinarySearch(new Node(2, new Node(1), new Node(3))));

var newTree = new Tree();
newTree.Root = newTree.Insert(newTree.Root, 5);
newTree.Root = newTree.Insert(newTree.Root, 2);
newTree.Root = newTree.Insert(newTree.Root, 7);
newTree.Root = newTree.Insert(newTree.Root, 1);
newTree.Root = newTree.Insert(newTree.Root, 9);
newTree.Root = newTree.Insert(newTree.Root, 6);
newTree.Root = newTree.Insert(newTree.Root, 3);
newTree.Root = newTree.Insert(newTree.Root, 11);
newTree.Root = newTree.Insert(newTree.Root, 0);
newTree.Root = newTree.Insert(newTree.Root, 8);
newTree.Root = newTree.Insert(newTree.Root, 10);
newTree.Root = newTree.Insert(newTree.Root, 4);
newTree.Root = newTree.Insert(newTree.Root, 104);
newTree.Root = newTree.Insert(newTree.Root, -4);
newTree.PrintPaths(root, new int[20], 0);
// // Console.WriteLine("InOrder");
// // newTree.PrintInOrder(newTree.Root);
// // Console.WriteLine();
// // Console.WriteLine();
// // Console.WriteLine("PreOrder");
// // newTree.PrintPreOrder(newTree.Root);
// // Console.WriteLine();
// // Console.WriteLine();
// // Console.WriteLine("PostOrder");
// // newTree.PrintPostOrder(newTree.Root);
// // Console.WriteLine();
// // Console.WriteLine();
// newTree.PrintLevels(newTree.Root);
// // var n = 110;
// // Console.Write("Contains " + n + ": ");
// // Console.WriteLine(newTree.Contains(newTree.Root, n));

// Console.WriteLine("This tree has " + newTree.CountLevels(newTree.Root) + " levels");
// Console.WriteLine("Size:  " + newTree.Size(newTree.Root));

// var tree = new Tree(new Node(3, new Node(1, new Node(22), new Node(4)), new Node(1, new Node(4), new Node(22))));

// Console.WriteLine(tree.AreSimetric(tree.Root.Left, tree.Root.Right));
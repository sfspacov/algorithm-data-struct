var tree =
new Node(4,
    new Node(2,
        new Node(1), new Node(3)),
    new Node(6,
        new Node(5), new Node(7)));
    /*
          4					4
        /   \			   / \
       2     6			  2	  6
      / \   / \			 /   / \
    1    3 5   7		1   5   7
                                9
                                10
                              12  11
                              16
    */
tree.PrintPaths(tree);
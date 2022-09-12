var graph = new Graph();
graph.Add(1, new int[] { 2, 3 });
graph.Add(2, new int[] { 4 });
graph.Add(3, new int[] { 5 });
graph.Add(4, new int[] { });
graph.Add(5, new int[] { });

graph.BreadthFirstSearch(1);
graph.DeepthFirstSearch(1);
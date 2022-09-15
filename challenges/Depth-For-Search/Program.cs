Dictionary<int, int[]> graph = new Dictionary<int, int[]>();
graph.Add(1, new int[] { 2, 3 ,8});
graph.Add(2, new int[] { 4, 5 });
graph.Add(3, new int[] { 6, 7 });
graph.Add(4, new int[] { });
graph.Add(5, new int[] { 8 });
graph.Add(6, new int[] { });
graph.Add(7, new int[] { });
graph.Add(8, new int[] { 9 });
graph.Add(9, new int[] { 10 });
graph.Add(10, new int[] { 11 });
graph.Add(11, new int[] { 12 });
graph.Add(12, new int[] { });

DeepthFirstSearch(graph, 1);

List<int> DeepthFirstSearch(Dictionary<int, int[]> graph, int start)
{
    var visited = new HashSet<int>();
    var stack = new Stack<int>();
    stack.Push(start);

    while (visited.Count <= graph.Count)
    {
        var current = stack.Pop();
        visited.Add(current);

		var nonVisitedVertices = (graph.First(x => x.Key == current).Value)
								 .Where(vertice => !visited.Contains(item));
		
		foreach (var vertice in nonVisitedVertices)
				stack.Push(vertice);     

        if (visited.Count == graph.Count)
            break;
    }

    return visited;
}
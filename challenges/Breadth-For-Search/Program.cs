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

BreadthFirstSearch(graph, 1);

List<int> BreadthFirstSearch(Dictionary<int, int[]> graph, int start)
{
    var visited = new List<int>();
    var queue = new Queue<int>();
    queue.Enqueue(start);

    while (visited.Count <= graph.Count)
    {
        var current = queue.Dequeue();
        visited.Add(current);

		var nonVisitedVertices = (graph.First(x => x.Key == current).Value)
						.Where(vertice => !visited.Contains(vertice);
						
        foreach (var vertice in nonVisitedVertices)                
                    queue.Enqueue(vertice);

        if (visited.Count == graph.Count)
            break;
    }

    return visited;
}
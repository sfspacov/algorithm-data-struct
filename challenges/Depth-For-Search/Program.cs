Dictionary<int, int[]> graph = new Dictionary<int, int[]>();
graph.Add(0, new int[] { 1, 2 });
graph.Add(1, new int[] { 0, 3, 4 });
graph.Add(2, new int[] { 0 });
graph.Add(3, new int[] { 1 });
graph.Add(4, new int[] { 2, 3 });

List<int> DFS(Dictionary<int, int[]> graph, int start, Stack<int> visited = null)
{
    if (visited == null)
        visited = new Stack<int>();

    visited.Push(start);

    Console.WriteLine(start);

    foreach (var next in graph
        .Where(x => x.Key == start && 
        visited.Contains(y => x.Value[0] != y))
    )
    {
        DFS()
    }
}
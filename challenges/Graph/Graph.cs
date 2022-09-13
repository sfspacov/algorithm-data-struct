class Graph
{
    public Dictionary<int, int[]> Nodes { get; set; }

    public Graph()
    {
        Nodes = new Dictionary<int, int[]>();
    }
    public Graph(Dictionary<int, int[]> nodes)
    {
        if (nodes == null)
            Nodes = new Dictionary<int, int[]>();
        else
            Nodes = nodes;
    }

    public void Add(int vertice, int[] edges)
    {
        Nodes.Add(vertice, edges);
    }

    public void AddRange(Dictionary<int, int[]> range)
    {
        Nodes = range;
    }

    public IEnumerable<int> BreadthFirstSearch(int startVertice)
    {
        Console.WriteLine("\nBreadth First Search (queue):");
        var queue = new Queue<int>();
        var visited = new HashSet<int>();
        queue.Enqueue(startVertice);

        while (queue.Any())
        {
            var nodeValue = queue.Dequeue();
            Console.WriteLine(nodeValue);
            visited.Add(nodeValue);

            var nonVisitedVertices = (Nodes.First(x => x.Key == nodeValue).Value)
									 .Where(x => !visited.Contains(x));

            foreach (var vertice in nonVisitedVertices)
                queue.Enqueue(vertice);

            if (Nodes.Count == visited.Count)
                break;
        }

        Console.WriteLine();
        return visited;
    }

    public IEnumerable<int> DeepthFirstSearch(int startVertice)
    {
        Console.WriteLine("\nDeepth First Search (stack):");
        var stack = new Stack<int>();
        var visited = new HashSet<int>();
        stack.Push(startVertice);

        while (stack.Any())
        {
            var nodeValue = stack.Pop();
            Console.WriteLine(nodeValue);
            visited.Add(nodeValue);

            var nonVisitedVertices = (Nodes.First(x => x.Key == nodeValue).Value)
									 .Where(x => !visited.Contains(x));

            foreach (var vertice in nonVisitedVertices)
                stack.Push(vertice);

            if (visited.Count == Nodes.Count)
                break;
        }

        Console.WriteLine();
        return visited;
    }
}
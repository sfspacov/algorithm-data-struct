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
            var currentNode = queue.Dequeue();
            Console.WriteLine(currentNode);
            visited.Add(currentNode);

            foreach (var vertice in Nodes.First(x => x.Key == currentNode).Value)
            {
                if (!visited.Contains(vertice))
                {
                    queue.Enqueue(vertice);
                }
            }


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
            var currentNode = stack.Pop();
            Console.WriteLine(currentNode);
            visited.Add(currentNode);

            foreach (var vertice in Nodes.First(x => x.Key == currentNode).Value)
            {
                if (!visited.Contains(vertice))
                {
                    stack.Push(vertice);
                }
            }

            if (visited.Count == Nodes.Count)
                break;
        }

        Console.WriteLine();
        return visited;
    }
}
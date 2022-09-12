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

            var vertices = new HashSet<int>(Nodes.First(x => x.Key == nodeValue).Value);

            if (vertices.Any())
            {
                vertices.ExceptWith(visited);

                foreach (var vertice in vertices)
                    queue.Enqueue(vertice);
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
            var nodeValue = stack.Pop();
            Console.WriteLine(nodeValue);
            visited.Add(nodeValue);

            var vertices = new HashSet<int>(Nodes.First(x => x.Key == nodeValue).Value);
            
            if (vertices.Any())
            {
                vertices.ExceptWith(visited);

                foreach (var vertice in vertices)
                    stack.Push(vertice);
            }

            if (visited.Count == Nodes.Count)
                break;
        }

        Console.WriteLine();
        return visited;
    }
}
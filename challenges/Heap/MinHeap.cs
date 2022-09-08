class MinHeap
{
    public MinHeap(IEnumerable<int> collection)
    {
        Items = new List<int>();
        Items.Add(0);

        foreach (var item in collection)
            Insert(item);
    }
    public MinHeap()
    {
        Items = new List<int>();
        Items.Add(0);
    }
    public IList<int> Items { get; private set; }
    public int Size { get { return Items.Count - 1; } }

    public void Print()
    {
        for (int i = 1; i <= Size; i++)
            Console.WriteLine(Items[i]);
    }
    public bool IsEmpyt()
    {
        return Size == 0;
    }
    public void Insert(int data)
    {
        Items.Add(data);
        for (var i = Size; i / 2 > 0; i /= 2)
            if (Items[i / 2] > Items[i])
            {
                var temp = Items[i / 2];
                Items[i / 2] = Items[i];
                Items[i] = temp;
            }
    }
    /// <summary>
    /// Return the minimum value of the tree (the root)
    /// </summary>
    /// <returns>Minimum item</returns>
    public int Get()
    {
        if (IsEmpyt())
            throw new Exception("The tree is empty");
        return Items[1];
    }

    private int ReturnLeft(int i)
    {
        return Items[1 + i * 2];
    }

    private int ReturnRight(int i)
    {
        return Items[2 + i * 2];
    }

    public void Delete(int? times = null)
    {
        if (times == 1) return;

        var nodeIndex = RemoveRoot();
        var originalSize = Size;
        var nextIndex = Items[nodeIndex * 2] < Items[nodeIndex * 2 + 1] ? nodeIndex * 2 : nodeIndex * 2 + 1;

        while (nodeIndex * 2 <= originalSize)
        {
            Swap(nodeIndex, nextIndex);
            if (nodeIndex * 2 <= originalSize)
                RecalculateIndexes(ref nodeIndex, ref nextIndex);
        }

        Delete(Size);
    }

    private void RecalculateIndexes(ref int nodeIndex, ref int nextIndex)
    {
        nodeIndex = nextIndex;
        nextIndex = nextIndex % 2 == 0 ? nodeIndex * 2 : nodeIndex * 2 + 1;
    }

    private void Swap(int nodeIndex, int nextIndex)
    {
        if (nextIndex <= Size && Items[nodeIndex] > Items[nextIndex])
        {
            var temp = Items[nextIndex];
            Items[nextIndex] = Items[nodeIndex];
            Items[nodeIndex] = temp;
        }
    }

    private int RemoveRoot()
    {
        var nodeIndex = 1;
        Items[nodeIndex] = Items[Items.Count - nodeIndex];
        Items.RemoveAt(Items.Count - nodeIndex);
        return nodeIndex;
    }

    public static bool IsMinHeap(IList<int> collection)
    {
        if (collection == null || !collection.Any()) return false;
        var size = collection.Count;
        if (size == 1) return true;

        for (int i = 0; i <= size / 2 && i * 2 + 1 < size; i++)
        {
            //Compare the node with the left child
            if (collection[i] >= collection[i * 2 + 1])
                return false;

            //Check if right node is allowed
            if (i * 2 + 2 >= size)
                return true;

            //Compare the node with the right child
            if (collection[i] >= collection[i * 2 + 2])
                return false;

        }

        return true;
    }
}
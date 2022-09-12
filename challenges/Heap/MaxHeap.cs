class MaxHeap
{
    public MaxHeap(IEnumerable<int> collection)
    {
        Items = new List<int>();

        foreach (var item in collection)
            Insert(item);
    }
    public MaxHeap()
    {
        Items = new List<int>();
    }
    public IList<int> Items { get; private set; }
    public int Size { get { return Items.Count; } }

    public void Print()
    {
        for (int i = 0; i < Size; i++)
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
        {
            var parentIndex = i / 2 - 1;
            var childIndex = i - 1;

            var parent = Items[parentIndex];
            var child = Items[i - 1];

            if (parent < child)
            {
                Items[parentIndex] = Items[childIndex];
                Items[childIndex] = parent;
            }
            else
            {
                break;
            }
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
        return Items[0];
    }

    public int Delete()
    {
        var deleted = Get();
        RemoveRoot();
        
        var originalSize = Size;
        var i = 0;
        var leftIndex = i + 1;
        var rightIndex = i + 2;

        while (rightIndex < originalSize)
        {
            if (Items[leftIndex] > Items[rightIndex])
            {
                Swap(i, leftIndex);
                i = i * 2 + 1;
            }
            else
            {
                Swap(i, rightIndex);
                i = i * 2 + 2;
            }

            leftIndex = i * 2 + 1;
            rightIndex = i * 2 + 2;
        }

        return deleted;
    }

    private void Swap(int nodeIndex, int childIndex)
    {
        if (childIndex < Size && Items[nodeIndex] < Items[childIndex])
        {
            var temp = Items[childIndex];
            Items[childIndex] = Items[nodeIndex];
            Items[nodeIndex] = temp;
        }
    }

    private void RemoveRoot()
    {
        Items[0] = Items[Size - 1];
        Items.RemoveAt(Size - 1);
    }

    public static bool IsMaxHeap(IList<int> collection)
    {
        if (collection == null || !collection.Any()) return false;
        var size = collection.Count;
        if (size == 1) return true;

        for (int i = 0; i <= size / 2 && i * 2 + 2 < size; i++)
        {
            var leftChild = collection[i * 2 + 1];
            var rightChild = collection[i * 2 + 2];
            var node = collection[i];
            //Compare the node with the left child
            if (node <= leftChild)
                return false;

            //Check if right node is allowed
            if (i * 2 + 2 >= size)
                return true;

            //Compare the node with the right child
            if (node <= rightChild)
                return false;

        }

        return true;
    }
}
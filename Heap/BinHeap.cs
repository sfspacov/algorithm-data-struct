class BinHeap
{
    public BinHeap()
    {
        HeapList = new List<int>();
    }
    public List<int> HeapList { get; private set; }
    public int CurrentSize { get; private set; }

    public void Insert(int data)
    {
        HeapList.Add(data);
        CurrentSize += 1;
        PercUp(CurrentSize);
    }

    private void PercUp(int i)
    {
        while (i / 2 > 0)
        {
            if (HeapList[i] < HeapList[i / 2])
            {
                //Swap items
                var temp = HeapList[i / 2];
                HeapList[i / 2] = HeapList[i];
                HeapList[i] = temp;
            }
            i = i / 2;
        }
    }

    public int Delete()
    {
        var value = HeapList.First();
        HeapList[0] = HeapList.Last();
        CurrentSize -= 1;
        HeapList.RemoveAt(0);
        PercDown(1);
        return value;
    }

    private void PercDown(int i)
    {
        while (i * 2 <= CurrentSize)
        {
            var mc = MinChild(i);
            if (HeapList[i] > HeapList[mc])
            {
                var temp = HeapList[i];
                HeapList[i] = HeapList[mc];
                HeapList[mc] = temp;
            }
            i = mc;
        }
    }

    private int MinChild(int i)
    {
        if (i * 2 + 1 > CurrentSize)
        {
            return i * 2;
        }
        else
        {
            if (HeapList[i * 2] < HeapList[i * 2 + 1])
            {
                return i * 2 + 1;
            }
            else
            {
                return i * 2 + 1;
            }
        }
    }
}
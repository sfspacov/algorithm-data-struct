class MyQueue<T> where T : class
{
    private List<T> list { get; set; }

    public MyQueue()
    {
        list = new List<T>();
    }
    public MyQueue(T element)
    {
        list = new List<T>();
        list.Add(element);
    }

    public bool IsEmpty()
    {
        return list.Count == 0;
    }

    public int Size()
    {
        return list.Count;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new Exception("Queue is empty");
        return list[0];
    }

    public bool Countains(T item)
    {
        return list.Any(x => x == item);
    }

    public void Enqueue(T item)
    {
        list.Add(item);
    }

    public T Dequeue()
    {
        var result = Peek();
        list.RemoveAt(0);
        return result;
    }
}
var list = RunningMedian(new List<int> { 12, 4, 5, 3, 8, 7 });
Console.Write(list);
static List<double> RunningMedian(List<int> a)
{
    if (a.Count == 1) return a.Select(x => (double)x).ToList();
    var result = new List<double>();
    var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => a - b));
    var minHeap = new PriorityQueue<int, int>();

    foreach (var num in a)
    {
        AddNumber(num, minHeap, maxHeap);
        Balance(minHeap, maxHeap);
        result.Add(GetMedian(minHeap, maxHeap));
    }

    void AddNumber(int num, PriorityQueue<int, int> minHeap, PriorityQueue<int, int> maxHeap)
    {
        if (maxHeap.Count == 0 || num < maxHeap.Peek())
            maxHeap.Enqueue(num, num);
        else
            minHeap.Enqueue(num, num);
    }

    void Balance(PriorityQueue<int, int> minHeap, PriorityQueue<int, int> maxHeap)
    {
        if (minHeap.Count - maxHeap.Count > 1)
        {
            var data = minHeap.Dequeue();
            maxHeap.Enqueue(data, data);
        }
        if (maxHeap.Count - minHeap.Count > 1)
        {
            var data = maxHeap.Dequeue();
            minHeap.Enqueue(data, data);
        }
    }

    double GetMedian(PriorityQueue<int, int> minHeap, PriorityQueue<int, int> maxHeap)
    {
        if (minHeap.Count == maxHeap.Count)
            return (double)((minHeap.Peek() - maxHeap.Peek())/2);
        else if (minHeap.Count > maxHeap.Count)
            return (double)minHeap.Peek();
        else
            return (double)maxHeap.Peek();
    }

    return result;
}
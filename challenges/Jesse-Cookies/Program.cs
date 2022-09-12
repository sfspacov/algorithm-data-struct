Console.WriteLine(Cookies(9, new List<int> { 2, 7, 3, 6, 4, 6 }));
Console.WriteLine(Cookies(10, new List<int> { 1, 1, 1 }));
static int Cookies(int k, List<int> A)
{
    var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a,b)=> a-b));
    
    var minHeap = new PriorityQueue<int, int>();
    for (var i = 0; i < A.Count; i++)
        minHeap.Enqueue(A[i], A[i]);

    var counter = 0;
    while (minHeap.Count > 1 && minHeap.Peek() <= k)
    {
        counter += 1;
        var first = minHeap.Dequeue();
        var secon = minHeap.Dequeue() * 2;
        var newElement = first + secon;
        
        minHeap.Enqueue(newElement, newElement);
    }

    return minHeap.Peek() < k ? -1 : counter;
}
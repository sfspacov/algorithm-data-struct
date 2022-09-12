var k = 1;
var collection = new List<int> { 7, 4, 6, 3, 9, 1 };

Console.WriteLine($"{k}th Largest: {FindKthLargest(collection, k)}");
Console.WriteLine($"{k}th Smallest: {FindKthSmallest(collection, k)}");

static int FindKthLargest(List<int> ints, int k)
{
    if (ints == null || ints.Count == 0) return 0;
    if (ints.Count == 1) return ints[0];

    var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

    for (var i = 0; i < ints.Count; i++)
        maxHeap.Enqueue(ints[i], ints[i]);

    for (var i = 1; i < k; i++)
        maxHeap.Dequeue();

    return maxHeap.Dequeue();
}

static int FindKthSmallest(List<int> ints, int k)
{
    if (ints == null || ints.Count == 0) return 0;
    if (ints.Count == 1) return ints[0];
    
    var minHeap = new PriorityQueue<int, int>();

    for (var i = 0; i < ints.Count; i++)
        minHeap.Enqueue(ints[i], ints[i]);

    for (var i = 1; i < k; i++)
        minHeap.Dequeue();

    return minHeap.Dequeue();
}

/*
    parent = i/2
    left child = i*2
    right child = i*2+1
*/

int[] meuArray = new int[] { 1, 3, 2 };
/*
            1
        3       4
     38   8   9   5
  65

  [10, 4, 3]
*/
void MinHeapOperations()
{
    var minHeap = new MinHeap(meuArray);
    Console.WriteLine("Length: " + minHeap.Size);
    Console.WriteLine("First item: " + minHeap.Get());
    minHeap.Print();
    Console.WriteLine(MinHeap.IsMinHeap(meuArray));
    Console.WriteLine(MinHeap.IsMinHeap(null));
    Console.WriteLine(MinHeap.IsMinHeap(new int[] { }));
    Console.WriteLine(MinHeap.IsMinHeap(new int[] { 1 }));
    Console.WriteLine(MinHeap.IsMinHeap(new int[] { 1, 2 }));
    Console.WriteLine(MinHeap.IsMinHeap(new int[] { 1, 2, 3 }));
    Console.WriteLine(MinHeap.IsMinHeap(new int[] { 1, 2, 3, 4 }));
    var listaCagada = new int[] { 1, 2, 3, 400, 6, 7, 8, 9, 99 };
    Console.WriteLine(MinHeap.IsMinHeap(listaCagada));
    Console.WriteLine(MinHeap.IsMinHeap(new int[] { 10, 2, 3, 4 }));
    Console.WriteLine(MinHeap.IsMinHeap(new int[] { 1, 5, 3, 4 }));
    Console.WriteLine(MinHeap.IsMinHeap(new int[] { 1, 2, 3, 4, 5 }));
    var aha = new MinHeap(listaCagada);
    aha.Delete();
}

//MinHeapOperations();

MaxHeapOperations();

void MaxHeapOperations()
{
    var array = new int[] { 35, 33, 42, 10, 14, 19, 27, 44, 26, 31 };
    var mh = new MaxHeap(array);
    Console.WriteLine("array is Max Heap? " + MaxHeap.IsMaxHeap(array));
    Console.WriteLine("mh is Max Heap? " + MaxHeap.IsMaxHeap(mh.Items));
    Console.WriteLine("Priority Queue antes de deletar");
    mh.Print();

    var originalSize = mh.Size;
    for (int i = 0; i < originalSize; i++)
    {
        Console.WriteLine("\nDelete");
        mh.Delete();
        mh.Print();
    }
}
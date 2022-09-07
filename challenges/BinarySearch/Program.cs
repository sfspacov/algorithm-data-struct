Console.WriteLine(BinarySearchTree(new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13}, 2));

bool BinarySearchTree(int[] array, int data)
{
    if (array == null || !array.Any()) return false;

    if (array.Length == 1 && array[0] == data)
        return true;
    else if (array.Length == 1 && array[0] != data)
        return false;

    var mid = array.Length / 2;
    var left = array.Take(mid).ToArray();
    var right = array.Skip(mid).ToArray();

    if (data >= left[0] && data <= left.Last())
    {
        if (BinarySearchTree(left, data))
            return true;
    }
    else if (data >= right[0] && data <= right.Last())
    {
        if (BinarySearchTree(right, data))
            return true;
    }

    return false;
}
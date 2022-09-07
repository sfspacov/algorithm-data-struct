/*
    Divide and Conquer algorithm
    Time complexity: Big O(n*log n)
*/
var sorted = MergeSort2(new[] { 2, 8, 9, 1, 16, 84, 5, 122, 19, 77 });

foreach (var item in sorted)
{
    Console.WriteLine(item);
}

int[] MergeSort(int[] array)
{
    if (array.Length < 2)
        return array;

    var mid = array.Length / 2;
    var left = array.Take(mid).ToArray();
    var right = array.Skip(mid).ToArray();
    MergeSort(left);
    MergeSort(right);
    return Merge(left, right, array);
}

int[] Merge(int[] left, int[] right, int[] array)
{
    var i = 0;
    var j = 0;
    var k = 0;

    while (i < left.Length && j < right.Length)
        if (left[i] < right[j])
        {
            array[k++] = left[i++];
        }
        else
        {
            array[k++] = right[j++];
        }

    while (i < left.Length)
    {
        array[k++] = left[i++];
    }

    while (j < right.Length)
    {
        array[k++] = right[j++];
    }

    return array;
}

static int[] MergeSort2(int[] array)
{
    if (array.Length < 2)
        return array;

    var div = array.Length / 2;
    var left = array.Take(div).ToArray();
    var right = array.Skip(div).ToArray();

    MergeSort2(left);
    MergeSort2(right);
    Merge2(array, left, right);

    return array;
}

static int[] Merge2(int[] array, int[] left, int[] right)
{
    var i = 0;
    var j = 0;
    var k = 0;

    while (i < left.Length && j < right.Length)
        if (left[i] < right[j])
        {
            array[k++] = left[i++];
        }
        else
        {
            array[k++] = right[j++];
        }

    while (i < left.Length)
        array[k++] = left[i++];
    while (j < right.Length)
        array[k++] = right[j++];

    return array;
}
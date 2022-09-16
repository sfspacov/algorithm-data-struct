ThreeSum(new int[] { -3, 3, 4, -3, 1, 2 });

// -4, -1, -1, 0, 1, 2

// ThreeSum(new int[] { 0, 1, 1 });
// ThreeSum(new int[] { 0, 0, 0 });

IList<IList<int>> ThreeSum(int[] nums)
{
    nums = MergeSort(nums.Distinct().ToArray());
    var answer = new List<IList<int>>();

    for (int i = 0; i < nums.Length - 2; i++)
    {
        var pivot = nums[i];
        var low = i + 1;
        var high = nums.Length - 1;

        while (low <= high)
        {
            
            if (pivot + nums[low] + nums[high] == 0)
            {
                answer.Add(
                    new List<int> { pivot, nums[low], nums[high] }
                    );

            }
            low++;
            high--;
        }
    }


    return answer;
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
    return Merge(array, left, right);
}

int[] Merge(int[] array, int[] left, int[] right)
{
    var i = 0;
    var j = 0;
    var k = 0;

    while (i < left.Count() && j < right.Count())
    {
        if (left[i] < right[j])
            array[k++] = left[i++];
        else
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
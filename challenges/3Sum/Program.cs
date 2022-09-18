ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
// -4,-1,-1,0,1,2

IList<IList<int>> ThreeSum(int[] nums)
{
    var answer = new List<IList<int>>();

    MergeSort(nums);

    for (var i = 0; i < nums.Length - 1; i++)
    {
        var pivot = nums[i];
        var low = i + 1;
        var high = nums.Length - 1;

        if (i > 0 && nums[low] == pivot)
            continue;

        while (low < high)
        {
            var highNumber = nums[high];
            var lowNumber = nums[low];
            var sum = pivot + lowNumber + highNumber;

            if (sum > 0)
                high--;
            else if (sum < 0)
                low++;
            else
            {
                answer.Add(new List<int> { pivot, lowNumber, highNumber });
                low++;
                while (nums[low] == nums[low - 1] && low < high)
                {
                    low++;
                }
            }
        }
    }

    return answer;
}

void MergeSort(int[] array)
{
    if (array.Length < 2)
        return;

    var mid = array.Length / 2;
    var left = array.Take(mid).ToArray();
    var right = array.Skip(mid).ToArray();

    MergeSort(left);
    MergeSort(right);
    Merge(array, left, right);
}

void Merge(int[] array, int[] left, int[] right)
{
    var i = 0;
    var j = 0;
    var k = 0;

    while (i < left.Length && j < right.Length)
    {
        if (left[i] < right[j])
        {
            array[k++] = left[i++];
        }
        else
        {
            array[k++] = right[j++];
        }
    }

    while (i < left.Length)
        array[k++] = left[i++];

    while (j < right.Length)
        array[k++] = right[j++];
}


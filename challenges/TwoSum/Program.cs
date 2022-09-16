TwoSum(new int[] { 3, 2, 4 }, 6);
int[] TwoSum(int[] nums, int target)
{
    if (nums.Length == 2)
        return new int[] { 0, 1 };

    for (int i = 0; i < nums.Length; i++)
    {
        var pivot = nums[i];
        var low = i + 1;
        var high = nums.Length - 1;
        while (low <= high)
        {
            if (pivot + nums[low] == target)
            {
                return new int[] { i, low };
            }

            if (pivot + nums[high] == target)
            {
                return new int[] { i, high };
            }

            low++;
            high--;
        }
    }
    return null;
}

TwoSumSorted(new int[] { 1,2,3,4,4,9,56,90}, 8);

int[] TwoSumSorted(int[] numbers, int target)
{
    if (numbers.Length == 2)
        return new int[] { 1, 2 };

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        var pivot = numbers[i];
        var low = i + 1;
        var high = numbers.Length - 1;
        var mid = (low + high) / 2;

        if ((numbers[i] != numbers[i + 1]) || (numbers[i] == numbers[i + 1]) && target == 2*numbers[i]|| target == 0)
        {

            while (low <= high)
            {
                if (pivot + numbers[low] == target)
                    return new int[] { i + 1, low + 1 };

                if (pivot + numbers[mid] == target)
                    return new int[] { i + 1, mid + 1 };

                if (pivot + numbers[mid--] == target)
                    return new int[] { i + 1, mid };

                if (pivot + numbers[high] == target)
                    return new int[] { i + 1, high + 1 };

                low++;
                high--;
            }

        }
    }

    return null;
}
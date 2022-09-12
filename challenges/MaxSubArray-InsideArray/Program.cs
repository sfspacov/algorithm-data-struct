Console.WriteLine(MaxSubArray(new int[] { -2, -1, -3, -4, -1, -2, -1, -5, -7 }));

int MaxSubArray(int[] a)
{
    {
        int maximum_sum = int.MinValue;
        int current_sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            current_sum = current_sum + a[i];
            if (current_sum > maximum_sum)
                maximum_sum = current_sum;
            if (current_sum < 0)
                current_sum = 0;
        }
        return maximum_sum;
    }
}
Console.WriteLine(pairs(2, new List<int> { 1, 5, 3, 4, 2 }));


static int pairs(int k, List<int> arr)
{
    var result = 0;
    var dic = new HashSet<int>(arr);

    foreach (int i in arr)
    {
        if (dic.Contains(i + k) || dic.Contains(i - k))
            result++;
        dic.Remove(i);
    }

    return result;
}
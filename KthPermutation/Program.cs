KthPermutation(4, 17);

static List<int> KthPermutation(int n, int k)
{
    var permutation = new List<int>();
    var unused = Enumerable.Range(1, n + 1).ToList();
    var fact = Enumerable.Repeat(1, n + 1).ToList();

    for (int i = 1; i < n + 1; i++)
        fact[i] = i * fact[i - 1];

    k -= 1;

    while (n > 0)
    {
        var part_length = fact[n] / n;
        var i = k / part_length;
        permutation.Add(unused[i]);
        unused.RemoveAt(i);
        n -= 1;
        k %= part_length;
    }

    return permutation;
}
Console.WriteLine(MaxProduct(new int[]{2,3,-2,4}));
Console.WriteLine(MaxProduct(new int[]{-2,0,-1}));
int MaxProduct(int[] A)
{
    int n = A.Length, res = A[0], l = 0, r = 0;
    for (int i = 0; i < n; i++)
    {
        l = (l == 0 ? 1 : l) * A[i];
        r = (r == 0 ? 1 : r) * A[n - 1 - i];
        res = Math.Max(res, Math.Max(l, r));
    }
    return res;
}
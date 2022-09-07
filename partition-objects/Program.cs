int CountPartition(int n, int m)
{
    if (n == 0 || m == 1 || n == 1 && m != 0) return 1;
    if (m == 0) return 0;

    return CountPartition
}
static int findMaximum(int a, int b, int c)
{
    return Math.Max(Math.Max(a, b), c);
}

static int findMaximum2(int a, int b, int c)
{
    var max = a;

    if (b > max)
        max = b;

    if (c > max)
        max = c;

    return max;
}

Console.WriteLine(findMaximum2(1, 2, 3));
Console.WriteLine(findMaximum2(8, 8, 1));
Console.WriteLine(findMaximum2(3, 2, 3));
Console.WriteLine(findMaximum2(1, 1, 9));
Console.WriteLine(findMaximum2(1, 9, 9));
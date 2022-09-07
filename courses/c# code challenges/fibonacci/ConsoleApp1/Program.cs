foreach (var item in Fibonacci(12))
{
    Console.Write(item + ", ");
}

static List<int> Fibonacci(int n)
{
    if (n == 1)
        return new List<int> { 0, 1 };

    var result = Fibonacci(n - 1);
    
    var nextValue = result.ElementAt(n - 1) + result.ElementAt(n - 2);
    
    result.Add(nextValue);

    return result;
}
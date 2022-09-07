var x = matchingStrings(new List<string>{"ab", "ab", "abc"}, new List<string>{"ab", "abc", "bc"});
foreach (var item in x)
{
    Console.Write(item);
}

static List<int> matchingStrings(List<string> strings, List<string> queries)
{
    var result = new List<int>();

    foreach (var item in queries)
    {
        result.Add(strings.Count(x => x == item));
    }

    return result;
}
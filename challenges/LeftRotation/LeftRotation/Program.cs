static List<int> rotateLeft(int d, List<int> arr)
{
    return arr.Skip(d).Take(arr.Count - d).Concat(arr.Take(d)).ToList();
}
var input = new int[] { 1, 2, 3, 4, 5, 6 };
RotationLeft(input, 1);
RotationRight(input, 3);
Array.ForEach(input, Console.WriteLine);

void RotationLeft(int[] input, int rotate)
{
    var first = input.Skip(0).Take(rotate);
    var second = input.Skip(rotate).Take(input.Length - rotate);
    var final = second.Concat(first).ToArray();
    for (int i = 0; i < input.Length; i++)
    {
        input[i] = final.ElementAt(i);
    }
}

void RotationRight(int[] input, int rotate)
{
    var first = input.Skip(input.Length - rotate).Take(rotate);
    var second = input.Skip(0).Take(input.Length - rotate);
    var final = first.Concat(second).ToArray();
    for (int i = 0; i < input.Length; i++)
    {
        input[i] = final.ElementAt(i);
    }
}
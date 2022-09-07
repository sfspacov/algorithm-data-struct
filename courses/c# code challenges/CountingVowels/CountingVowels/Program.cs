Console.WriteLine(
    VowelCount(
        "Hey LinkedIn"
    ));

int VowelCount(string phrase)
{
    phrase = phrase.ToUpper();
    var criteria = new Dictionary<char, int>();
    criteria.Add('A', 1);
    criteria.Add('E', 2);
    criteria.Add('I', 3);
    criteria.Add('O', 4);
    criteria.Add('U', 5);
    criteria.Add('Y', 9);

    int result = 0;

    foreach (var item in criteria)
    {
        if (phrase.Contains(item.Key))
        {
            result += phrase.Count(x => x == item.Key) * item.Value;
        }
    }

    return result;
}
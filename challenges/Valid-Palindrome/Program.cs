using System.Text.RegularExpressions;
Console.WriteLine(IsPalindrome("race a car"));
Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));

bool IsPalindrome(string s)
{
    var regex = new Regex("[^a-zA-Z0-9 -]");
    var sS = regex.Replace(s, "").Replace(" ", "").Replace("-", "").ToLower();

    if (sS.Length < 2)
    {
        return true;
    }

    var low = 0;
    var high = sS.Count() - 1;

    for (var i = 0; low <= high; i++)
    {
        if (sS[low].ToString().ToLower() != sS[high].ToString().ToLower())
            return false;
        low++;
        high--;
    }

    return true;
}
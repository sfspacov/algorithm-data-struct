// Console.WriteLine(LengthOfLongestSubstring("aab"));
// Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
// Console.WriteLine(LengthOfLongestSubstring("bbbbb"));
// Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
// Console.WriteLine(LengthOfLongestSubstring("dvdf"));
Console.WriteLine(LengthOfLongestSubstring("ohvhjdml"));

int LengthOfLongestSubstring(string s)
{
    if (s.Length == 0) return 0;
    if (s.Length == 1) return 1;

    var substring = "";
    var max = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (!substring.Contains(s[i]))
        {
            substring += s[i];
            if (substring.Length > max)
                max = substring.Length;
        }
        else
        {
            while(substring.Contains(s[i]))
                substring = new string(substring.Skip(1).ToArray());

            substring+=s[i];
        }
    }

    return max;
}
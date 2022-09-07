var s = "a";
var t = "b";

Console.WriteLine(MinWindowSubstring(s, t));
string MinWindowSubstring(string s, string t)
{
    if (s.Length < t.Length)
        return "";

    var dicT = new int[122];
    //To UPPER CASE: A -> Z
    var aPosition = 65;

    for (int j = 0; j < t.Length; j++)
    {
        var charValue = (int)t[j];
        var indexT = charValue - aPosition;
        dicT[indexT]++;
    }

    var seq = "";
    string smallestSeq = null;
    var reset = 0;

    for (int i = reset; i < s.Length; i++)
    {
        if (string.IsNullOrEmpty(seq) && !t.Contains(s[i]))
        {
            reset += 1;
            continue;
        }
        seq += s[i];

        if (seq.Length < t.Length)
            continue;

        var dicS = new int[122];

        for (int j = 0; j < seq.Length; j++)
        {
            if (t.Contains(seq[j]))
            {
                var charValue = (int)seq[j];
                var indexS = charValue - aPosition;
                dicS[indexS]++;
            }
        }

        var valid = true;

        for (int k = 0; k < dicT.Length; k++)
        {
            if (dicS[k] < dicT[k])
                valid = false;

        }

        if (valid)
        {
            if (string.IsNullOrEmpty(smallestSeq) || (!string.IsNullOrEmpty(smallestSeq) && seq.Length < smallestSeq.Length))
                smallestSeq = seq;
            seq = "";
            reset += 1;
            i = reset - 1;
        }
    }

    return smallestSeq == null ? "" : smallestSeq;
}
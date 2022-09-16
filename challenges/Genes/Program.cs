/*
Design an algorithm that accepts a stream of characters from a fixed set [A, T, G, C] and checks 
if a suffix of these characters is a string of a given array of gene sequences "genes".

For example, if genes = ["GCA", "AAAG"] and the stream added the four characters 
(one by one) 'A', 'G', 'C', and 'A', your algorithm should detect that the suffix
 "GCA" of the characters "AGCA" matches "GCA" from genes.

Implement the GeneSequencer class.

Example 1

Input
genes = ["TGCAG", "ACCC", "A"]
characters = ["T"], ["G"], ["C"], ["A"], ["G"], ["G"], ["A"], ["C"], ["C"], ["C"], ["T"]]
Output

[false, false, false, true, true, false, true, false, false, true, false]

["TGCAG", "ACCC", "A"]

*/

var genes = new string[] { "TGCAG", "ACCC", "A" };
var characters = "TGCAGGACCCT";
var charArray = new List<char>();
var boolArray = new List<bool>();
var counter = 0;

foreach (var c in characters)
    Console.WriteLine(find(genes, c, counter++));

bool find(string[] genes, char c, int counter)
{
    charArray.Add(c);

    if (charArray.Count == 1 && genes.Contains(new string(charArray.ToArray())))
        return true;

    int l = 0, r = counter;

    while (l <= r)
    {
        if (genes.Contains(new string(charArray.Skip(l++).ToArray())))
            return true;

        if (genes.Contains(new string(charArray.Skip(r--).ToArray())))
            return true;
    }

    return false;
}
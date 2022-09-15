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
var hashChars = new HashSet<string>();

find(genes, characters);

bool find(string[] genes, string characters)
{
    foreach (var g in genes)
    {
        if (characters.Contains(g))
            return true;
    }

    return false;
}
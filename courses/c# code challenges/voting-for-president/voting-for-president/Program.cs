const int firstElection = 1902;
Console.WriteLine(CalculatePresidents(35));

static int CalculatePresidents(int age)
{
    var ageToVote = 16;
    var startToVote = DateTime.Now.Year - age + ageToVote;
    //1987
    var votesCounter = 0;
    for (int year = firstElection; year <= DateTime.Now.Year; year+=4)
        if (year >= startToVote)
            votesCounter++;
   
    return votesCounter;
}
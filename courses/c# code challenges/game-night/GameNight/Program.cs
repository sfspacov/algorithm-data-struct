PrintStats(15);

static void PrintStats(int targetImprovement)
{
    var players = new List<Player>()
        {
        new Player("Douglas", "Flores", 233, 198),
        new Player("DoKathryn", "Flores", 198, 202),
        new Player("Sharon", "Ortiz", 241, 222),
        new Player("James", "Ortiz", 211, 188),

        new Player("Harrison", "Ferrone", 233, 198),
        new Player("Alex", "Ferrone", 219, 202),
        new Player("Haley", "Ferrone", 241, 222),
        new Player("John", "Doe", 144, 198),
        new Player("Sally", "Doe", 233, 198),
        new Player("Frank", "Smith", 189, 234),
        new Player("Joan", "Smith", 211, 178)
    };

    players = players
        .Where(x => x.currentScore - x.lastScore > targetImprovement)
        .OrderBy(x => x.lastname)
        .ToList();

    var currentLetter = ' ';
    foreach (var item in players)
    {
        if (currentLetter != item.lastname[0])
        {
            currentLetter = item.lastname[0];
            Console.WriteLine(currentLetter);
        }
        Console.WriteLine($"{item.firstname} {item.lastname}");
    }
}

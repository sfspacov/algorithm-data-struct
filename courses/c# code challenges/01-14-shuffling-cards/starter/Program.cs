var freshDeck = new Deck();
var shuffledDeck = Shuffle(freshDeck.cards);

static List<string> Shuffle(List<string> deck)
{
    var random = new Random();
    var newDeck = new List<string>();
    var originalSize = deck.Count;
    
    for (var i = 0; i < originalSize; i++)
    {
        var firstIndex = random.Next(deck.Count);
        newDeck.Add(deck[firstIndex]);
        deck.RemoveAt(firstIndex);
    }
    
    return newDeck;    
}
FrenchDeck deck = new FrenchDeck();
Console.WriteLine("---------- Deck          ----------");
deck.Print();
Console.WriteLine("---------- Random Card   ----------");
var c1 = deck.RandomCard();
var c2 = deck.RandomCard();
Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine("---------- Shuffle Cards ----------");
deck.ShuffleCards();
deck.Print();
// Debug to compare cards
c1 = new Card(FrenchDeck.Ranks[0], Suite.Clubs);
c2 = new Card(FrenchDeck.Ranks[12], Suite.Spades);
var compare = new CardComparator();
compare.Compare(c1, c2);
Console.WriteLine("---------- Sort Deck ----------");
deck.SortDeck();
deck.Print();

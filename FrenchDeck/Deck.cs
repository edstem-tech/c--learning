namespace FrenchDeck;

public class Deck
{
    private readonly List<Card> _cards = new List<Card>(52);
    private static readonly Random Random = new Random();

    static Deck()
    {
        Ranks = Enumerable.Range(2, 9)
            .Select(n => n.ToString())
            .ToList();
        Ranks.AddRange(new[] { "J", "Q", "K", "A" });
    }

    // default constructor
    public Deck()
    {
        var suites = Enum.GetValues<Suite>();

        foreach (var t in suites)
        {
            foreach (var r in Ranks)
            {
                _cards.Add(new Card(r, t));
            }
        }
    }

    public List<Card> Cards => _cards;
    public static List<string> Ranks { get; }

    public void Print()
    {
        foreach (var card in _cards)
        {
            Console.WriteLine(card);
        }
    }

    public Card RandomCard()
    {
        return _cards[Random.Next(_cards.Count)];
    }

    public void ShuffleCards()
    {
        // Fischer-Yates shuffle algorithm
        var n = _cards.Count;
        while (n > 1)
        {
            n--;
            var k = Random.Next(n + 1);
            (_cards[k], _cards[n]) = (_cards[n], _cards[k]);
        }
    }

    public void SortDeck()
    {
        _cards.Sort(new CardComparator());
    }

}
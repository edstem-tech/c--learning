using System.Collections.Generic;

public class FrenchDeck
{
    private readonly List<Card> _cards = new List<Card>(52);
    private readonly static List<String> _ranks = new List<String>();
    private static readonly Random _random = new Random();

    static FrenchDeck()
    {
        _ranks = Enumerable.Range(2, 9)
                                    .Select(n => n.ToString())
                                    .ToList();
        _ranks.AddRange(new String[] { "J", "Q", "K", "A" });
    }

    // default constructor
    public FrenchDeck()
    {
        var suites = Enum.GetValues<Suite>();

        for (int j = 0; j < suites.Length; j++)
        {
            for (int i = 0; i < _ranks.Count; i++)
            {
                _cards.Add(new Card(_ranks[i], suites[j]));
            }
        }
    }


    public List<Card> Cards => _cards;
    public static List<String> Ranks => _ranks;

    public void Print()
    {
        foreach (Card card in _cards)
        {
            Console.WriteLine(card);
        }
    }

    public Card RandomCard()
    {
        return _cards[_random.Next(_cards.Count)];
    }

    public void ShuffleCards()
    {
        // Fischer-Yates shuffle algorithm
        int n = _cards.Count;
        while (n > 1)
        {
            n--;
            int k = _random.Next(n + 1);
            Card value = _cards[k];
            _cards[k] = _cards[n];
            _cards[n] = value;
        }
    }

    public void SortDeck()
    {
        _cards.Sort(new CardComparator());
    }

}

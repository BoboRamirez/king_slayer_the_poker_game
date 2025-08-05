public struct PokerData
{
    public ESuit Suit;
    public ERank Rank;
    public readonly int Index => (int)Suit * 14 + (int)Rank;

    public static PokerData FromIndex(int index)
    {
        if (index >= (int)ERank.Joker)
            return new PokerData(ERank.Joker, ESuit.None);
        if (index < 0)
            return new PokerData(ERank.Joker, ESuit.Spade);
        var rank = (ERank)(index % 14);
        var suit = (ESuit)(index / 14);
        return new PokerData(rank, suit);
    }

    public PokerData(ERank rank, ESuit suit)
    {
        Suit = suit;
        Rank = rank;
    }

}

public enum ESuit
{
    None,
    Spade,
    Heart,
    Diamond,
    Club
}

public enum ERank
{
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
    Joker = 100
}
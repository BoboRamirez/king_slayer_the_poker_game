using UnityEngine;

public struct PokerData
{
    public ESuit Suit;
    public EValue Value;
}

public enum ESuit
{
    Spade,
    Heart,
    Diamond,
    Club
}

public enum EValue
{
    Joker,
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
}
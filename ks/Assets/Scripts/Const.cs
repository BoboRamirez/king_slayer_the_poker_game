using System.Collections.Generic;

public static class GSConstants
{
    public static Dictionary<ERank, int> Values = new()
    {
        {ERank.Ace, 1},
        {ERank.Two, 2},
        {ERank.Three, 3},
        {ERank.Four, 4},
        {ERank.Five, 5},
        {ERank.Six, 6},
        {ERank.Seven, 7},
        {ERank.Eight, 8},
        {ERank.Nine, 9},
        {ERank.Ten, 10},
        {ERank.Jack, 10},
        {ERank.Queen, 15},
        {ERank.King, 20},
        {ERank.Joker, 0}
    };

    public static readonly int HandSize = 8;
    public static readonly List<int> TavernDeck = new List<int>
    {
        14, 15, 16, 17, 18, 19, 20, 21, 22, 23,
        28, 29, 30, 31, 32, 33, 34, 35, 36, 37,
        42, 43, 44, 45, 46, 47, 48, 49, 50, 51,
        56, 57, 58, 59, 60, 61, 62, 63, 64, 65,
    };
    public static readonly List<int> CastleDeck = new List<int>
    {
        24, 25, 26, 38, 39, 40, 52, 53, 54, 66, 67, 68,
    };
    public static readonly List<int> Jacks = new List<int> { 24, 38, 52, 66 };
    public static readonly List<int> Queens = new List<int> { 25, 39, 53, 67 };
    public static readonly List<int> Kings = new List<int> { 26, 40, 54, 68 };
    public static readonly int Joker = 100;
}

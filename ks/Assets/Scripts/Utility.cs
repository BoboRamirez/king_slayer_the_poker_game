using QFramework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DeckUtility : IUtility
{
    public List<PokerData> GetInitTavernDeck()
    {
        var deck = new List<PokerData>();
        foreach (var index in GSConstants.TavernDeck)
        {
            deck.Add(PokerData.FromIndex(index));
        }
        Shuffle(deck);
        return deck;
    }

    public Stack<PokerData> GetInitCastleDeck()
    {
        var deck = new Stack<PokerData>();
        var kings = new List<PokerData>();
        var queens = new List<PokerData>();
        var jacks = new List<PokerData>();
        foreach (var index in GSConstants.Kings)
            kings.Add(PokerData.FromIndex(index));
        foreach (var index in GSConstants.Queens)
            queens.Add(PokerData.FromIndex(index));
        foreach (var index in GSConstants.Jacks)
            jacks.Add(PokerData.FromIndex(index));
        foreach(var index in kings.OrderBy(x => Random.value))
            deck.Push(index);
        foreach(var index in queens.OrderBy(x => Random.value))
            deck.Push(index);
        foreach(var index in jacks.OrderBy(x => Random.value))
            deck.Push(index);
        return deck;
    }

    public void Shuffle<T>(List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int j = Random.Range(i, list.Count);
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}

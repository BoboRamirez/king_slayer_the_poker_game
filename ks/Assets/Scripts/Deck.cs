using QFramework;
using System.Collections.Generic;

public class TavernDeck : AbstractModel
{
    private List<PokerData> _desk;
    protected override void OnInit()
    {
        _desk = this.GetUtility<DeckUtility>().GetInitTavernDeck();
    }
}

public class CastleDeck : AbstractModel
{
    private Stack<PokerData> _desk;
    protected override void OnInit()
    {
        _desk = this.GetUtility<DeckUtility>().GetInitCastleDeck();
    }
}

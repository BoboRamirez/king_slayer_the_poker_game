using System.Collections.Generic;
using QFramework;

public class PlayerModel : AbstractModel
{
    private List<PokerData> _hand;  
    private int _handSizeLimit;
    private string _name;
    protected override void OnInit()
    {
        _hand = new List<PokerData>();
        _handSizeLimit = GSConstants.HandSize;
        _name = "Player";
    }
}

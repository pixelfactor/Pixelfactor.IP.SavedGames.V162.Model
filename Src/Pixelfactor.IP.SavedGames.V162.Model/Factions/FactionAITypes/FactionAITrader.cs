using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model.Factions.FactionAITypes
{
    public class FactionAITrader : FactionAI
    {
        public bool TradeOnlySpecificCargoTypes { get; set; }
        public List<int> TradeSpecificCargoTypes { get; set; } = new List<int>();
    }
}

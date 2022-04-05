using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    /// <summary>
    /// Defines info about ships that a station sells
    /// </summary>
    public class UnitShipTraderData
    {
        public List<UnitShipTraderItem> Items { get; set; } = new List<UnitShipTraderItem>();
    }
}

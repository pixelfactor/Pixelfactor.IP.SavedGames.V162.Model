using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.OrderTypes
{
    public class UniverseTradeOrder : FleetOrder
    {
        public int MinBuyQuantity { get; set; }
        public float MinBuyCargoPercentage { get; set; }
        public bool TradeOnlySpecificCargoClasses { get; set; }

        /// <summary>
        /// If trading only certain cargo, these are the ids
        /// TODO: Change id to enum
        /// </summary>
        public List<int> TradeSpecificCargoClassIds { get; set; } = new List<int>();
    }
}

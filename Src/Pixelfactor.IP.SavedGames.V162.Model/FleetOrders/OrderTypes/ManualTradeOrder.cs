using Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.Models;

namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.OrderTypes
{
    public class ManualTradeOrder : FleetOrder
    {
        public int MinBuyQuantity { get; set; }
        public float MinBuyCargoPercentage { get; set; }
        public CustomTradeRoute CustomTradeRoute { get; set; }

        public override FleetOrderType OrderType => FleetOrderType.ManualTrade;
    }
}

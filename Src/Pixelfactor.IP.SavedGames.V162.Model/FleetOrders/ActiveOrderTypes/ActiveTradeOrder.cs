using Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.ActiveOrderTypes.Models;
using Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.Models;

namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.ActiveOrderTypes
{
    public class ActiveTradeOrder : ActiveFleetOrder
    {
        public CustomTradeRoute TradeRoute { get; set; }
        public double EndBuySellTime { get; set; }
        public double LastStateChangeTime { get; set; }
        public ActiveTradeOrderState CurrentState { get; set; }
    }
}

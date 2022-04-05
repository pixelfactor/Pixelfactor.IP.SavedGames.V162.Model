using Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.ActiveOrderTypes.Models;

namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.ActiveOrderTypes
{
    public class ActiveUniversePassengerTransportOrder : ActiveFleetOrder
    {
        public PassengerGroup PassengerGroup { get; set; }
        public double EndBuySellTime { get; set; }
        public double LastStateChangeTime { get; set; }
        public ActiveTransportPassengerOrderState CurrentState { get; set; }
    }
}

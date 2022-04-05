using Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.ActiveOrderTypes.Models;

namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.ActiveOrderTypes
{
    public class ActiveSellCargoOrder : ActiveFleetOrder
    {
        public double SellExpireTime { get; set; }
        public CargoClass SellCargoClass { get; set; }
        public ActiveSellCargoOrderState State { get; set; }
        public Unit TraderTargetUnit { get; set; }
    }
}

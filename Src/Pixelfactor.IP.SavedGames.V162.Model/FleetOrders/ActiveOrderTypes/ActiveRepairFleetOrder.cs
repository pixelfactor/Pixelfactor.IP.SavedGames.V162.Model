using Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.ActiveOrderTypes.Models;

namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.ActiveOrderTypes
{
    public class ActiveRepairFleetOrder : ActiveFleetOrder
    {
        public ActiveRepairFleetOrderState RepairState { get; set; }
        public Unit CurrentRepairLocationUnit { get; set; }
    }
}

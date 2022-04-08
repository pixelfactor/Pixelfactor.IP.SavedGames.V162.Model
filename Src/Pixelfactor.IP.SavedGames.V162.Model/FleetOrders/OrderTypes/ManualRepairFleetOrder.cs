using Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.Models;

namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.OrderTypes
{
    public class ManualRepairFleetOrder : FleetOrder
    {
        public RepairFleetInsufficientCreditsMode InsufficientCreditsMode { get; set; }
        public Unit RepairLocationUnit { get; set; }

        public override FleetOrderType OrderType => FleetOrderType.ManualRepair;
    }
}

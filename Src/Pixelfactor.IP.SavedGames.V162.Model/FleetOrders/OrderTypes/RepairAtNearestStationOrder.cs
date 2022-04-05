using Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.Models;

namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.OrderTypes
{
    public class RepairAtNearestStationOrder : FleetOrder
    {
        public RepairFleetInsufficientCreditsMode InsufficientCreditsMode { get; set; }
    }
}

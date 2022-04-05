using Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.Models;

namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.OrderTypes
{
    public class MineOrder : FleetOrder
    {
        public float MaxCargoDistance { get; set; }
        public bool CompleteWhenCargoFull { get; set; }
        public CollectCargoOwnerMode CollectOwnerMode { get; set; }
        public Unit ManualMineTarget { get; set; }
    }
}

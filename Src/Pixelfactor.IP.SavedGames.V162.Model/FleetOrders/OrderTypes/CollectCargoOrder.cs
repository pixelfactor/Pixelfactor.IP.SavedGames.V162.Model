using Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.Models;

namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.OrderTypes
{
    public class CollectCargoOrder : FleetOrder
    {
        public float MaxCargoDistance { get; set; }
        public bool CompleteWhenCargoFull { get; set; }
        public CollectCargoOwnerMode CollectOwnerMode { get; set; }
        public bool OresOnly { get; set; }

        public override FleetOrderType OrderType => FleetOrderType.CollectCargo;
    }
}

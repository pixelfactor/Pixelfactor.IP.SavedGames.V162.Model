namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.OrderTypes
{
    public class WaitOrder : FleetOrder
    {
        public float WaitTime { get; set; }

        public override FleetOrderType OrderType => FleetOrderType.Wait;
    }
}

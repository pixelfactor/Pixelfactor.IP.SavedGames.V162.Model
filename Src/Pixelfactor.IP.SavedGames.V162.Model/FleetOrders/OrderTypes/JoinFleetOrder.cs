namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.OrderTypes
{
    public class JoinFleetOrder : FleetOrder
    {
        public Fleet TargetFleet { get; set; }

        public override FleetOrderType OrderType => FleetOrderType.JoinFleet;
    }
}

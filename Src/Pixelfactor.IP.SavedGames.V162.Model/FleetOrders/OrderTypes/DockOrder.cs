namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.OrderTypes
{
    public class DockOrder : FleetOrder
    {
        public Unit TargetDock { get; set; }

        public override FleetOrderType OrderType => FleetOrderType.Dock;
    }
}

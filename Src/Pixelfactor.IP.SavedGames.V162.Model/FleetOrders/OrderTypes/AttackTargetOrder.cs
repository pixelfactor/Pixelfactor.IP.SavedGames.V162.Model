namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.OrderTypes
{
    public class AttackTargetOrder : FleetOrder
    {
        public Unit TargetUnit { get; set; }
        public float AttackPriority { get; set; }

        public override FleetOrderType OrderType => FleetOrderType.AttackTarget;
    }
}

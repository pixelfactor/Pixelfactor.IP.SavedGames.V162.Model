namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.OrderTypes
{
    public class PatrolPathOrder : FleetOrder
    {
        public int PathDirection { get; set; }
        public bool IsLooping { get; set; }
        public SectorPatrolPath PatrolPath { get; set; }

        public override FleetOrderType OrderType => FleetOrderType.PatrolPath;
    }
}

namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.ActiveOrderTypes
{
    public class ActivePatrolOrder : ActiveFleetOrder
    {
        public int PathDirection { get; set; }
        public int NodeIndex { get; set; }
    }
}

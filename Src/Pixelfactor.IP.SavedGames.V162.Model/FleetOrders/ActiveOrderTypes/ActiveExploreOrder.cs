namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.ActiveOrderTypes
{
    public class ActiveExploreOrder : ActiveFleetOrder
    {
        public Sector CurrentTargetSector { get; set; }
        public Vec3 CurrentTargetPosition { get; set; }
    }
}

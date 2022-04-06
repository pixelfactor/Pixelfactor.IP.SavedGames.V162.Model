namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.ActiveOrderTypes
{
    public class ActiveUniverseRoamOrder : ActiveFleetOrder
    {
        public Sector CurrentTargetSector { get; set; }
        public Vec3 CurrentTargetPosition { get; set; }
    }
}

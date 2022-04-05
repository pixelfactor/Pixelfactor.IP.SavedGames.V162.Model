namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.ActiveOrderTypes
{
    public class ActiveCollectCargoOrder : ActiveFleetOrder
    {
        public Unit TractorTargetUnit { get; set; }
        public bool AutoFindCargoEnabled { get; set; }
        public bool AutoTractorCargoEnabled { get; set; }
    }
}

namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.ActiveOrderTypes
{
    public class ActiveScavengeOrder : ActiveFleetOrder
    {
        public Unit TractorTargetUnit { get; set; }
        public bool AutoFindCargoEnabled { get; set; }
        public bool AutoTractorCargoEnabled { get; set; }
        public bool IsRoaming { get; set; }
        public double RoamExpireTime { get; set; }
        public Vec3 LastKnownCargoPosition { get; set; }
        public bool HadCargoTarget { get; set; }
    }
}

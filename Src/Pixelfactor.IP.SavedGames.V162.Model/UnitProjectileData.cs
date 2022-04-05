namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public class UnitProjectileData
    {
        public Unit SourceUnit { get; set; }
        public Unit TargetUnit { get; set; }
        public double FireTime { get; set; }
        public float RemainingMovement { get; set; }
        public DamageType DamageType { get; set; }
    }
}

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public class SectorTarget
    {
        public Vec3 Position { get; set; }

        public Sector Sector { get; set; }

        public Unit TargetUnit { get; set; }

        public Fleet TargetFleet { get; set; }

        /// <summary>
        /// True when the order had a valid target unit or target fleet
        /// </summary>
        public bool HadValidTarget { get; set; }
    }
}

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public class UnitWormholeData
    {
        /// <summary>
        /// For stable wormholes, points to the other wormhole that this connects to.
        /// </summary>
        public Unit TargetWormholeUnit { get; set; }

        /// <summary>
        /// Don't change for existing wormholes - changing this will cause carnage
        /// </summary>
        public bool IsUnstable { get; set; }

        public double UnstableNextChangeTargetTime { get; set; }

        public Vector3 UnstableTargetPosition { get; set; }

        public Vector3 UnstableTargetRotation { get; set; }

        public Sector UnstableTargetSector { get; set; }
    }
}

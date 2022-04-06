namespace Pixelfactor.IP.SavedGames.V162.Model
{
    /// <summary>
    /// Sector/room within the universe
    /// </summary>
    public class Sector
    {
        public int Id { get; set; }

        /// <summary>
        /// The unity scene to load to represent the sector
        /// </summary>
        public string ResourceName { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Determines where the sector appears on the universe map
        /// </summary>
        public Vec3 MapPosition { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Determines the distance of the wormholes from the sector origin. Should be ~1.0
        /// </summary>
        public float GateDistanceMultiplier { get; set; }

        /// <summary>
        /// Something to do with the appearance of asteroid clusters
        /// </summary>
        public int RandomSeed { get; set; }

        /// <summary>
        /// Don't change. Internal engine use only
        /// </summary>
        public Vec3 Position { get; set; }

        /// <summary>
        /// Skybox rotation
        /// </summary>
        public Vec3 BackgroundRotation { get; set; }

        /// <summary>
        /// Single directional light rotation
        /// </summary>
        public Vec3 LightRotation { get; set; }
    }
}

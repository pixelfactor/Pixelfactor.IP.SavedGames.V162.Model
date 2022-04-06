using Pixelfactor.IP.SavedGames.V162.Model.FleetOrders;
using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    /// <summary>
    /// This class was mainly used by scenarios to artificially inject some ships on a timer. The sandbox is now able to spawn fleets via the faction AI/>
    /// </summary>
    public class FleetSpawner
    {
        public string Name { get; set; }
        public Vec3 Position { get; set; }
        public Vec4 Rotation { get; set; }
        public float InitialSpawnTimeRandomness { get; set; }
        public float SpawnTimeRandomness { get; set; }
        public string ShipDesignation { get; set; }
        public string ShipName { get; set; }
        public string NamePrefix { get; set; }
        public int SpawnCounter { get; set; }
        public bool RespawnWhenNoObjectives { get; set; }
        public bool RespawnWhenNoPilots { get; set; }
        public bool AllowRespawnInActiveScene { get; set; }
        public Unit FleetHomeBase { get; set; }
        public Sector FleetHomeSector { get; set; }
        public Faction OwnerFaction { get; set; }
        public Sector Sector { get; set; }
        public Unit SpawnDock { get; set; }
        public double NextSpawnTime { get; set; }
        public float MinTimeBeforeSpawn { get; set; }
        public float MaxTimeBeforeSpawn { get; set; }
        public int MinGroupUnitCount { get; set; }
        public int MaxGroupUnitCount { get; set; }
        /// <summary>
        /// Any fleet that has already been spawned
        /// </summary>
        public Fleet SpawnedFleet { get; set; }
        /// <summary>
        /// Possible ship types that will be spawned
        /// </summary>
        public List<UnitClass> UnitClasses { get; set; } = new List<UnitClass>();
        public List<string> PilotResourceNames { get; set; } = new List<string>();
        public string FleetResourceName { get; set; }

        /// <summary>
        /// Fleet orders to assign to the fleet after it is spawned
        /// </summary>
        public List<FleetOrder> Orders { get; set; } = new List<FleetOrder>();
    }
}

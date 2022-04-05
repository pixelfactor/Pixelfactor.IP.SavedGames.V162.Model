using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    /// <summary>
    /// This type was used in early version to artificially inject fleets into the game<br />
    /// It is still used by the <see cref="Entities.Jobs.JobTypes.DestroyFleetJob"/>
    /// </summary>
    public class FleetSpawnParams
    {
        public Faction Faction { get; set; }

        public string FleetResourceName { get; set; }

        /// <summary>
        /// Optional home base for the spawned units
        /// </summary>
        public Unit HomeBaseUnit { get; set; }

        /// <summary>
        /// Optional home sector for the spawned units
        /// </summary>
        public Sector HomeSector { get; set; }

        /// <summary>
        /// The designation given to all spawned units
        /// </summary>
        public string ShipDesignation { get; set; }

        /// <summary>
        /// Description of each unit to spawn
        /// </summary>
        public List<FleetSpawnParamsItem> Items = new List<FleetSpawnParamsItem>();

        /// <summary>
        /// Dock that the spawned units will be spawned at if assigned
        /// </summary>
        public Unit TargetDockUnit { get; set; }

        /// <summary>
        /// Position to spawn at (ignored if TargetDock is assigned)
        /// </summary>
        public Vector3 TargetPosition { get; set; }

        /// <summary>
        /// Sector the spawned units spawn in (ignored if TargetDock is assigned)
        /// </summary>
        public Sector TargetSector { get; set; }
    }
}

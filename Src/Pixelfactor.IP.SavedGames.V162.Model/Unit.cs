using Pixelfactor.IP.SavedGames.V162.Model.Jobs;
using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    /// <summary>
    /// The base world object type for IP - Could be a ship, stations, asteroid, projectile, wormhole or others
    /// </summary>
    public class Unit
    {
        public int Id { get; set; }

        /// <summary>
        /// Defines the type of unit this is
        /// </summary>
        public UnitClass Class { get; set; }
        public Sector Sector { get; set; }
        public Vector3 Position { get; set; }
        public Vector4 Rotation { get; set; }
        public Faction Faction { get; set; }
        /// <summary>
        /// Requisition point provision. Provides faction with chance to build more units
        /// </summary>
        public int RpProvision { get; set; }

        /// <summary>
        /// If this unit is a piece of cargo, this will be populated
        /// </summary>
        public UnitCargoData CargoData { get; set; }

        /// <summary>
        /// Not used in 1.6.x
        /// </summary>
        public UnitDebrisData DebrisData { get; set; }

        /// <summary>
        /// Defines info about ships that a station sells
        /// </summary>
        public UnitShipTraderData ShipTraderData { get; set; }

        /// <summary>
        /// Used when this unit is a projectile
        /// </summary>
        public UnitProjectileData ProjectileData { get; set; }

        /// <summary>
        /// A custom name for this unit. If null/empty the game displays the unit name based on other rules.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This would be set if this is a ship or a station
        /// </summary>
        public ComponentUnitData ComponentUnitData { get; set; }

        /// <summary>
        /// Assign to set a custom health value
        /// </summary>
        public UnitHealthData HealthData { get; set; }

        public List<PassengerGroup> PassengerGroups { get; set; } = new List<PassengerGroup>();

        /// <summary>
        /// Set when this unit is a wormhole
        /// </summary>
        public UnitWormholeData WormholeData { get; set; }
        public List<Job> Jobs { get; set; } = new List<Job>();
    }
}

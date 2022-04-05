using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    /// <summary>
    /// Represents a type of unit that can hold components/weapons - usually a ship or station
    /// </summary>
    public class ComponentUnitData
    {
        /// <summary>
        /// If using a generated ship name this would be assigned
        /// </summary>
        public string CustomShipName { get; set; }

        /// <summary>
        /// NOT USED - will be overwritten when game loads
        /// </summary>
        public float CargoCapacity { get; set; }

        public ComponentUnitFactoryData FactoryData { get; set; }

        public bool IsUnderConstruction { get; set; }

        public float ConstructionProgress { get; set; }

        /// <summary>
        /// Helps to uniquely identify the station within the sector
        /// </summary>
        public int StationUnitClassNumber { get; set; }

        /// <summary>
        /// Used when the ship/station has different components from the vanilla spec
        /// </summary>
        public ComponentUnitModData ModData { get; set; }

        public float? CapacitorCharge { get; set; }

        public bool IsCloaked { get; set; }

        public List<int> PoweredDownBayIds { get; set; } = new List<int>();

        public float? EngineThrottle { get; set; }

        public ComponentUnitCargoData CargoData { get; set; }

        public ComponentUnitShieldHealthData ShieldData { get; set; }

        public ComponentUnitComponentHealthData ComponentHealthData { get; set; }

        /// <summary>
        /// Some data about a ship when it is in the "active" sector.<br />
        /// DO NOT SET THIS IF THE SHIP IS NOT IN THE ACTIVE SECTOR. 
        /// </summary>
        public ComponentUnitActiveData ActiveData { get; set; }

        /// <summary>
        /// Ships docked at this unit
        /// </summary>
        public ComponentUnitDockData DockData { get; set; }

        /// <summary>
        /// Should be existing within the <see cref="People" collection/>
        /// </summary>
        public Person Pilot { get; set; }

        /// <summary>
        /// All the people on this ship/station
        /// </summary>
        public List<Person> People { get; set; } = new List<Person>();
        public int ShipNameIndex { get; set; }
    }
}

using Pixelfactor.IP.SavedGames.V162.Model.Jobs;
using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public class SavedGame
    {
        public Header Header { get; set; }

        /// <summary>
        /// Seconds since start of game
        /// </summary>
        public double SecondsElapsed { get; set; }
        public List<Person> People { get; } = new List<Person>();
        public List<Sector> Sectors { get; } = new List<Sector>();

        public List<Faction> Factions { get; } = new List<Faction>();

        /// <summary>
        /// Not used in custom universe
        /// </summary>
        public List<SectorPatrolPath> PatrolPaths { get; } = new List<SectorPatrolPath>();

        public List<Unit> Units { get; } = new List<Unit>();

        public List<Fleet> Fleets { get; } = new List<Fleet>();

        /// <summary>
        /// These were mainly used by scenarios to artificially inject some ships on a timer. The sandbox is now able to spawn fleets via the faction AI/>
        /// </summary>
        public List<FleetSpawner> FleetSpawners { get; } = new List<FleetSpawner>();

        public Player Player { get; set; }

        public List<ActiveJob> ActiveJobs { get; } = new List<ActiveJob>();

        public Unit CurrentHudTarget { get; set; }
        public ScenarioData ScenarioData { get; set; }
        public List<PlayerUnitFleetMap> PlayerUnitFleetMap { get; } = new List<PlayerUnitFleetMap>();
        public List<Moon> Moons { get; } = new List<Moon>();
    }
}

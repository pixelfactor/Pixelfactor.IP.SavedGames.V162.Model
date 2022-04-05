using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model.Jobs.ActiveJobs
{
    public class ActiveDestroyUnitsJob : ActiveJob
    {
        public List<Unit> TargetUnits { get; set; } = new List<Unit>();
        public bool HasSetGroupHostileToPlayer { get; set; }
        public Faction TargetFaction { get; set; }
        public Sector TargetSector { get; set; }
        public Fleet TargetFleet { get; set; }
    }
}

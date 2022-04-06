namespace Pixelfactor.IP.SavedGames.V162.Model.Jobs.JobTypes
{
    public class BreakdownJob : Job
    {
        public Sector BreakdownDestinationSector { get; set; }
        public Vec3 BreakdownDestinationPosition { get; set; }
        public UnitClass BreakdownUnitClass { get; set; }
    }
}

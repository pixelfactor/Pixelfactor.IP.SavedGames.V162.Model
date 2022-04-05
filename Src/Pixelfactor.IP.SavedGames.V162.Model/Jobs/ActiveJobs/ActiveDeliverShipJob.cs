namespace Pixelfactor.IP.SavedGames.V162.Model.Jobs.ActiveJobs
{
    public class ActiveDeliverShipJob : ActiveJob
    {
        public UnitClass UnitClass { get; set; }
        public Unit DestinationUnit { get; set; }
    }
}

namespace Pixelfactor.IP.SavedGames.V162.Model.Jobs.JobTypes
{
    public class DeliverShipJob : Job
    {
        public UnitClass UnitClass { get; set; }
        public Unit DestinationUnit { get; set; }
    }
}

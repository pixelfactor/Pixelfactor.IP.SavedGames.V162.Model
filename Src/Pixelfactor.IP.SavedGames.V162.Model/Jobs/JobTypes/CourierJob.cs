namespace Pixelfactor.IP.SavedGames.V162.Model.Jobs.JobTypes
{
    public class CourierJob : Job
    {
        public Unit PickupUnit { get; set; }
        public Unit DestinationUnit { get; set; }
        public ComponentUnitCargoDataItem Cargo { get; set; }
    }
}

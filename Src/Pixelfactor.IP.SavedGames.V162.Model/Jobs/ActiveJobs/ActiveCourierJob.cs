namespace Pixelfactor.IP.SavedGames.V162.Model.Jobs.ActiveJobs
{
    public class ActiveCourierJob : ActiveJob
    {
        public Unit PickupUnit { get; set; }
        public Unit DestinationUnit { get; set; }
        public ComponentUnitCargoDataItem CargoItem { get; set; }
        public bool HasPlayerPickedUpCargo { get; set; }
    }
}

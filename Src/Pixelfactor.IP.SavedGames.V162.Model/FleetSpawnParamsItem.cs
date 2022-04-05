namespace Pixelfactor.IP.SavedGames.V162.Model
{
    /// <summary>
    /// A single item with a <see cref="FleetSpawnParams"/>
    /// </summary>
    public class FleetSpawnParamsItem
    {
        public string PilotResourceName { get; set; }
        public string ShipName { get; set; }
        public UnitClass UnitClass { get; set; }
        public bool AddCargoLoadout { get; set; } = true;
    }
}

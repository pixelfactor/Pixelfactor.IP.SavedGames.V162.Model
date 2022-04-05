namespace Pixelfactor.IP.SavedGames.V162.Model
{
    /// <summary>
    /// The health of a single component on a ship/station
    /// </summary>
    public class ComponentUnitComponentHealthDataItem
    {
        public int BayId { get; set; }

        /// <summary>
        /// From 0 - 1
        /// </summary>
        public float Health { get; set; }
    }
}

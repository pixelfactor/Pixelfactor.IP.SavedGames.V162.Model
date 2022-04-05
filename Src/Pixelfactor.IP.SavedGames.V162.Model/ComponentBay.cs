namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public class ComponentBay
    {
        /// <summary>
        /// The id local to the ship this bay is placed on
        /// </summary>
        public int Id { get; set; }
        public ComponentBayType Type { get; set; }
        public string Name { get; set; }
    }
}

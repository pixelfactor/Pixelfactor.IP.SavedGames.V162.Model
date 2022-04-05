namespace Pixelfactor.IP.SavedGames.V162.Model
{
    /// <summary>
    /// Used by engine to keep track of what units the player has assigned to what fleet 
    /// </summary>
    public class PlayerUnitFleetMap
    {
        public Unit Unit { get; set; }
        public Fleet Fleet { get; set; }
    }
}

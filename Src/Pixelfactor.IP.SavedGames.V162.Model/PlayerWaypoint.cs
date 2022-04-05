namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public class PlayerWaypoint
    {
        public Vector3 Position { get; set; }
        public Sector Sector { get; set; }
        public Unit TargetUnit { get; set; }
        public bool HadTargetObject { get; set; }
    }
}

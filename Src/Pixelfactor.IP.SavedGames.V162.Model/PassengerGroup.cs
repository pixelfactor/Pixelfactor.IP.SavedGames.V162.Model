namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public class PassengerGroup
    {
        public int Id { get; set; }
        public Unit Unit { get; set; }
        public Unit SourceUnit { get; set; }
        public Unit DestinationUnit { get; set; }
        public int PassengerCount { get; set; }
        public double ExpiryTime { get; set; }
        public int Revenue { get; set; }
    }
}

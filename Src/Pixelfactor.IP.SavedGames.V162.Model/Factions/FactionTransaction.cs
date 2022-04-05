namespace Pixelfactor.IP.SavedGames.V162.Model.Factions
{
    /// <summary>
    /// Represents a recent change in credits. Should only be required by player faction
    /// </summary>
    public class FactionTransaction
    {
        public FactionTransactionType TransactionType { get; set; }
        public int Value { get; set; }
        public int CurrentBalance { get; set; }
        public Unit LocationUnit { get; set; }
        public Faction OtherFaction { get; set; }
        public int RelatedCargoClassId { get; set; }
        public UnitClass RelatedUnitClass { get; set; }
        public double GameWorldTime { get; set; }
    }
}

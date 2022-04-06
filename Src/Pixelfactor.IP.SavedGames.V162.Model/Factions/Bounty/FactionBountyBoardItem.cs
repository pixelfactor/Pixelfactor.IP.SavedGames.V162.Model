namespace Pixelfactor.IP.SavedGames.V162.Model.Factions.Bounty
{
    public class FactionBountyBoardItem
    {
        public Person TargetPerson { get; set; }
        public int Reward { get; set; }
        public Unit LastKnownTargetUnit { get; set; }
        public Sector LastKnownTargetSector { get; set; }
        public Vec3? LastKnownTargetPosition { get; set; }
        /// <summary>
        /// The faction that added the bounty
        /// </summary>
        public Faction SourceFaction { get; set; }
    }
}

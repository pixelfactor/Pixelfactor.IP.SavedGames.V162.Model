namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public class FactionRelationDataItem
    {
        public Faction OtherFaction { get; set; }

        public bool PermanentPeace { get; set; }

        public bool RestrictHostilityTimeout { get; set; }
        public Neutrality Neutrality { get; set; }

        /// <summary>
        /// Fixed time when make peace
        /// </summary>
        public double HostilityEndTime { get; set; }

        /// <summary>
        /// Determines when to make war
        /// </summary>
        public float RecentDamageReceived { get; set; }
    }
}

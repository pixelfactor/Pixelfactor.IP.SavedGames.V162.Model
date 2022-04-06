namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public class Person
    {
        public bool IsMale { get; set; }

        /// <summary>
        /// Applies when the person is pilotting a ship
        /// </summary>
        public NpcPilotSettings NpcPilotSettings { get; set; }
        public int Id { get; set; }
        public int GeneratedFirstNameId { get; set; } = -1;
        public int GeneratedLastNameId { get; set; } = -1;

        /// <summary>
        /// Use this OR the generated name ids
        /// </summary>
        public string CustomName { get; set; }

        /// <summary>
        /// Don't touch - determines what the person says when contacted by the player
        /// </summary>
        public int DialogId { get; set; }
        public Faction Faction { get; set; }
        public bool DestroyGameObjectOnKill { get; set; }
        public int Kills { get; set; }

        public Unit CurrentUnit { get; set; }

        public bool IsPilot { get; set; }

        public NpcPilot NpcPilot { get; set; }
    }
}

using Pixelfactor.IP.SavedGames.V162.Model.FleetOrders;
using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public class Fleet
    {
        public int Id { get; set; }

        public Vec3 Position { get; set; }

        public Vec4 Rotation { get; set; }

        public Sector Sector { get; set; }

        public Faction Faction { get; set; }

        public Unit HomeBaseUnit { get; set; }

        /// <summary>
        /// When true the parent faction won't' try to control
        /// </summary>
        public bool ExcludeFromFactionAI { get; set; }

        /// <summary>
        /// Optional custom settings
        /// </summary>
        public FleetSettings FleetSettings { get; set; }

        /// <summary>
        /// Note: Due to a massive bug in the way 1.6.x loads a save game, fleet orders in the save file can be ignored when game loads <em>if the order involves another fleet</em><br />
        /// E.g. The attack fleet order will sometimes break when loaded
        /// </summary>
        public FleetOrderCollection Orders { get; set; } = new FleetOrderCollection();

        public bool IsActive { get; set; } = true;

        /// <summary>
        /// The npcs inside this fleet (pilots)
        /// </summary>
        public List<NpcPilot> Npcs { get; set; } = new List<NpcPilot>();
    }
}

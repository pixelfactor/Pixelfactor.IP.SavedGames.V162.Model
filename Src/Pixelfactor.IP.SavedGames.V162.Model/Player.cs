using Pixelfactor.IP.SavedGames.V162.Model.Jobs;
using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public class Player
    {
        public List<Unit> VisitedUnits { get; set; } = new List<Unit>();
        public List<PlayerMessage> Messages { get; set; } = new List<PlayerMessage>();
        public List<PlayerDelayedMessage> DelayedMessages { get; set; } = new List<PlayerDelayedMessage>();
        public ActiveJob ActiveJob { get; set; }
        public PlayerWaypoint CustomWaypoint { get; set; }

        /// <summary>
        /// These are the numbered fleets that can be assigned in the orders panel
        /// </summary>
        public List<Fleet> Fleets { get; set; } = new List<Fleet>();

        public Person Person { get; set; }

        public Faction Faction => this.Person?.Faction;
    }
}

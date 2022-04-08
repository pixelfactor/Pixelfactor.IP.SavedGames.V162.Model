using Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.Models;
using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.OrderTypes
{
    public class PatrolOrder : FleetOrder
    {
        public int PathDirection { get; set; }
        public bool IsLooping { get; set; }
        public List<PatrolPathNode> Nodes { get; set; } = new List<PatrolPathNode>();
        public bool IsLoop { get; set; }

        public override FleetOrderType OrderType => FleetOrderType.Patrol;
    }
}

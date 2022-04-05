using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    /// <summary>
    /// Docked ships
    /// </summary>
    public class ComponentUnitDockData
    {
        public List<ComponentUnitDockDataItem> Items { get; set; } = new List<ComponentUnitDockDataItem>();
    }
}
